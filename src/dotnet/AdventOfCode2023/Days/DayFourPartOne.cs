namespace AdventOfCode2023.Days;

public static class DayFourPartOne
{
    private const StringSplitOptions SplitOptions = StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries;

    public static void Run()
    {
        var data = File.ReadAllLines("Data/04.txt");
        var result = GetResult(data);
        Console.WriteLine(result);
    }

    internal static int GetResult(IEnumerable<string> data)
    {
        return data.Sum(GetScore);
    }

    private static int GetScore(string entry)
    {
        var split = entry.Split(':', SplitOptions).Last().Split('|', SplitOptions);
        var winningNumbers = split.First().Split(' ', SplitOptions).Select(int.Parse).ToHashSet();
        var numbers = split.Last().Split(' ', SplitOptions).Select(int.Parse);

        var numberOfCorrectNumbers = numbers.Count(winningNumbers.Contains);
        return (int)Math.Pow(2, numberOfCorrectNumbers - 1);
    }
}
