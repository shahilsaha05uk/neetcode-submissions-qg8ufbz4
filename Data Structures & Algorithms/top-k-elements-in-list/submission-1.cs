public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            // Stores the <count, num>
            Dictionary<int, int> seen = [];

            // array of lists
            var bucket = new List<int>[nums.Length + 1];
            int[] result = new int[k];
            int resultIndex = 0;

            // Add all the numbers in the frequency map
            foreach (var n in nums)
            {
                if (seen.TryGetValue(n, out int value))
                    seen[n] = ++value;
                else
                    seen.Add(n, 1);
            }

            // Add the numbers to the bucket based on their frequency
            foreach(var n in seen)
            {
                var bucketId = n.Value;
                if (bucket[bucketId] is null)
                {
                    bucket[bucketId] = [n.Key];
                }
                else
                    bucket[bucketId].Add(n.Key);
            }

            // Traverse from the back and add the numbers to the result until we have k elements
            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                if (bucket[i] is null or { Count: <= 0 }) continue;
                var list = bucket[i];
                foreach (var n in list)
                {
                    result[resultIndex++] = n;
                    if(resultIndex == k) return result;
                }
            }

            return result;

    }
}
