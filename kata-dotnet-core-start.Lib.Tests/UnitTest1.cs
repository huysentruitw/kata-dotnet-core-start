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

    [Theory]
    [InlineData(Direction.North, 100, 101)]
    [InlineData(Direction.East, 101, 100)]
    [InlineData(Direction.South, 100, 99)]
    [InlineData(Direction.West, 99, 100)]
    public void Given_RoverDeployedAtX100Y100_When_RoverReceivesForwardCommand_Then_RoverMovesForwardInCurrentDirection(
        Direction initialDirection,
        int expectedX,
        int expectedY)
    {
        // Arrange
        var location = new Location(100, 100);
        var rover = Rover.DeployTo(location, initialDirection);

        // Act
        rover = rover.MoveForward();

        // Assert
        rover.Location.Should().Be(new Location(expectedX, expectedY));
    }
}
