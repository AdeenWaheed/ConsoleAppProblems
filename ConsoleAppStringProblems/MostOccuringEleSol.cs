namespace ConsoleAppStringProblems
{
    public class MostOccuringEleSol
    {
        public void Code()
        {
            //Given a non-empty array of integers nums, your task is to return the k most frequently occurring elements.
            //You must return the answer in any order. If there is a tie in frequency, any of the tied elements may be returned as part of the result.

            int[] nums = [1, 1, 1, 2, 2, 3]; int k = 2;
            var respArr = MostOccuringEle(nums, k);
            Console.WriteLine(string.Join(",", respArr));
        }

        private int[] MostOccuringEle(int[] nums, int k)
        {
            if (k > nums.Count())
                return Array.Empty<int>();

            Dictionary<int, int> freqDict = new Dictionary<int, int>();
            foreach (int n in nums)
            {
                if (!freqDict.ContainsKey(n))
                    freqDict.Add(n, 1);
                else
                    freqDict[n]++;
            }

            var respArr = freqDict
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .Take(k)
                .ToArray();

            return respArr;
        }

    }
}
