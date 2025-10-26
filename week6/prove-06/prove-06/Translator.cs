namespace prove_06;

public class Translator {
    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string fromWord, string toWord) {
        // Todo Problem 1 - ADD YOUR CODE HERE
        _words[fromWord] = toWord; // Adds a new word or updates the translation
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord) {
        // Todo Problem 1 - ADD YOUR CODE HERE
        return _words.GetValueOrDefault(fromWord, "???"); // Returns the translated word if it exists, otherwise returns "???"
    }
}