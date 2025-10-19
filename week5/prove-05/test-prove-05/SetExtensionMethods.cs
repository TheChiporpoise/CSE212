namespace test_prove_05;

public static class SetExtensionMethods {
    public static List<(string, string)> SortPairs(this List<(string, string)> pairs)
    {
        var reordered = new List<(string, string)>(pairs.Count);
        foreach (var (word, pair) in pairs)
        {
            reordered.Add(word[0] < pair[0] ? (word, pair) : (pair, word));
        }

        return reordered;
    }
}