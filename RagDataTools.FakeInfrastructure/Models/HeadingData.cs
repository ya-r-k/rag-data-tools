namespace RagDataTools.FakeInfrastructure.Models;

public class HeadingData
{
    public int Id { get; set; }

    public int PageNumber { get; set; }

    public int Level { get; set; }

    public string Text { get; set; } = string.Empty;

    public int FirstSubHeadingId { get; set; }

    public int NextHeadingId { get; set; }
}
