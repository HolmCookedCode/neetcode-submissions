public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
    // establish a dictionary
    Dictionary<int, int> counts = new Dictionary<int, int>();

    // establish an array of length = to nums
    Stack<int>[] buckets = new Stack<int>[nums.Length + 1];
    for (int i = 0; i < buckets.Length; i++)
    {
        buckets[i] = new Stack<int>();
    }

    int max = 1;

    // move through nums
    foreach (int num in nums)
    {
        if (counts.ContainsKey(num))
        {
            counts[num]++;
            if (counts[num] > max) max = counts[num];
        }
        else
        {
            counts.Add(num, 1);
        }
    }
    // 1:1, 2:2, 3:3

    // move through dictionary
    foreach (int num in counts.Keys)
    {
        int countIndex = counts[num];
        buckets[countIndex].Push(num);
    }
    // | _ | 1 | 2 | 3 |
    // 3, 2

    // get top results
    int[] output = new int[k];
    int outPos = 0;

    for (int i = max; i > 0; i--) {
        while (buckets[i].Count > 0)
        {
            output[outPos] = buckets[i].Pop();
            if (outPos == output.Length - 1) return output;
            outPos++;
        }
    }

    return output;
    }
}
