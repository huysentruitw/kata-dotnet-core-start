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
    [InlineData(Cell.One)]
    [InlineData(Cell.Two)]
    [InlineData(Cell.Three)]
    [InlineData(Cell.Four)]
    [InlineData(Cell.Five)]
    [InlineData(Cell.Six)]
    [InlineData(Cell.Seven)]
    [InlineData(Cell.Eight)]
    [InlineData(Cell.Nine)]
    public void Given_DoMove_When_NewGame_Then_ExpectMoveOfPlayerXOnBoard(Cell cell)
    {
        // Arrange
        var game = new Game();

        //Act
        game.Move(cell);

        //Assert
        var expectedBoard = new Player?[3, 3];
        var expectedRow = ((int)cell - 1) / 3;
        var expectedColumn = ((int)cell - 1) % 3;
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
}
