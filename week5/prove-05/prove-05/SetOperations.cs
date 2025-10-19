namespace prove_05;

public static class SetOperations
{
    /// <summary>
    /// Performs a set intersection operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    public static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        var result = new HashSet<int>();

        foreach (var value in set1)
        {
            if (set2.Contains(value))
            {
                result.Add(value);
            }
        }
        
        return result;
    }

    /// <summary>
    /// Performs a set union operation.
    /// </summary>
    /// <param name="set1">A set of integers</param>
    /// <param name="set2">A set of integers</param>
    public static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        var result = set1;

        foreach(var value in set2)
        {
            if (set1.Contains(value))
            {
                continue;
            }
            else
            {
                result.Add(value);
            } 
        }
        // TODO Problem 1.2 (don't forget to fill out the 05-prove-response.md)
        return result;
    }

    /// <summary>
    /// The words parameter contains a list of two character 
    /// words (lower case, no duplicates). Using sets, find an O(n) 
    /// solution for finding all symmetric pairs of words.  
    ///
    /// For example, if <c>words</c> was: <c>[am, at, ma, if, fi]</c>, we would return:
    /// <code>
    /// am &amp; ma
    /// if &amp; fi
    /// </code>
    /// The order of the items above does not matter. It could just as easily be
    /// <code>
    /// fi &amp; if
    /// am &amp; ma
    /// </code>
    /// <c>at</c> would not 
    /// be displayed because <c>ta</c> is not in the list of words.
    /// <br />
    /// As a special case, if the letters are the same (example: 'aa') then
    /// it would not match anything else (remember no the assumption above
    /// that there were no duplicates) and therefore should not be displayed.
    /// </summary>
    /// <param name="words">An array of 2-character words (lowercase, no duplicates)</param>
    /// <returns>A list of word pairs</returns>
    public static List<(string, string)> FindPairs(string[] words)
    {
        var wordSet = new HashSet<string>(words); // Allows updated word list to avoid repeat additions
        var results = new List<(string, string)>();
        
        foreach (var word in wordSet)
        {
            var reversed = new string([word[1], word[0]]);
            if (word != reversed && wordSet.Contains(reversed))
            {
                results.Add((word, reversed));
                wordSet.Remove(reversed);
            }
            wordSet.Remove(word);
        }
        System.Console.WriteLine(results);

        // Use something like: results.Add(("am", "ma"));
        return results;
    }
}