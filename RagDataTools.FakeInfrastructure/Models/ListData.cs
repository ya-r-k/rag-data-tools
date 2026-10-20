namespace RagDataTools.FakeInfrastructure.Models;

public class ListData
{
    public int Id { get; set; }

    public bool IsOrdered { get; set; }

    public ListItem[] Items { get; set; } = [];
}
