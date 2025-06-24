namespace ConsoleAppStringProblems
{
    public class LengthOfLongestSubstringSol_TwoPointers
    {
        public void Code()
        {
            string s = "abcabcbb"; // s = "bbbbb", s = "pwwkew";
            Console.WriteLine($"LengthOfLongestSubstring: {LengthOfLongestSubstring(s)}");
        }

        private int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int longest = 0;
            int start = 0;
            var lastSeen = new Dictionary<char, int>();

            for (int end = 0; end < s.Length; end++)
            {
                char c = s[end];
                if (lastSeen.TryGetValue(c, out int prevIndex) && prevIndex >= start)
                {
                    start = prevIndex + 1;
                }
                lastSeen[c] = end;
                longest = Math.Max(longest, end - start + 1);
            }

            return longest;
        }
    }
}
