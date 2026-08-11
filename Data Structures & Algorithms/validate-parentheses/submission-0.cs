public class Solution {
    public bool IsValid(string s) {
            // stack
    Stack<char> stack = new Stack<char>();

    // move thorugh the string
    foreach (char c in s)
    {
        // if left
        if (c == '(' || c == '[' || c == '{')
        {
            // add to a stack
            stack.Push(c);
        }
        // else
        else {
            if (stack.Count == 0) return false;

            // pop from stack and compare
            char left = stack.Pop();

            // if they don't line up
            switch (c) {
                case ')':
                    if (left != '(') return false;
                    break;
                case ']':
                    if (left != '[') return false;
                    break;
                case '}':
                    if (left != '{') return false;
                    break;
            }
        }

    }

    if (stack.Count == 0) return true;
    return false;
    }
}
