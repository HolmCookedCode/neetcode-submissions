public class Solution {
int BinarySearch(int[] numbers, int target)
{
    // left pointer
    int l = 0;
    // right pointer
    int r = numbers.Length - 1;

    // while left is less than or equal to right
    while (l <= r)
    {
        // calculate middle
        int m = l + (r - l) / 2;

        // if target is less than middle element
        if (target < numbers[m])
        {
            r = m - 1; // move right to m - 1
        }
        // if target is greater than middle element
        else if (target > numbers[m])
        {
            l = m + 1; // move left to m + 1
        }
        else
        {
            return m; // target found
        }
    }

    return -1; // target not found
}

    public int[] TwoSum(int[] numbers, int target) {
    // move through
    for (int i = 0; i < numbers.Length; i++) {
        // target - current = match
        int match = target - numbers[i];
        // Binary search for match, if not -1, return answer
        int binResult = BinarySearch(numbers, match);
        if (binResult != -1) {
            int one;
            int two;

            if (binResult < i) {
                one = binResult + 1;
                two = i + 1;
            }
            else
            {
                one = i + 1;
                two = binResult + 1;
            }

            return new int[] { one, two };
        }
    }

    return new int[] { -1, -1 };
    }
}
