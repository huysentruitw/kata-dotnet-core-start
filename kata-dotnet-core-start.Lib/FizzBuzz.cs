namespace kata_dotnet_core_start.Lib;
public static class FizzBuzz
{
    public static IEnumerable<string> Generate()
    {
        for (var number = 1; number <= 100; ++number)
        {
            yield return NumberToFizzBuzz(number);
        }
    }

    public static string NumberToFizzBuzz(int number)
    {
        if (number % 5 == 0 && number % 3 == 0)
            return "FizzBuzz";

        if (number % 5 == 0)
            return "Buzz";

        if (number % 3 == 0)
            return "Fizz";

        return number.ToString();
    }
}
