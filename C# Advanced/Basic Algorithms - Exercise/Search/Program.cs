using System;

namespace Search
{
    public class Program
    {
        private const int KEY_NOT_FOUND = -1;

        public static void Main(string[] args)
        {
            int[] arr = new[] { 2, 7, 3, 1, 5, 9 };

            int index = BinarySearch(arr, 7, 0, arr.Length - 1);


            Console.WriteLine(index);
        }

        public static int BinarySearch(int[] arr, int search, int left, int right)
        {
            //While I still have more than 1 element in the subset
            while (right >= left)
            {
                int midIndex = (right + left) / 2;

                if (search > arr[midIndex])
                {
                    left = midIndex + 1;
                }
                else if (search < arr[midIndex])
                {
                    right = midIndex - 1;
                }
                else
                {
                    return midIndex;
                }
            }

            return KEY_NOT_FOUND;
        }
    }
}
