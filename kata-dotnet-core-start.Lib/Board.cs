namespace kata_dotnet_core_start.Lib;

public sealed record Board
{
    private readonly Player?[,] _data = new Player?[3,3];

    public Player?[,] AsArray()
    {
        return _data;
    }

    public void Set()
    {
        _data[1, 1] = Player.X;
    }
}
