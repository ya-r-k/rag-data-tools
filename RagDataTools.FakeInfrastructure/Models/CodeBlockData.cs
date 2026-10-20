namespace RagDataTools.FakeInfrastructure.Models;

public class CodeBlockData : TextData
{
    public bool IsUnusual { get; set; }

    public string Language { get; set; } = string.Empty;
}
