namespace prove_01;

public class Lists
{
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        List<double> multiplesRaw = new List<double>(); // list to add multiples to return

        for (int i = 1; i <= length; i++) // cycles through specified length
        {
            multiplesRaw.Add(number * i); // adds multiple of number to list
        }

        double[] multiples = multiplesRaw.ToArray(); // converts list to array
        
        return multiples; // returns list of multiples
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        for (int i = 0; i < amount; i++)    // cycle "amount" times
        {
            int lastElement = data[data.Count - 1]; // store last element
            data.RemoveAt(data.Count - 1); // remove last element
            data.Insert(0, lastElement); // insert last element at the beginning
        }
    }
}