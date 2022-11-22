
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
}