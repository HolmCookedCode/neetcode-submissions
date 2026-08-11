public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
            // Create hashmap with strings as keys and list of words as a value
    Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();

    // Move through strings
    foreach (string word in strs) {
        // create an int array of length 26
        int[] alphabet = new int[26];

        // move through each character in the word
        foreach (char c in word) {
            // get the int value of the letter
            int position = char.ToUpper(c) - 'A';

            // set int array to length 1.
            alphabet[position]++;
        }

        // convert to string
        string key = string.Join("|", alphabet);

        // if hashmap contains key, add to list
        if (anagramMap.ContainsKey(key))
        {
            anagramMap[key].Add(word);
        }
        // else create a new list at that key with word as the first value
        else
        {
            anagramMap.Add(key, new List<string> { word });
        }
    }

    // return hashmap values
    return anagramMap.Values.ToList();
    }
}
