public class Solution {
    public bool IsPalindrome(string s) {
    // left pointer
    int l = 0;
    // right pointer
    int r = s.Length - 1;

    // while left is less than right
    while (l < r) {
        // get left character
        char lChar = char.ToLower(s[l]);
        // while left character is not alphanumeric
        while (!char.IsLetterOrDigit(lChar)) {
            // increase by 1
            l++;
            // get left character
            try
            {
                lChar = char.ToLower(s[l]);
            }
            catch {
                return true;
            }
        }

        // right character
        char rChar = char.ToLower(s[r]);

        // while right is not alphanumeric
        while (!char.IsLetterOrDigit(rChar)) {
            r--;
            try
            {
                rChar = char.ToLower(s[r]);
            }
            catch {
                return true;
            }
        }

        // if left does not equal right
        if (lChar != rChar) return false;

        // increase left
        l++;

        // decrease right
        r--;
    }

    return true;
    }
}
