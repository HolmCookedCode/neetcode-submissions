public class Solution {
    public bool hasDuplicate(int[] nums) {
    // Establish a visited dictionary
    Dictionary<int, int> visited = new Dictionary<int, int>();

    // Loop through
    for (int i = 0; i < nums.Length; i++) {
        // is current position in visited dictionary?
        if (visited.ContainsKey(nums[i]))
        {
            // if yes, return true and exit
            return true;
        }
        else {
            // if no, add position to visited
            visited.Add(nums[i], i);
        }
    }

    // return false
    return false;
    }
}
