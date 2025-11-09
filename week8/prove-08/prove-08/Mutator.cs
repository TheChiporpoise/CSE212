using System.Net;

namespace prove_08;

public class Mutator
{
    public List<string> Results { get; } = new();

    /// <summary>
    /// <p>Using recursion Print permutations of length
    /// 'size' from a list of 'letters'.  This function
    /// should assume that each letter is unique (i.e. the 
    /// function does not need to deduplicate letters).</p>
    ///
    /// <p>In mathematics, we can calculate the number of permutations
    /// using the formula: <c>letters.Length! / (letters.Length - size)!</c></p>
    ///
    /// <p>For example, if letters was <c>['A','B','C']</c> and <c>size</c> was 2 then
    /// the following would be added to <c>Results</c>: AB, AC, BA, BC, CA, CB
    /// (might be in a different order).</p>
    ///
    /// <p>You can assume that the size specified is always valid (between 1 
    /// and the length of the letters list).</p>
    /// </summary>
    public void PermutationsChoose(string letters, int size, string word = "")
    {
        // TODO Start Problem 2
        // Use syntax like the following once you've found a permutation
        // Results.Add("ABC");
        foreach (char letter in letters) // iterates through each letter/remaining letter
        {
            string newWord = word + letter; // updates currently tracked word
            if (newWord.Length == size)
            {
                Results.Add(newWord); // adds each word with the correct size to results
            }
            else
            {
                string remainingLetters = letters.Replace(letter.ToString(), ""); // filters out used letter
                PermutationsChoose(remainingLetters, size, newWord); // recursive call with remaining letters and updated word
            }
        }
    }
}