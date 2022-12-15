namespace kata_dotnet_core_start.Lib;

public static class CellExtensions
{
    public static int GetRow(this Cell cell)
        => ((int) cell - 1) / 3;

    public static int GetColumn(this Cell cell)
        => ((int) cell - 1) % 3;
}
