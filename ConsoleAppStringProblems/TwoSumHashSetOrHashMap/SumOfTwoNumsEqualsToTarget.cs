namespace ConsoleAppStringProblems.TwoSumHashSetOrHashMap
{
    public class SumOfTwoNumsEqualsToTarget
    {
        public void Code()
        {
            //Question 1
            //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.You may assume that each input would have exactly 
            //one solution, and you may not use the same element twice.You can return the answer in any order.
            int[] inputArr = { 1, 2, 3, 4, 5, 6 };
            int targetVal = 7;

            var output = Fun(inputArr, targetVal);
            Console.WriteLine($"Index1: {output.Item1}, Index: 2: {output.Item2}");
        }

        private (int, int) Fun(int[] arr, int target)
        {
            int index1 = -1, index2 = -1;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int num = target - arr[i];
                if (!dic.ContainsKey(num))
                {
                    dic.Add(arr[i], i);
                }
                else
                {
                    index1 = i;
                    index2 = dic[num];
                    break;
                }
            }
            return (index1, index2);
        }

        //Another way
        //public int[] TwoSum(int[] nums, int target)
        //{
        //    int[] result = new int[2];
        //    result[0] = 0;
        //    result[1] = 0;

        //    Dictionary<int, int> ds = new Dictionary<int, int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        //Logic to solve
        //        //target = nums[i] + nums[j];
        //        //nums[j] = target - nums[i];

        //        int v = target - nums[i];
        //        if (ds.ContainsKey(v))
        //        {
        //            result[0] = i;
        //            result[1] = ds[v];
        //            break;
        //        }

        //        if (!ds.ContainsKey(nums[i]))
        //        {
        //            ds.Add(nums[i], i);
        //        }
        //    }

        //    return result;
        //}
    }
}
