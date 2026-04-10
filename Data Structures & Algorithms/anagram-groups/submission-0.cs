public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
                    Dictionary<string, List<string>> result = [];
            foreach(var str in strs)
            {
                // Count characters in str
                SortedList<char, int> charCount = [];
                foreach(var c in str)
                {
                    if(!charCount.TryGetValue(c, out int count))
                        charCount.Add(c, 1);
                    else
                        charCount[c]++;
                }

                // Convert charCount to a string key
                var key = string.Join("", charCount.Select(kvp => $"{kvp.Key}{kvp.Value}"));
                if (result.TryGetValue(key, out List<string>? value)) 
                    value.Add(str);
                else
                    result[key] = [str];
            }

            return [.. result.Select(r => r.Value)];
    }
}
