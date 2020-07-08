using System;

namespace BinarySearch
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] input1 = { 4, 8, 15, 16, 23, 42 };
                int input2 = 15;
                Console.WriteLine(BinarySearch(input1, input2));
            }

            static int BinarySearch(int[] arr, int searchVal)
            {
                int start = 0;
                int end = arr.Length - 1;
                do
                {
                    int midPoint = (start + end) / 2;
                    Console.WriteLine($"start: {start}, end: {end}, midpoint: {midPoint}, arr[midpoint]: {arr[midPoint]}");
                    if (arr[midPoint] == searchVal)
                    {
                        return midPoint;
                    }
                    else if (arr[midPoint] < searchVal)
                    {
                        start = midPoint + 1;
                    }
                    else
                    {
                        end = midPoint - 1;
                    }
                }
                while (start <= end);
                return -1;
            }
        }
}

    

