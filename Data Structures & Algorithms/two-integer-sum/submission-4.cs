public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> diffMap = new Dictionary<int, int>();
        for (int i = 0; i< nums.Length; i++)
        {
            var n = nums[i];
            var diff = target - n;
            if (diffMap.TryGetValue(diff, out int value)) return [value, i];
            else diffMap[n] = i;
        }
        return [];
    }
}
