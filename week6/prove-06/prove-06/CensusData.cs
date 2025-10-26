namespace prove_06;

public static class CensusData {
    /// <summary>
    /// Read a census file and summarize the degrees (education)
    /// earned by those contained in the file.  The summary
    /// should be stored in a dictionary where the key is the
    /// degree earned and the value is the number of people that 
    /// have earned that degree.  The degree information is in
    /// the 4th column of the file.  There is no header row in the
    /// file.
    /// </summary>
    /// <param name="filename">The name of the file to read</param>
    /// <returns>fixed array of divisors</returns>
    public static Dictionary<string, int> SummarizeDegrees(string filename) {
        var degrees = new Dictionary<string, int>();
        foreach (var line in File.ReadLines(filename)) {
            var fields = line.Split(",");
            // Todo Problem 2 - ADD YOUR CODE HERE
            var degree = fields[3];
            if (degrees.ContainsKey(degree) == false) { // check if degree is already in dictionary
                degrees[degree] = 1; // if not, add it with count 1
            } else {
                degrees[degree]++;  // if it is, increment the count
            }
        }

        return degrees;
    }
}