public class Solution {
    public bool IsPalindrome(string s) {
    if (s.Length == 1 || String.IsNullOrWhiteSpace(s)) return true;

    String bad = "";

    foreach (char c in s) {
        if (!Char.IsLetterOrDigit(c)) bad += c.ToString();
    }

    if (bad.Length == s.Length) return true;

    // left index
    int l = 0;

    // right index
    int r = s.Length - 1;

    // while left is less than right
    while (l < r)
    {
        // while left is not a letter
        while (!Char.IsLetterOrDigit(s[l])) l++;
        // increase left
        // while right is not a letter
        while (!Char.IsLetterOrDigit(s[r])) r--;
        // increase right

        char leftChar = s[l];
        char rightChar = s[r];

        if (Char.IsLetter(leftChar)) leftChar = Char.ToLower(leftChar);
        if (Char.IsLetter(rightChar)) rightChar = Char.ToLower(rightChar);

        if (leftChar != rightChar) return false;
        l++;
        r--;
    }
    // return true
    return true;
    }
}
