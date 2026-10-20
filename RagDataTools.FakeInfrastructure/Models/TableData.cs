namespace RagDataTools.FakeInfrastructure.Models;

public class TableData
{
    public int Id { get; set; }

    public string Caption { get; set; } = string.Empty;

    public string[] Headers { get; set; } = [];

    public string[][] Rows { get; set; } = [];

    public bool HasHeader { get; set; } = true;
}
