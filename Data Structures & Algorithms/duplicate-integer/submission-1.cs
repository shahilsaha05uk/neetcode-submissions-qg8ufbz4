public class Solution {
    public bool hasDuplicate(int[] nums)         
    {
            HashSet<int> seen = [];
            foreach (int num in nums)
            {
                if(seen.Contains(num))
                    return true;
                seen.Add(num);
            }
            return false;
        }

}