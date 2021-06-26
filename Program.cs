using System;

namespace CyclicRotationSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter value for count of rotation (k): ");
            var k = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Please, enter value for length of the array (n): ");
            var n = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Please, enter array elements: ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine() ?? "0");
            }

            Console.WriteLine("Press any key to calculation and see the rotated array: ");
            Console.ReadKey();
            a = CyclicRotation(a, k);

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }


        private static int[] CyclicRotation(int[] array, int k)
        {
            var length = array.Length;

            if (length == 0)
            {
                return array;
            }

            for (var i = 0; i < k; i++)
            {
                var swap = array[length - 1];

                for (var j = length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = swap;
            }

            return array;
        }
    }




}
