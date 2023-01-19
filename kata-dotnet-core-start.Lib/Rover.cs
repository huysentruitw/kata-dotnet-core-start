namespace kata_dotnet_core_start.Lib;

public sealed class Rover
{
    public Location Location { get; private init; }

    public static Rover DeployTo(Location location)
    {
        return new Rover
        {
            Location = location
        };
    }
}
