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
        return Player.Y;
    }
}
