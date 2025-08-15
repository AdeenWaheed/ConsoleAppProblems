namespace ConsoleAppStringProblems.TwoPointersApproach
{
    public class SumOfTwoNumsEqualsToTarget_TwoPointers
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
            //Two Pointer approach can only be applied on a sorted array
            int left = 0, right = arr.Length-1;
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target)
                    return (left, right);
                else if (sum < target)
                    left--;
                else
                    right--;
            }
            return (-1, -1);
        }
    }
}
