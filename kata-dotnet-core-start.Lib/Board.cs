namespace kata_dotnet_core_start.Lib;

public sealed record Board
{
    private readonly Player?[,] _data = new Player?[3,3];

    public Player?[,] AsArray()
    {
        return _data;
    }

    public void Set(Cell cell)
    {
        var row = ((int) cell - 1) % 3;
        var column = ((int) cell - 1) / 3;

        _data[row, column] = Player.X;
    }
}
