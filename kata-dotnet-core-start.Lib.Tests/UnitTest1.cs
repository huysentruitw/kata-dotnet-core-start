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

    [Fact]
    public void Given_DoMove_When_NewGame_Then_ExpectOneMoveOnBoard()
    {
        // Arrange
        var game = new Game();

        //Act
        game.Move(Cell.Five);

        //Assert
        var expectedBoard = new Player?[3, 3];
        expectedBoard[1,1] = Player.X;
        Assert.Equal(expectedBoard, game.Board.AsArray());
    }
}
