using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using RagDataTools.Ingest;

namespace RagDataTools.Ingest.Conversion;

/// <summary>
/// Converts HTML content into Markdown text.
/// </summary>
public sealed class HtmlDocumentToMarkdownConverter : IDocumentToMarkdownConverter
{
    public DocumentFormat Format => DocumentFormat.Html;

    public Task<IReadOnlyList<MarkdownPageSegment>> ConvertAsync(Stream document, CancellationToken cancellationToken = default)
    {
        try
        {
            using var reader = new StreamReader(document, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, bufferSize: 1024, leaveOpen: true);
            var html = reader.ReadToEnd();
            cancellationToken.ThrowIfCancellationRequested();

            if (string.IsNullOrWhiteSpace(html))
            {
                return Task.FromResult<IReadOnlyList<MarkdownPageSegment>>(Array.Empty<MarkdownPageSegment>());
            }

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var markdown = RenderNode(htmlDocument.DocumentNode).Trim();
            if (string.IsNullOrWhiteSpace(markdown))
            {
                return Task.FromResult<IReadOnlyList<MarkdownPageSegment>>(Array.Empty<MarkdownPageSegment>());
            }

            return Task.FromResult<IReadOnlyList<MarkdownPageSegment>>(new[] { new MarkdownPageSegment(null, markdown) });
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new InvalidDataException("The HTML document is malformed and could not be converted to Markdown.", ex);
        }
    }

    private static string RenderNode(HtmlNode node)
    {
        var builder = new StringBuilder();
        RenderNode(node, builder);
        return builder.ToString();
    }

    private static void RenderNode(HtmlNode node, StringBuilder builder)
    {
        switch (node.NodeType)
        {
            case HtmlNodeType.Text:
                {
                    var text = HtmlEntity.DeEntitize(node.InnerText);
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        builder.Append(NormalizeInlineText(text));
                    }

                    break;
                }

            case HtmlNodeType.Element:
                {
                    var name = node.Name.ToLowerInvariant();
                    switch (name)
                    {
                        case "script":
                        case "style":
                            return;
                        case "br":
                            builder.AppendLine();
                            return;
                        case "h1":
                        case "h2":
                        case "h3":
                        case "h4":
                        case "h5":
                        case "h6":
                            {
                                var level = int.Parse(name.AsSpan(1));
                                builder.Append(new string('#', level));
                                builder.Append(' ');
                                builder.Append(RenderInlineText(node));
                                AppendBlockBreak(builder);
                                return;
                            }

                        case "p":
                        case "div":
                        case "section":
                        case "article":
                        case "header":
                        case "footer":
                        case "main":
                        case "aside":
                            RenderChildren(node, builder);
                            AppendBlockBreak(builder);
                            return;
                        case "blockquote":
                            builder.Append("> ");
                            builder.Append(RenderInlineText(node));
                            AppendBlockBreak(builder);
                            return;
                        case "pre":
                            builder.AppendLine("```");
                            builder.AppendLine(RenderInlineText(node));
                            builder.AppendLine("```");
                            AppendBlockBreak(builder);
                            return;
                        case "ul":
                            RenderList(node, builder, ordered: false);
                            AppendBlockBreak(builder);
                            return;
                        case "ol":
                            RenderList(node, builder, ordered: true);
                            AppendBlockBreak(builder);
                            return;
                        case "table":
                            RenderTable(node, builder);
                            AppendBlockBreak(builder);
                            return;
                        case "a":
                            {
                                var href = node.GetAttributeValue("href", string.Empty);
                                var text = RenderInlineText(node);
                                if (string.IsNullOrWhiteSpace(href))
                                {
                                    builder.Append(text);
                                }
                                else
                                {
                                    builder.Append('[').Append(text).Append("](").Append(href).Append(')');
                                }

                                return;
                            }

                        case "img":
                            {
                                var alt = node.GetAttributeValue("alt", string.Empty);
                                var src = node.GetAttributeValue("src", string.Empty);
                                builder.Append("![").Append(alt).Append("](").Append(src).Append(')');
                                return;
                            }

                        case "li":
                            builder.Append("- ");
                            builder.Append(RenderInlineText(node));
                            builder.AppendLine();
                            return;
                        default:
                            RenderChildren(node, builder);
                            return;
                    }
                }
        }
    }

    private static void RenderChildren(HtmlNode node, StringBuilder builder)
    {
        foreach (var child in node.ChildNodes)
        {
            RenderNode(child, builder);
        }
    }

    private static string RenderInlineText(HtmlNode node)
    {
        var builder = new StringBuilder();
        foreach (var child in node.ChildNodes)
        {
            switch (child.NodeType)
            {
                case HtmlNodeType.Text:
                    builder.Append(HtmlEntity.DeEntitize(child.InnerText));
                    break;
                case HtmlNodeType.Element:
                    if (child.Name.Equals("br", StringComparison.OrdinalIgnoreCase))
                    {
                        builder.Append(' ');
                    }
                    else
                    {
                        builder.Append(RenderInlineText(child));
                    }

                    break;
            }
        }

        return NormalizeInlineText(builder.ToString());
    }

    private static void RenderList(HtmlNode node, StringBuilder builder, bool ordered)
    {
        var index = 1;
        foreach (var item in node.Elements("li"))
        {
            builder.Append(ordered ? $"{index}. " : "- ");
            builder.Append(RenderInlineText(item));
            builder.AppendLine();
            index++;
        }
    }

    private static void RenderTable(HtmlNode node, StringBuilder builder)
    {
        var rows = node.Elements("tr").ToArray();
        if (rows.Length == 0)
        {
            foreach (var row in node.Descendants("tr"))
            {
                rows = rows.Append(row).ToArray();
            }
        }

        if (rows.Length == 0)
        {
            builder.Append(RenderInlineText(node));
            return;
        }

        foreach (var row in rows)
        {
            var cells = row.Elements("th")
                .Concat(row.Elements("td"))
                .Select(RenderInlineText)
                .Where(cell => !string.IsNullOrWhiteSpace(cell))
                .ToArray();

            if (cells.Length > 0)
            {
                builder.AppendLine($"| {string.Join(" | ", cells)} |");
            }
        }
    }

    private static void AppendBlockBreak(StringBuilder builder)
    {
        if (builder.Length == 0)
        {
            return;
        }

        if (builder[^1] != '\n')
        {
            builder.AppendLine();
        }

        builder.AppendLine();
    }

    private static string NormalizeInlineText(string text)
    {
        return Regex.Replace(text, @"\s+", " ").Trim();
    }
}
