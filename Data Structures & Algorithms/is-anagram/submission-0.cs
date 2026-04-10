public class Solution {
    public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length) return false;
            Dictionary<char, int> seen = [];
            // Add all the chars in s to the seen dictionary
            foreach (char c in s)
            {
                if (seen.TryGetValue(c, out int value))
                    seen[c] = ++value;
                else
                    seen[c] = 1;
            }

            foreach(char c in t)
            {
                // if the char is not in the seen dictionary, return false
                if (!seen.TryGetValue(c, out int value))
                    return false;

                // if the char is in the seen dictionary, decrement the count
                if (value - 1 <= 0)
                    seen.Remove(c);
                else
                    seen[c]--;
            }

            return seen.Count <= 0;

    }
}
