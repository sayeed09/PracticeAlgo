using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExperts.Two_Sum
{
    public class TwoSum
    {
        //Two number sum 
        //Sample input: [3, 5, -4, 8, 11, 1, -1, 6],  ---10
        //Sample output: [-1,11]
        int[] input_array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
        int targetSum = 10;
        public void First()
        {
            // Time O(N^2) Space O(1)

            for (int i = 0; i < input_array.Length - 1; i++)
            {
                for (int j = 1; j < input_array.Length; j++)
                {
                    if (targetSum == input_array[i] + input_array[j])
                    {
                        Console.WriteLine(input_array[i] + ", " + input_array[j]);
                    }
                }
            }
        }
        public void Second()
        {
            // Time-O(N) Space O(N)
            Dictionary<int, bool> dict = new Dictionary<int, bool>();

            for (int i = 0; i < input_array.Length; i++)
            {
                if (dict.ContainsKey(targetSum - input_array[i]))
                {
                    Console.WriteLine(targetSum - input_array[i] + ", " + input_array[i]);
                }
                else
                {
                    dict.Add(input_array[i], true);
                }
            }

        }

        public void Third()
        {
            // Time O(NLogN) Space- O(1)
            Array.Sort(input_array);
            int left = 0;
            int right = input_array.Length - 1;
            while (left < right)
            {
                if (input_array[left] + input_array[right] == targetSum)
                {
                    Console.WriteLine(input_array[left] + ", " + input_array[right]);
                    break;
                }
                else if (input_array[left] + input_array[right] > targetSum)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

    }
}
