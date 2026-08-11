public class Solution {
    public bool IsAnagram(string s, string t) {
        // if not same length, false
        if (s.Length != t.Length) {
            return false;
        }

        // establish s array. Position = letter
        int[] sArr = new int[26];
        int[] tArr = new int[26];

        // move through both, store results in array
        for (int i = 0; i < s.Length; i++) {
            int sPos = s[i] - 'a';
            sArr[sPos]++;

            int tPos = t[i] - 'a';
            tArr[tPos]++;
        }

        // convert dictionaries to strings
        string sKey = string.Join(".", sArr);
        string tKey = string.Join(".", tArr);

        // compare strings
        return sKey.Equals(tKey);
    }
}
