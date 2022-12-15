namespace kata_dotnet_core_start.Lib.Tests;

public class UnitTest1
{
    [Fact]
    public void Given_When_CreateNewGame_Then_ContainsEmpty3x3Board()
    {
        // Arrange

        // Act
        var game = new Game();

        // Assert
        var expectedBoard = new Player?[3, 3];
        Assert.Equal(expectedBoard, game.Board.AsArray());
    }

    [Theory]
    [InlineData(Cell.One, 0, 0)]
    [InlineData(Cell.Two, 0, 1)]
    [InlineData(Cell.Three, 0, 2)]
    [InlineData(Cell.Four, 1, 0)]
    [InlineData(Cell.Five, 1, 1)]
    [InlineData(Cell.Six, 1, 2)]
    [InlineData(Cell.Seven, 2, 0)]
    [InlineData(Cell.Eight, 2, 1)]
    [InlineData(Cell.Nine, 2, 2)]
    public void Given_DoMove_When_NewGame_Then_ExpectMoveOfPlayerXOnBoard(
        Cell cell,
        int expectedRow,
        int expectedColumn)
    {
        // Arrange
        var game = new Game();

        //Act
        game.Move(cell);

        //Assert
        var expectedBoard = new Player?[3, 3];
        expectedBoard[expectedRow, expectedColumn] = Player.X;
        Assert.Equal(expectedBoard, game.Board.AsArray());
    }

    [Fact]
    public void Given_DoTwoMoves_When_NewGame_Then_ExpectSecondMovePlayerYOnBoard()
    {
        // Arrange
        var game = new Game();

        //Act
        game.Move(Cell.Two);
        game.Move(Cell.Seven);

        //Assert
        Assert.Equal(Player.Y, game.Board.AsArray()[2,0]);
    }

    [Fact]
    public void Given_DoThreeMoves_When_NewGame_Then_ExpectThirdMovePlayerXOnBoard()
    {
        // Arrange
        var game = new Game();

        //Act
        game.Move(Cell.Two);
        game.Move(Cell.Five);
        game.Move(Cell.Seven);

        //Assert
        Assert.Equal(Player.X, game.Board.AsArray()[2,0]);
    }

    [Fact]
    public void Given_DoMoveOnOccupiedCell_WhenGameInProgress_Then_ShouldThrowIllegalMoveException()
    {
        //Arrange
        var game = new Game();
        game.Move(Cell.Two);

        //Act & Assert
        Assert.Throws<IllegalMoveException>(() => game.Move(Cell.Two));
    }

    [Fact]
    public void Given_PlayerYCompletesRow_When_GameInProgress_Then_GetWinnerReturnsPlayerY()
    {
        // Arrange
        var game = new Game();

        // Act
        game.Move(Cell.One);  // Move of player X
        game.Move(Cell.Four); // Move of player Y
        game.Move(Cell.Nine); // Move of player X
        game.Move(Cell.Five); // Move of player Y
        game.Move(Cell.Two);  // Move of player X
        game.Move(Cell.Six);  // Move of player Y

        // Assert
        Assert.Equal(Player.Y, game.GetWinner());
    }

    [Fact]
    public void Given_PlayerXCompletesRow_When_GameInProgress_Then_GetWinnerReturnsPlayerX()
    {
        // Arrange
        var game = new Game();

        // Act
        game.Move(Cell.One);  // Move of player X
        game.Move(Cell.Four); // Move of player Y
        game.Move(Cell.Two); // Move of player X
        game.Move(Cell.Five); // Move of player Y
        game.Move(Cell.Three);  // Move of player X

        // Assert
        Assert.Equal(Player.X, game.GetWinner());
    }
}
