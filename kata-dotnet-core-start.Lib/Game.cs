﻿namespace kata_dotnet_core_start.Lib;

public class Game
{
    public Board Board { get; } = new();

    public void Move(Cell cell)
        => Board.Set(cell);
}
