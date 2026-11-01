// WordCount: the counting pattern, applied to words.
//
// Part E. Count is Exercise 5.
using System.Text.RegularExpressions;

public static class WordCount
{
    // Return how many times each word appears in text.
    //   1. Lowercase the text, so "To" and "to" count as the same word.
    //   2. Split it into words. Spaces and the punctuation marks , . ! ? ; :
    //      all separate words, and empty pieces are skipped.
    //   3. Use the counting pattern: a new word starts at 1, a word you
    //      have seen before goes up by 1.
    public static Dictionary<string, int> Count(string text)
    {
        // TODO: Part E, Exercise 5
        Dictionary<string, int> words = new Dictionary<string, int>();
        string[] allWords = Regex.Split(text.ToLower(), @"[^a-z0-9]+");

        foreach (string word in allWords) 
        { 
            if (word == "")
            {
                continue;
            }
            if (words.ContainsKey(word))
            {
                words[word]++;
            }
            else
            {
                words.Add(word, 1);
            }
        }
        return words;
        //throw new NotImplementedException();
    }
}
