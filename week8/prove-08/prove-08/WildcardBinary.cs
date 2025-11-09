namespace prove_08;

public class WildcardBinary
{
    public List<string> Results { get; } = new();

    /// <summary>
    /// <p>A binary string is a string consisting of just 1's and
    /// 0's. For example, 1010111 is a binary string. If we introduce
    /// a wildcard symbol * into the string, we can say that this is
    /// now a pattern for multiple binary strings. For example, 101*1
    /// could be used to represent 10101 and 10111. A pattern can
    /// have more than one * wildcard. For example, 1**1 would result
    /// in 4 different binary strings: 1001, 1011, 1101, and 1111.</p>
    ///
    /// <p>Using recursion, determine all possible binary strings
    /// for a given pattern. You might find some of the string
    /// functions like <c>IndexOf</c> and <c>[..X]</c> / <c>[X..]</c>
    /// to be useful in solving this problem.</p>
    /// </summary>
    public void ExpandPattern(string pattern)
    {
        // TODO Start Problem 4
        // Valid patterns should be saved off with Results.Add(<valid pattern>);
        int index = pattern.IndexOf('*');
        if (index == -1)
        {
            Results.Add(pattern);
            return;
        }
        // Replace wildcard with '0' and recurse
        var pattern1 = pattern.ToArray();
        pattern1[index] = '0';
        ExpandPattern(new string(pattern1));
        
        // Replace wildcard with '1' and recurse
        var pattern2 = pattern.ToArray();
        pattern2[index] = '1';
        ExpandPattern(new string(pattern2));
    }
}