namespace kata_dotnet_core_start.Lib;
public static class FizzBuzz
{
    public static IEnumerable<string> Generate()
    {
        for (var count = 1; count <= 100; ++count)
        {
            yield return count % 3 == 0 ? "Fizz" : "1";
        }
    }
}
