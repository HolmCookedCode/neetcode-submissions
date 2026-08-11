public class Solution {
    public bool IsAnagram(string s, string t) {
    if (s.Length != t.Length) return false;

    int[] sCounts = new int[26];
    int[] tCounts = new int[26];

    for (int i = 0; i < s.Length; i++) {
        char sChar = s[i];
        int sIndex = ((int)Char.ToUpper(sChar)) - 65;
        sCounts[sIndex]++;

        char tChar = t[i];
        int tIndex = ((int)Char.ToUpper(tChar)) - 65;
        tCounts[tIndex]++;
    }

    string sKey = String.Join(",", sCounts);
    string tKey = String.Join(",", tCounts);

    return sKey.Equals(tKey);
    }
}
