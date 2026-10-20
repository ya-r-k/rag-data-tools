using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using RagDataTools.Ingest;

namespace RagDataTools.Ingest.Conversion;

/// <summary>
/// Converts Word documents into page-separated Markdown text.
/// </summary>
public sealed class WordDocumentToMarkdownConverter : IDocumentToMarkdownConverter
{
    public DocumentFormat Format => DocumentFormat.Word;

    public Task<IReadOnlyList<MarkdownPageSegment>> ConvertAsync(Stream document, CancellationToken cancellationToken = default)
    {
        try
        {
            using var word = WordprocessingDocument.Open(document, false);
            var body = word.MainDocumentPart?.Document?.Body
                ?? throw new InvalidDataException("The Word document is missing a document body.");

            var segments = new List<MarkdownPageSegment>();
            var pageNumber = 1;
            var buffer = new StringBuilder();

            void FlushPage()
            {
                var markdown = buffer.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(markdown))
                {
                    segments.Add(new MarkdownPageSegment(pageNumber, markdown));
                }

                buffer.Clear();
                pageNumber++;
            }

            void AppendBlock(string block)
            {
                if (buffer.Length > 0)
                {
                    buffer.AppendLine();
                    buffer.AppendLine();
                }

                buffer.Append(block.Trim());
            }

            foreach (var element in body.Elements())
            {
                cancellationToken.ThrowIfCancellationRequested();

                switch (element)
                {
                    case Paragraph paragraph:
                        {
                            if (paragraph.ParagraphProperties?.PageBreakBefore is not null)
                            {
                                FlushPage();
                            }

                            var paragraphText = NormalizeMarkdown(paragraph.InnerText);
                            if (!string.IsNullOrWhiteSpace(paragraphText))
                            {
                                AppendBlock(paragraphText);
                            }

                            if (paragraph.Descendants<Break>().Any(b => b.Type?.Value == BreakValues.Page))
                            {
                                FlushPage();
                            }

                            break;
                        }

                    case Table table:
                        {
                            var tableText = NormalizeMarkdown(table.InnerText);
                            if (!string.IsNullOrWhiteSpace(tableText))
                            {
                                AppendBlock(tableText);
                            }

                            break;
                        }
                }
            }

            if (buffer.Length > 0)
            {
                FlushPage();
            }

            return Task.FromResult<IReadOnlyList<MarkdownPageSegment>>(segments);
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new InvalidDataException("The Word document is malformed and could not be converted to Markdown.", ex);
        }
    }

    private static string NormalizeMarkdown(string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return string.Empty;
        }

        return text.Replace("\r\n", "\n", StringComparison.Ordinal)
            .Replace('\r', '\n')
            .Trim();
    }
}
