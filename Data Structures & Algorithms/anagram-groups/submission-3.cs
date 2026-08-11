public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
            // Dictionary: String -> List<string>
    Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

    // move through strs
    foreach (string word in strs)
    {
        int[] alphabetMap = new int[26];
        foreach (char c in word) {
            int alphabetIndex = ((int)Char.ToUpper(c)) - 65;
            alphabetMap[alphabetIndex]++;
        }

        string alphabetKey = String.Join(",", alphabetMap);
        if (anagrams.ContainsKey(alphabetKey))
        {
            anagrams[alphabetKey].Add(word);
        }
        else {
            anagrams.Add(alphabetKey, new List<string> { word });
        }

    }

    return anagrams.Values.ToList();
    }
}
