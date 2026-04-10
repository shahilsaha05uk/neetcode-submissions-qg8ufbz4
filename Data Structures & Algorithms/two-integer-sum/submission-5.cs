public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> diffMap = [];
            for(int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if(diffMap.ContainsKey(diff))
                    return [diffMap[diff], i];
                diffMap.Add(nums[i], i);
            }
            return [];
    }
}
