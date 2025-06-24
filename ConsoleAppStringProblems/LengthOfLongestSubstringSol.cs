namespace ConsoleAppStringProblems
{
    public class LengthOfLongestSubstringSol
    {
        public void Code()
        {
            string s = "abcabcbb"; // s = "bbbbb", s = "pwwkew";
            Console.WriteLine($"LengthOfLongestSubstring: {LengthOfLongestSubstring(s)}");
        }

        private int LengthOfLongestSubstring(string s)
        {
            int longest = 0;
            HashSet<char> uniqSeq = new HashSet<char>();

            foreach (var c in s)
            {
                if (uniqSeq.Contains(c))
                {
                    if (uniqSeq.Count() > longest)
                        longest = uniqSeq.Count();

                    uniqSeq.Clear();
                    uniqSeq.Add(c);
                }
                else
                {
                    uniqSeq.Add(c);
                }
            }

            return longest;
        }
    }
}
