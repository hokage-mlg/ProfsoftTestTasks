using System;

namespace ConsoleApp
{
    /// <summary>
    /// Those methods needs to check input parameters.
    /// </summary>
    internal static class Checkers
    {
        /// <summary>
        /// This method checks the array entered through the console (needs for tasks 1,2,5).
        /// </summary>
        /// <returns>Int array or null if exception heppens.</returns>
        internal static int[] ArrayChecker()
        {
            Console.WriteLine("Enter the dimension of the array:");
            if (int.TryParse(Console.ReadLine(), out int dimension))
            {
                var array = new int[dimension];
                Console.WriteLine("Enter array elements (use \'Space\' to separate):");
                var str = Console.ReadLine().Split(' ');
                try
                {
                    for (var i = 0; i < dimension; i++)
                        array[i] = int.Parse(str[i]);
                    return array;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid array dimension!");
                return null;
            }
        }
        /// <summary>
        /// This method checks the number entered through the console (needs for task 2).
        /// </summary>
        /// <returns>Int number or null if exception heppens.</returns>
        internal static int? CheckNumber()
        {
            Console.WriteLine("Enter the number to find:");
            try
            {
                var num = int.Parse(Console.ReadLine());
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// This method checks array for unique (needs for task 2).
        /// </summary>
        /// <param name="arr">Int array.</param>
        /// <returns>If elements are unique returns True, else False.</returns>
        internal static bool CheckUnique(int[] arr)
        {
            for (var i = 0; i < arr.Length; ++i)
                for (var j = 0; j <= i; j++)
                    if (arr[i] == arr[j] && i != j)
                        return false;
            return true;
        }
        /// <summary>
        /// This method checks the coordinates (x and y) entered through the console (needs for task 3).
        /// </summary>
        /// <returns>Return array with coordinates (x and y) if parse to double is true, else null.</returns>
        internal static double[] CoordinatesChecker()
        {
            Console.WriteLine("Enter x-axis and y-axis coordinates (use \'Enter\' to separate):");
            if (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                var res = new double[] { x, y };
                return res;
            }
            else
            {
                Console.WriteLine("Error: Incorrect input!");
                return null;
            }
        }
    }
}
