namespace kata_dotnet_core_start.Lib;

public sealed record Rover
{
    public Location Location { get; private init; }
    public Direction Direction { get; private init; }

    public static Rover DeployTo(Location location, Direction direction = Direction.North)
    {
        return new Rover
        {
            Location = location,
            Direction = direction,
        };
    }

    public Rover MoveForward() => this with {Location = Location.MoveIntoDirection(Direction)};

    public Rover MoveBackward() => this with {Location = Location.MoveIntoDirection(Direction.Opposite())};

    public Rover TurnLeft() => this with {Direction = Direction.Left()};

    public Rover TurnRight() => this with {Direction = Direction.Opposite().Left()};

    public Rover ExecuteCommands(CommandSet commands)
        => commands.Aggregate(this, (rover, command) => command switch
        {
            Command.Forward => rover.MoveForward(),
            Command.Backward => rover.MoveBackward(),
            Command.Left => rover.TurnLeft(),
            Command.Right => rover.TurnRight()
        });
}
