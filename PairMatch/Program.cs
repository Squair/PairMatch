using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Summary:
         * This program when given a list of integers and a target value will output any pairs that can be added together to result in the target value without using the same value twice.
         * Does with one single pass of the list. O(1) 
         */

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 15;

        Dictionary<int, int> pair = new Dictionary<int, int>();
        
        for (int i = 0; i < numbers.Count; i++)
        {
            try
            {
                //Insert the difference as the key and right operand as value
                pair.Add(Math.Abs(target - numbers[i]), numbers[i]);
            }
            catch //Handle if key already exists in dict
            { }

            if (pair.ContainsKey(numbers[i]) && pair[numbers[i]] != numbers[i])
                Console.Write("{0} + {1} = {2}\n", numbers[i], pair.FirstOrDefault(x => x.Key == numbers[i]).Value, target);
        }
    }
}

