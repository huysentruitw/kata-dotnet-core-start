using System.Drawing;
using FluentAssertions;

namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void When_DeployNewRoverToLocation_Then_RoverIsOnThatLocation()
    {
        // Arrange
        var location = new Location(10, 20);

        // Act
        var rover = Rover.DeployTo(location);

        // Assert
        rover.Location.Should().Be(location);
    }

    [Theory]
    [InlineData(Direction.North)]
    [InlineData(Direction.East)]
    [InlineData(Direction.South)]
    [InlineData(Direction.West)]
    public void When_DeployNewRoverInCertainDirection_Then_RoverIsLookingInThatDirection(Direction direction)
    {
        // Arrange
        var location = new Location(10, 20);

        // Act
        var rover = Rover.DeployTo(location, direction);

        // Assert
        rover.Direction.Should().Be(direction);
    }
}
