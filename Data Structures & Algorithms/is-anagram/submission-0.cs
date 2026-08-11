public class Solution {
    public bool IsAnagram(string s, string t) {
    if (s.Length != t.Length) return false;

    Dictionary<char, int> cCount = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        char a = s[i];
        if (cCount.ContainsKey(a))
        {
            cCount[a]++;
        }
        else {
            cCount.Add(a, 1);
        }

        char b = t[i];
        if (cCount.ContainsKey(b))
        {
            cCount[b]--;
        }
        else {
            cCount.Add(b, -1);
        }
    }

    foreach (char c in cCount.Keys) {
        if (cCount[c] != 0) return false;
    }

    return true;
    }
}
