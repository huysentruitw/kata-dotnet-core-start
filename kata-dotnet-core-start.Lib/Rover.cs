namespace kata_dotnet_core_start.Lib;

public sealed class Rover
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
}
