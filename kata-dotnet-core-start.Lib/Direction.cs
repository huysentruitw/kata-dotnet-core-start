namespace kata_dotnet_core_start.Lib;

public enum Direction
{
    North,
    East,
    South,
    West
}

public static class DirectionExtensions
{
    public static Direction Opposite(this Direction direction) =>
        direction switch
        {
            Direction.North => Direction.South,
            Direction.East => Direction.West,
            Direction.South => Direction.North,
            Direction.West => Direction.East,
            _ => throw new NotSupportedException()
        };
}
