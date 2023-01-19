namespace kata_dotnet_core_start.Lib;

public sealed record Location(int X, int Y)
{
    public Location MoveIntoDirection(Direction direction)
        => direction switch
        {
            Direction.North => this with { Y = (Y + 1) % 180 },
            Direction.East => this with { X = (X + 1) % 360 },
            Direction.South => this with { Y = Y - 1 },
            Direction.West => this with { X = X - 1 },
        };
}
