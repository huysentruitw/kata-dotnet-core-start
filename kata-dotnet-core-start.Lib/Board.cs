﻿namespace kata_dotnet_core_start.Lib;

public sealed record Board
{
    private readonly Player?[,] _data = new Player?[3,3];

    public Player?[,] AsArray()
    {
        return _data;
    }

    public void Set(Cell cell, Player nextPlayer)
    {
        var row = ((int) cell - 1) / 3;
        var column = ((int) cell - 1) % 3;

        if (_data[row, column] is not null)
            throw new IllegalMoveException();

        _data[row, column] = nextPlayer;
    }
}
