namespace ConsoleAppStringProblems
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

            var output = Code(inputArr, targetVal);
            Console.WriteLine($"Index1: {output.Item1}, Index: 2: {output.Item2}");
        }

        private (int, int) Code(int[] arr, int target)
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
    }
}
