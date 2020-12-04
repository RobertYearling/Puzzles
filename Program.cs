﻿using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoin(9); // Change the Value Here!!!
            Names();
        }
        public static int[] RandomArray()
        {
            int[] newArr = new int[10];
            Random rand = new Random();
            int i = 0;
            int max = 0;
            int min = 26;
            int sum = 0;
            while(i < 10)
            {
                newArr[i] = rand.Next(5, 26);
                sum += newArr[i];
                i++;
            }
            for(int p = 0; p < newArr.Length; p++)
            {
                if(newArr[p] > max)
                {
                    max = newArr[p];
                }
                if(newArr[p] < min)
                {
                    min = newArr[p];
                }
            }
            Console.WriteLine($"Max: {max} - Min: {min} - Sum: {sum}");
            return newArr;
        }

        public static string TossCoin()
        {
            string result = "heads";
            Random rand = new Random();
            int coin = rand.Next(1, 3);
            if(coin == 2)
            {
                result = "tails";
            }
            Console.WriteLine(result);
            return result;
        }

        public static double TossMultipleCoin(int num)
        {
            int count = 0;
            int coin;
            string result = "heads";
            for(int i = 0; i < num; i++)
            {
                Random rand = new Random();
                coin = rand.Next(1, 3);
                Console.WriteLine(coin);
                if(coin == 2)
                {
                    result = "tails";
                }
                else
                {
                    result = "heads";
                    count++;
                }
                Console.WriteLine(result);
            }
            Console.WriteLine(count);
            Console.WriteLine((double)count/num);
            return ((double)count/num);
        }

        // ***** Name
        public static List<string> Names()
        {
            List<string> names = new List<string>()
            {
                "Todd",
                "Tiffany",
                "Charlie",
                "Geneva",
                "Sydney"
            };
            Random rand = new Random();
            int individuals = rand.Next(names.Count);
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
                if(names[i].Length < 5)
                {
                    names.Remove(names[i]);
                }
            }
            Console.WriteLine(names);
            foreach(string n in names)
            {
                Console.WriteLine(n);
            }
            return names;
        }
    }
}