namespace kata_dotnet_core_start.Lib;
public static class FizzBuzz
{
    public static IEnumerable<string> Generate()
    {
        for (var count = 1; count <= 100; ++count)
        {
            yield return NumberToFizzBuzz(count);
        }
    }

    private static string NumberToFizzBuzz(int count)
    {
        if (count % 5 == 0 && count % 3 == 0)
            return "FizzBuzz";

        if (count % 5 == 0)
            return "Buzz";

        if (count % 3 == 0)
            return "Fizz";

        return "1";
    }
}
