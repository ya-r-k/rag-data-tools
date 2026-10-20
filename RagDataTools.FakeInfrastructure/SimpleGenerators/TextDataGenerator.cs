using System.Text;
using RagDataTools.FakeInfrastructure.Models;

namespace RagDataTools.FakeInfrastructure.SimpleGenerators;

public class TextDataGenerator(Random random)
{
    public string GenerateDescriptionCalloutForNoteType(string noteType, string calloutType = "quote", bool isHideable = true)
    {
        return this.GenerateCallout($"{noteType} description", calloutType, isHideable);
    }

    public string GenerateCallout(string calloutTitle, string calloutType = "quote", bool isHideable = true)
    {
        var builder = new StringBuilder();
        builder.AppendFormat("> [!{0}]{1} {2}", calloutType, isHideable ? "-" : string.Empty, calloutTitle);
        builder.AppendLine();
        builder.Append("> ");

        builder.AppendLine(this.GenerateText().Replace("\r\n", "\r\n> "));

        return builder.ToString().Trim();
    }

    public HeadingData GenerateHeading(int minWordsCount = 8, int maxWordsCount = 15, int level = 1)
    {
        var headingLevel = Math.Clamp(level, 1, 6);
        return new HeadingData
        {
            Level = headingLevel,
            Text = this.GenerateSentence(minWordsCount, maxWordsCount),
        };
    }

    public string GenerateText(
        int minWords = 100,
        int maxWords = 500,
        bool useNewParagraphs = true,
        double paragraphChance = 0.1,
        int minWordsPerSentence = 8,
        int maxWordsPerSentence = 25)
    {
        var result = new StringBuilder();
        var totalWords = random.Next(minWords, maxWords + 1);
        var wordsGenerated = 0;

        while (wordsGenerated < totalWords)
        {
            wordsGenerated += this.GenerateSentence(result, minWordsPerSentence, Math.Min(maxWordsPerSentence, totalWords - wordsGenerated));

            if (useNewParagraphs)
            {
                this.AddNewParagraph(result, paragraphChance);
            }
        }

        return result.ToString().Trim();
    }

    public string GenerateSentence(int minWordsCount = 8, int maxWordsCount = 15)
    {
        var builder = new StringBuilder();

        this.GenerateSentence(builder, minWordsCount, maxWordsCount);

        return builder.ToString().Trim();
    }

    private int GenerateSentence(StringBuilder textBuilder, int minWordsCount = 8, int maxWordsCount = 15)
    {
        int wordsInSentence;

        if (minWordsCount > maxWordsCount)
        {
            wordsInSentence = maxWordsCount;
        }
        else
        {
            wordsInSentence = random.Next(minWordsCount, maxWordsCount + 1);
        }

        textBuilder.AppendFormat("{0} ", this.FirstLetterToUpperCase(FakeConsts.Words[random.Next(FakeConsts.Words.Length)]));

        if (wordsInSentence > 1)
        {
            for (int i = 1; i < wordsInSentence; i++)
            {
                textBuilder.AppendFormat("{0} ", FakeConsts.Words[random.Next(FakeConsts.Words.Length)]);
            }
        }

        textBuilder.Remove(textBuilder.Length - 1, 1);
        textBuilder.AppendFormat(FakeConsts.Punctuation[random.Next(0, FakeConsts.Punctuation.Length)]);

        return wordsInSentence;
    }

    private void AddNewParagraph(StringBuilder textBuilder, double paragraphChance)
    {
        if (random.NextDouble() < paragraphChance)
        {
            textBuilder.AppendLine();
            textBuilder.AppendLine();
        }
        else if (textBuilder.Length > 0)
        {
            textBuilder.Append(' ');
        }
    }

    private string FirstLetterToUpperCase(string word)
    {
        return char.ToUpperInvariant(word[0]) + word[1..];
    }
}

