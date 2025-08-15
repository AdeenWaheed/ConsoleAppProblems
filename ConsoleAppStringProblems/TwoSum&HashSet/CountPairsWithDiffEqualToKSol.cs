namespace ConsoleAppStringProblems
{
    public class CountPairsWithDiffEqualToKSol
    {
        public void Code()
        {
            //Problem: Count pairs with absolute difference equal to k.
            //Output: 3-1, 5-3, 4-2

            //Logic idea
            //arr[i] - arr[j] = k; -> arr[i] - k = arr[j];
            //arr [i] - arr[j] = -k; -> arr[i] + k = arr[j];

            int[] arr = [3, 2, 1, 5, 4]; int k = 2;

            int counter = 0;
            HashSet<int> hasSet = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hasSet.Contains(arr[i] - k))
                    counter++;
                else if (hasSet.Contains(arr[i] + k))
                    counter++;
                else
                    hasSet.Add(arr[i]);
            }

            Console.WriteLine($"Pairs: {counter}, with absolute difference equal to k");
        }

    }
}
