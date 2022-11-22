
using FluentAssertions;

namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void FirstElementShouldBeOne()
    {
        // Arrange

        // Act
        var result = FizzBuzz.Generate();

        // Assert
        result.First().Should().Be("1");
    }

    [Fact]
    public void ResultShouldHave100Elements()
    {
        // Arrange

        // Act
        var result = FizzBuzz.Generate();

        // Assert
        result.Should().HaveCount(100);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void WhenDivisibleBy3ThenElementShouldBeFizz(int elementNumber)
    {
        // Arrange
        var result = FizzBuzz.Generate().ToArray();

        // Act
        var index = elementNumber - 1;
        var element = result[index];

        // Assert
        element.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void WhenDivisibleBy5ThenElementShouldBeBuzz(int elementNumber)
    {
        // Arrange
        var result = FizzBuzz.Generate().ToArray();

        // Act
        var index = elementNumber - 1;
        var element = result[index];

        // Assert
        element.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void WhenDivisibleBy3And5ThenElementShouldBeFizzBuzz(int elementNumber)
    {
        // Arrange
        var result = FizzBuzz.Generate().ToArray();

        // Act
        var index = elementNumber - 1;
        var element = result[index];

        // Assert
        element.Should().Be("FizzBuzz");
    }
}
