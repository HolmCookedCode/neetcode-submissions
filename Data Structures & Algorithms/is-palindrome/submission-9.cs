public class Solution {
    public bool IsPalindrome(string s) {
        // left
        int l = 0;
        // right
        int r = s.Length - 1;

        while (l < r) {
            while (l < r && !Char.IsLetterOrDigit(s[l])) {
                l++;
            }

            while (l < r &&!Char.IsLetterOrDigit(s[r])) {
                r--;
            }
            
            if (Char.ToLower(s[l]) != Char.ToLower(s[r])) {
                return false;
            }
            else {
                l++;
                r--;
            }
        }
        
        return true;
    }
}
