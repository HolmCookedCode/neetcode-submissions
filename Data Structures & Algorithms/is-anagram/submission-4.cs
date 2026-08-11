public class Solution {
    public bool IsAnagram(string s, string t) {
        // If not an equal lenght. Return false.
        if (s.Length != t.Length) 
        {
            return false;
        }

        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();

        for (char c = 'a'; c <= 'z'; c++) 
        {
            sDict.Add(c, 0);
            tDict.Add(c, 0);
        }

        // loop through both loops. One i, since same length.
        for (int i = 0; i < s.Length; i++) 
        {
            // grab character, update respective key
            sDict[s[i]]++;
            tDict[t[i]]++;

        }

        // compare keys, false if not eqal.
        string sKey = string.Join(",", sDict.Select(kvp => $"{kvp.Key}_{kvp.Value}"));
        string tKey = string.Join(",", tDict.Select(kvp => $"{kvp.Key}_{kvp.Value}"));

        if (sKey == tKey)
        {
            return true;
        }
        else 
        {
            return false;
        }

    }
}
