using AdventOfCode2023.Days;

namespace AdventOfCode2023.Tests;

public class DayThreeTests
{
    [Theory]
    [InlineData("467..114..\n...*......\n..35..633.\n......#...\n617*......\n.....+.58.\n..592.....\n......755.\n...$.*....\n.664.598..", 4361)]
    public void PartOne(string str, int expected)
    {
        var data = str.Split("\n");
        var result = DayThreePartOne.GetResult(data);
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("467..114..\n...*......\n..35..633.\n......#...\n617*......\n.....+.58.\n..592.....\n......755.\n...$.*....\n.664.598..", 467835)]
    public void PartTwo(string str, int expected)
    {
        var data = str.Split("\n");
        var result = DayThreePartTwo.GetResult(data);
        result.Should().Be(expected);
    }
}
