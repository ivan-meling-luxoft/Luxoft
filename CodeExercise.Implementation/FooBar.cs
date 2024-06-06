namespace CodeExercise.Implementation;

public class FooBar
{
    /// <summary>
    /// Returns the numbers from <paramref name="start"/> to <paramref name="finish"/> with the exception of returning "foo" instead of multiples of 3, "bar" for multiples of 5 and "foobar" for multiples of both 3 and 5
    /// </summary>
    /// <param name="start">Lower inclusive limit, should be greater than zero and lower than <paramref name="finish"/></param>
    /// <param name="finish">Upper inclusive limit, should be greater than <paramref name="start"/></param>
    /// <returns></returns>
    public IEnumerable<string> CalculateFooBar(int start, int finish)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(start, 0);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(start, finish);

        return Enumerable.Range(start, finish - start + 1).Select(i =>
        {
            var multipleOfThree = i % 3 == 0;
            var multipleOfFive = i % 5 == 0;

            var textToPrint = string.Empty;

            if (multipleOfThree)
            {
                textToPrint = "foo";
            }
            if (multipleOfFive)
            {
                textToPrint += "bar";
            }
            if (textToPrint == string.Empty)
            {
                textToPrint = i.ToString();
            }

            return textToPrint;
        });
    }
}

