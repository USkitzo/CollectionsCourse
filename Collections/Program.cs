using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static int ArraySum(int[] t)
        {
            int sum = 0;

            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }

            return sum;
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] : {array[i]}");
            }
        }

        static void ShowMaxValue(int[] array)
        {
            int vMax = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > vMax)
                {
                    vMax = array[i];
                }            
            }
            Console.WriteLine();
            Console.WriteLine($"La valeur maximale est {vMax}");
        }

        static void ShowMinValue(int[] array)
        {
            int vMin = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < vMin)
                {
                    vMin = array[i];
                }
            }
            Console.WriteLine($"La valeur minimale est {vMin}");
        }

        static void Arrays()
        {
            //int[] t = {200, 40, 18, 57, 26};
            const int LENGTH_ARRAY = 20;
            int[] t = new int[LENGTH_ARRAY];
            Random rand = new Random();

            for (int i = 0; i < t.Length; i++)
            {
                t[i] += rand.Next(101);
            }

            ShowArray(t);
            ShowMaxValue(t);
            ShowMinValue(t);
        }

        static void ShowList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i]}");
            }
        }

        static void Lists()
        {
            List<int> list = new List<int>();

            list.Add(2);
            list.Add(8);
            list.Add(15);

            ShowList(list);
        }

        static void Main(string[] args)
        {
            //Arrays();
            Lists();
        }
    }
}
