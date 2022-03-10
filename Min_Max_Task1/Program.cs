using System;

namespace Array_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 17, 29, 38, 55, 3, 100, 245, 35, 78 };
            Console.Write("The first situation  ");
            foreach (int array in nums)
            {
                Console.Write(array + " ");
            }

            Swap(nums);

            Console.Write("The last situation ");
            foreach (int array in nums)
            {
                Console.Write(array + " ");
            }
            Console.ReadLine();
        }
        static void Swap(int[] array)
        {
            int min = 0;
            int max = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[min] > array[i])
                    min = i;
                if (array[max] < array[i])
                    max = i;
            }
            int index = array[min];
            array[min] = array[max];
            array[max] = index;
        }
    }
}
