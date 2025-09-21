namespace teach_01.solutions;

public static class DivisorsSolution
{
    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    public static List<int> FindDivisors(int number)
    {
        List<int> results = new List<int>();
        for (int i = 1; i < number; ++i)
        {
            if (number % i == 0)
            {
                results.Add(i);
            }
        }

        return results;
    }
}