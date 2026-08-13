public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // List contains
            // Dictionaries that use keys (string) to determine how to group words (string)
        var keyDicts = new Dictionary<string, List<string>>();

        // move through array
        foreach (string word in strs) {
            var tempDict = new Dictionary<char, int>();

            // each word gets its own dictionary
            for (char c = 'a'; c <= 'z'; c++) {
                tempDict.Add(c, 0);
            }

            foreach (char letter in word) {
                tempDict[letter]++;
            }

            // dictionary gets converted to a key
            string key = string.Join(";", tempDict.Select(kvp => $"{kvp.Key}_{kvp.Value}"));

            // compare keys
            if (keyDicts.ContainsKey(key)) {
                keyDicts[key].Add(word);
            }
            else {
                keyDicts.Add(key, new List<string>() { word });
            }
        }

        var answer = new List<List<string>>();
        foreach (var key in keyDicts) {
            answer.Add(key.Value);
        }

        return answer;
    }
}
