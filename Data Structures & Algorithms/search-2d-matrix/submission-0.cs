public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach (int[] arr in matrix) {
            if (BinarySearch(arr, target) != -1) return true;
        }

        return false;
    }

    public int BinarySearch(int[] arr, int target) {
        int l = 0;
        int r = arr.Length - 1;

        while (l <= r) {
            int m = l + (r - l) / 2;

            if (target == arr[m]) return m;
            if (target > arr[m]) {
                l = m + 1;
            }
            else {
                r = m - 1;
            }
        }

        return -1;
    }
}
