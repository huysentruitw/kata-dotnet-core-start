
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
    public void Given_InputDivisibleBy3_When_NumberToFizzBuzz_Then_ReturnsFizz(int elementNumber)
    {
        // Arrange & Act
        var result = FizzBuzz.NumberToFizzBuzz(elementNumber);

        // Assert
        result.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void Given_InputDivisibleBy5_When_NumberToFizzBuzz_Then_ReturnsBuzz(int elementNumber)
    {
        // Arrange & Act
        var result = FizzBuzz.NumberToFizzBuzz(elementNumber);

        // Assert
        result.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void Given_InputDivisibleBy3And5_When_NumberToFizzBuzz_Then_ReturnsFizzBuzz(int elementNumber)
    {
        // Arrange & Act
        var result = FizzBuzz.NumberToFizzBuzz(elementNumber);

        // Assert
        result.Should().Be("FizzBuzz");
    }

    [Theory]
    [InlineData(1)]
    [InlineData(43)]
    [InlineData(91)]
    public void Given_InputNotDivisibleBy3Or5_When_NumberToFizzBuzz_Then_ReturnsInputAsString(int elementNumber)
    {
        // Arrange & Act
        var result = FizzBuzz.NumberToFizzBuzz(elementNumber);

        // Assert
        result.Should().Be(elementNumber.ToString());
    }
}
