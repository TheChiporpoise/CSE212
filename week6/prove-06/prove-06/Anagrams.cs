namespace prove_06;

public static class Anagrams {
    /// <summary>
    /// <p>Determine if 'word1' and 'word2' are anagrams.  An anagram
    /// is when the same letters in a word are re-organized into a 
    /// new word.  A dictionary is used to solve the problem.</p>
    /// <p>Examples:</p>
    /// <p><c>is_anagram("CAT","ACT")</c> would return true</p>
    /// <p><c>is_anagram("DOG","GOOD")</c> would return false because GOOD has 2 O's</p>
    /// <p>Important Note: When determining if two words are anagrams, you
    /// should ignore any spaces. You should also ignore cases. For 
    /// example, 'Ab' and 'Ba' should be considered anagrams</p>
    /// <p>Reminder: You can access a letter by index in a string by 
    /// using the [] notation.</p>
    /// </summary>
    public static bool IsAnagram(string word1, string word2) {
        // Todo Problem 3 - ADD YOUR CODE HERE
        // remove spaces, convert to lowercase, and create a list of characters
        List<char> chars1 = word1.ToLower().Where(c => !char.IsWhiteSpace(c)).ToList();
        List<char> chars2 = word2.ToLower().Where(c => !char.IsWhiteSpace(c)).ToList();
        
        // sort the lists of characters
        chars1.Sort();
        chars2.Sort();

        // compare the sorted lists
        if (chars1.SequenceEqual(chars2))
        {
            return true;
        }

        return false;
    }
}