using AdventOfCode2023.Days;

namespace AdventOfCode2023.Tests;

public class DayTwoTests
{
    [Theory]
    [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 8)]
    public void PartOne(string str, int expected)
    {
        var data = str.Split("\n");
        var result = DayTwoPartOne.GetResult(data);
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 2286)]
    public void PartTwo(string str, int expected)
    {
        var data = str.Split("\n");
        var result = DayTwoPartTwo.GetResult(data);
        result.Should().Be(expected);
    }
}
