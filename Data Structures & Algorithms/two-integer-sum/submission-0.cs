public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    // visited dict
    Dictionary<int, int> visited = new Dictionary<int, int>();

    // loop
    for (int i = 0; i < nums.Length; i++)
    {
        // target minus current = complement
        int complement = target - nums[i];

        // is complement in visited dict?
        if (visited.ContainsKey(complement))
        {
            // answer is an array of visited dict and current
            int[] answer = { visited[complement], i };
            return answer;
        }
        // if not
        else
        {
            // add current to visited dict
            visited.Add(nums[i], i);
        }
    }
    // return -1 -1
    return new int[] { -1, -1 };
    }
}
