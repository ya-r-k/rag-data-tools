namespace RagDataTools.Ingest.Conversion;

/// <summary>
/// One Markdown segment produced by a document converter.
/// </summary>
public sealed record MarkdownPageSegment(int? pageNumber, string markdown);
