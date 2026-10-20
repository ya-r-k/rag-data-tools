using System.Text;
using RagDataTools.FakeInfrastructure.Models;

namespace RagDataTools.FakeInfrastructure.SimpleGenerators;

public class ListDataGenerator(
    Random random,
    TextDataGenerator textDataGenerator)
{
    public ListItem[] GenerateListContent(int maxItemLevel = 3, int minItemsCount = 10, int maxItemsCount = 50)
    {
        var level = 0;
        var result = new List<ListItem>();
        var itemsCount = random.Next(minItemsCount, maxItemsCount);

        for (var i = 0; i < itemsCount; i++)
        {
            result.Add(new ListItem
            {
                Level = level,
                Value = textDataGenerator.GenerateSentence(),
            });

            level = random.Next(0, Math.Min(maxItemLevel + 1, level + 2));
        }

        return [.. result];
    }

    public string GenerateMarkdownListContent(IEnumerable<ListItem> items)
    {
        var builder = new StringBuilder();

        foreach (var item in items)
        {
            builder.AppendLine($"{new string(' ', item.Level * 2)}- {item.Value}");
        }

        return builder.ToString().TrimEnd();
    }

    public ListItem[] GenerateDefaultListContent()
    {
        var items = new[]
        {
            new ListItem
            {
                Value = textDataGenerator.GenerateSentence(),
            },
        };

        return items;
    }

    public ListItem[] GenerateDefaultListContent(string listItemValue)
    {
        var items = new[]
        {
            new ListItem
            {
                Value = listItemValue,
            },
        };

        return items;
    }
}

