using System.Buffers;

namespace AdventOfCode2023.Days;

public static class DayOne
{
    private static readonly string[] wordDigits =
        { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    public static void Run()
    {
        var data = File.ReadAllLines("Data/01.txt");
        var result = GetResult(data);
        Console.WriteLine(result);
    }

    internal static int GetResult(IEnumerable<string> data)
    {
        return data.Sum(x => GetFirstResult(x) * 10 + GetLastResult(x));
    }

    private static int GetFirstResult(string entry)
    {
        var firstChar = entry.First();
        if (char.IsDigit(firstChar))
        {
            return int.Parse(firstChar.ToString());
        }

        for (var index = 0; index < wordDigits.Length; index++)
        {
            var wordDigit = wordDigits[index];
            var matches = entry.StartsWith(wordDigit);
            if (matches) return index + 1;
        }

        return GetFirstResult(new string(entry.Skip(1).ToArray()));
    }
    
    private static int GetLastResult(string entry)
    {
        var lastChar = entry.Last();
        if (char.IsDigit(lastChar))
        {
            return int.Parse(lastChar.ToString());
        }

        for (var index = 0; index < wordDigits.Length; index++)
        {
            var wordDigit = wordDigits[index];
            var matches = entry.EndsWith(wordDigit);
            if (matches) return index + 1;
        }

        return GetLastResult(new string(entry.SkipLast(1).ToArray()));
    }
}
