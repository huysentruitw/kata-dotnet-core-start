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
}
