public class Solution {

    public string Encode(IList<string> strs) {
            var encoded = "";
            foreach (var str in strs)
                encoded += $"{str.Length}#{str}";
            return encoded;

    }

    public List<string> Decode(string s) {
            var decoded = new List<string>();
            int count = 0;
            while (count < s.Length)
            {
                var c = s[count];
                if (!char.IsDigit(c)) count++;

                // get the length
                string digits = c.ToString();
                int digitCount = count+1;
                while (char.IsDigit(s[digitCount]))
                {
                    digits += s[digitCount];
                    digitCount++;
                }

                // Extract the length of the string
                int strLength = int.Parse(digits);
                var str = s.Substring(digitCount + 1, strLength);
                decoded.Add(str);
                count = digitCount + 1 + strLength;
            }
            return decoded;


   }
}
