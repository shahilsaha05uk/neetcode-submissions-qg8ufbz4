public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
            Dictionary<string, List<string>> result = [];
            foreach(var str in strs)
            {
                int[] counts = new int[26];
                foreach (var c in str)
                    counts[c - 'a']++;
                var key = string.Join("#", counts);

                // Convert charCount to a string key
                if (result.TryGetValue(key, out List<string>? value)) 
                    value.Add(str);
                else
                    result[key] = [str];
            }

            return [.. result.Select(r => r.Value)];
    }
}
