namespace kata_dotnet_core_start.Lib;

public class Game
{
    private Player _nextPlayer = Player.X;

    public Board Board { get; } = new();

    public void Move(Cell cell)
    {
        Board.Set(cell, _nextPlayer);
        _nextPlayer = _nextPlayer == Player.X ? Player.Y : Player.X;
    }

    public Player GetWinner()
    {
        var cells = Board.AsArray();

        var consecutiveColumns = 1;
        for (var i = 0; i < cells.GetLength(0) - 1; i++)
        {
            for (var j = 0; j < cells.GetLength(1); j++)
            {
                if (cells[i, j])
            }
        }

        return Player.Y;
    }
}
