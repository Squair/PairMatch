using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
/*
 * Summary:
 * This program when given a list of integers and a target value will output any pairs that can be added together to 
 * result in the target value without using the same value twice, unless the number has been added twice into the list.
 * Does with one single pass of the list. O(n) 
 */
    public static void writeSum(int a, int b, int target)
    {
        Console.Write("{0} + {1} = {2}\n", a, b, target);
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10 };
        int target = 16;

        Dictionary<int, int> pair = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            try
            {
                //Insert the difference as the key and right operand as value
                pair.Add(Math.Abs(target - numbers[i]), numbers[i]);
            }
            catch //Handle if key already exists in dict
            {
                //If number apears in list twice and key already exists and is half the target, we know its a pair
                if (target / 2 == numbers[i])
                {
                    writeSum(numbers[i], numbers[i], target);
                }
            }

            //If differnce in dict matches i then its a pair, excludes using the same number twice
            if (pair.ContainsKey(numbers[i]) && pair[numbers[i]] != numbers[i])
            {
                writeSum(numbers[i], pair[numbers[i]], target);
            }
        }
    }
}