using System.Drawing;
using FluentAssertions;

namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void Given_Mars_When_DeployNewRoverToLocation_Then_RoverIsOnThatLocation()
    {
        // Arrange
        var location = new Location(10, 20);

        // Act
        var rover = Rover.DeployTo(location);

        // Assert
        rover.Location.Should().Be(location);
    }
}
