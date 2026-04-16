public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
                    var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                // pointer to left and right of the current index
                var product = 1;
                var right = i + 1;
                var left = i - 1;

                // do for right
                while(right < nums.Length)
                {
                    product *= nums[right];
                    right++;
                }

                // do for left
                while(left >= 0)
                {
                    product *= nums[left];
                    left--;
                }

                result[i] = product;
            }
            return result;

    }
}
