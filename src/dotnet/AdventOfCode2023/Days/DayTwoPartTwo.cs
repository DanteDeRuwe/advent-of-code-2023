namespace AdventOfCode2023.Days;

public record Cubes(int Red, int Green, int Blue);

public static class DayTwoPartTwo
{
    public static void Run()
    {
        var data = File.ReadAllLines("Data/02.txt");
        var result = GetResult(data);
        Console.WriteLine(result);
    }

    internal static int GetResult(IEnumerable<string> data)
    {
        return data.Sum(GetLineScore);
    }

    private static int GetLineScore(string line)
    {
        if (line.Split(":", StringSplitOptions.TrimEntries) is not [string gameinfo, string grabs])
            throw new Exception();

        var dict = new Dictionary<string, int>()
        {
            { "red", 0 }, { "green", 0 }, { "blue", 0 }
        };

        foreach (var grab in grabs.Split(";", StringSplitOptions.TrimEntries))
        {
            var colorAndAmounts = grab.Split(",", StringSplitOptions.TrimEntries);

            foreach (var colorAndAmount in colorAndAmounts)
            {
                if (colorAndAmount.Split(" ") is not [string amountStr, string color]) throw new Exception();
                var amount = int.Parse(amountStr);
                if (amount > dict[color]) dict[color] = amount;
            }
        }

        return dict.Values.Aggregate(1, (x,y) => x * y);;
    }
}
