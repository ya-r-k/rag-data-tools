namespace RagDataTools.FakeInfrastructure.Models;

public class MarkdownData
{
    public HeadingData[] Headings { get; set; } = [];

    public TableData[] Tables { get; set; } = [];

    public CodeBlockData[] CodeBlocks { get; set; } = [];

    public ImageData[] Images { get; set; } = [];

    public ListData[] Lists { get; set; } = [];

    public MathBlockData[] MathBlocks { get; set; } = [];

    public InfoBlockData[] InfoBlocks { get; set; } = [];

    public LinkData[] Links { get; set; } = [];

    public TextData[] Texts { get; set; } = [];
}
