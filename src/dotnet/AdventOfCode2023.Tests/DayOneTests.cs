using AdventOfCode2023.Days;

namespace AdventOfCode2023.Tests;

public class DayOneTests
{
    [Theory]
    [InlineData("1abc2,pqr3stu8vwx,a1b2c3d4e5f,treb7uchet`", 142)]
    [InlineData("two1nine,eightwothree,abcone2threexyz,xtwone3four,4nineeightseven2,zoneight234,7pqrstsixteen", 281)]
    public void Test(string str, int expected)
    {
        var data = str.Split(",");
        var result = DayOne.GetResult(data);
        result.Should().Be(expected);
    }
}
