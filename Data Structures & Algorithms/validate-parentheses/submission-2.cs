public class Solution {
    public bool IsValid(string s) {
        List<char> openBrackets = new List<char>() {'(', '{', '['};
        Stack<char> unresolvedOpens = new Stack<char>();

        // Take input
        foreach (char c in s) {
        // Is it an open vs close bracket?
            if (openBrackets.Contains(c)) {
                // If it's open, add it to the stack
                unresolvedOpens.Push(c);
            }
            else {
                // If it's closed start popping
                if (unresolvedOpens.Count == 0) {
                    return false;
                }

                var openBracket = unresolvedOpens.Pop();

                // On each pop, check to make sure the pop is valid. If it isn't, return false.
                switch (c) {
                    case ')':
                        if (openBracket != '(') {
                            return false;
                        }
                        break;
                    case '}':
                        if (openBracket != '{') {
                            return false;
                        }
                        break;
                    case ']':
                        if (openBracket != '[') {
                            return false;
                        }
                        break;
                }

            }
        }
        // if the end is reached return true.
        return unresolvedOpens.Count == 0;
    }
}
