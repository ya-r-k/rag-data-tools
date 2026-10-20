namespace RagDataTools.FakeInfrastructure.Models;

public class InfoBlockData : TextData
{
    public string BlockType { get; set; } = "quote";

    public string Title { get; set; } = string.Empty;

    public bool IsFoldable { get; set; } = true;
}
