namespace HelloWorld;

class StringUtility
{
    public static void UseSummarizeText()
    {
        var lorem =
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        var shortText = "Lorem ipsum";

        Console.WriteLine((string?)SummarizeText(lorem, 100));
        Console.WriteLine((string?)SummarizeText(shortText));
    }

    private static string SummarizeText(string text, int maxLength = 20)
    {
        if (text.Length < maxLength)
            return text;

        return GenerateSummarizeText(text, maxLength);
    }

    private static string GenerateSummarizeText(string sentence, int textMaxLength)
    {
        var words = sentence.Split(' ');
        var totalCharacters = 0;
        var summaryWords = new List<string>();

        foreach (var word in words)
        {
            totalCharacters += word.Length + 1;

            if (totalCharacters > textMaxLength)
                break;

            summaryWords.Add(word);
        }

        return string.Join(" ", summaryWords) + "...";
    }
}

