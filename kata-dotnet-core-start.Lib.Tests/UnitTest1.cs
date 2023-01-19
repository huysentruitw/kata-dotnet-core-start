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
    public void Given_RoverDeployedAtX100Y100_When_MoveForward_Then_RoverMovesForwardInCurrentDirection(
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

    [Theory]
    [InlineData(Direction.North, 100, 99)]
    [InlineData(Direction.East, 99, 100)]
    [InlineData(Direction.South, 100, 101)]
    [InlineData(Direction.West, 101, 100)]
    public void Given_RoverDeployedAtX100Y100_When_MoveBackward_Then_RoverMovesForwardInCurrentDirection(
        Direction initialDirection,
        int expectedX,
        int expectedY)
    {
        // Arrange
        var location = new Location(100, 100);
        var rover = Rover.DeployTo(location, initialDirection);

        // Act
        rover = rover.MoveBackward();

        // Assert
        rover.Location.Should().Be(new Location(expectedX, expectedY));
    }

    [Theory]
    [InlineData(Direction.North, Direction.West)]
    [InlineData(Direction.East, Direction.North)]
    [InlineData(Direction.South, Direction.East)]
    [InlineData(Direction.West, Direction.South)]
    public void Given_RoverDeployedInDirection_When_TurnLeft_Then_RoverHasTurnedLeft(
        Direction initialDirection,
        Direction expectedDirection)
    {
        // Arrange
        var location = new Location(100, 100);
        var rover = Rover.DeployTo(location, initialDirection);

        // Act
        rover = rover.TurnLeft();

        // Assert
        rover.Direction.Should().Be(expectedDirection);
    }

    [Theory]
    [InlineData(Direction.North, Direction.East)]
    [InlineData(Direction.East, Direction.South)]
    [InlineData(Direction.South, Direction.West)]
    [InlineData(Direction.West, Direction.North)]
    public void Given_RoverDeployedInDirection_When_TurnRight_Then_RoverHasTurnedRight(
        Direction initialDirection,
        Direction expectedDirection)
    {
        // Arrange
        var location = new Location(100, 100);
        var rover = Rover.DeployTo(location, initialDirection);

        // Act
        rover = rover.TurnRight();

        // Assert
        rover.Direction.Should().Be(expectedDirection);
    }

    [Theory]
    [InlineData(100, 102, Command.Forward, Command.Forward)]
    public void Given_RoverDeployedNorthAtX100Y100_When_SetOfCommand_Then_RoverArrivesAtExpectedPosition(
        int expectedX,
        int expectedY,
        params Command[] commands)
    {
        var rover = Rover.DeployTo(new Location(100, 100), Direction.North);

        rover = rover.ExecuteCommands(commands);

        rover.Location.Should().Be(new Location(expectedX, expectedY));
    }
}
