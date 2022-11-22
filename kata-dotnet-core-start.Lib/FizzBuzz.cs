namespace kata_dotnet_core_start.Lib;
public static class FizzBuzz
{
    public static IEnumerable<string> Generate()
    {
        for (var count = 1; count <= 100; ++count)
        {
            if (count % 5 == 0)
                yield return "Buzz";
            else if (count % 3 == 0)
                yield return "Fizz";
            else
                yield return "1";
        }
    }
}
