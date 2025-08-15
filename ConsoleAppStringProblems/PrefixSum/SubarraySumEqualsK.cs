namespace ConsoleAppStringProblems.PrefixSum
{
    public class SubarraySumEqualsK
    {
        public void Code()
        {
            // Topics: Array, Prefix Sum, HashMap (Dictionary in C#)
            //Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.
            //Input: nums = [1,1,1], k = 2, Output: 2
            //Input: nums = [1,2,3], k = 3, Output: 2

            //Algo: The idea behind this approach is as follows: If the cumulative sum(represented by sum[i] for sum up to ith index) up to two indices is the same, the sum of the elements lying in between those indices is zero. Extending the same thought further, if the cumulative sum up to two indices, say i and j is at a difference of k i.e. if sum[i]−sum[j]=k, the sum of elements lying between indices i and j is k.

            int[] nums = { 1, 2, 3 };
            int k = 3;
            Console.WriteLine($"Output: {SubarraySum(nums, k)}");
        }

        public static int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            int sum = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1;

            int prefixSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                prefixSum += nums[i];

                if (map.ContainsKey(prefixSum - k))
                    count += map[prefixSum - k];

                if (map.ContainsKey(prefixSum))
                    map[prefixSum]++;
                else
                    map[prefixSum] = 1; //Same as: map.Add(prefixSum, 1);
            }

            return count;
        }
    }
}
