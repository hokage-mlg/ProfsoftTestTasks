/*
Additional way:
How to use System Collections:
Enumerable.Any Method
public static bool Any (this System.Collections.Generic.IEnumerable source);
Determines whether a sequence contains any elements.
String.Contains Method
public bool Contains (string value);
Returns a value indicating whether a specified substring occurs within this string.
Enumerable.Intersect Method
Intersect(IEnumerable, IEnumerable)
public static System.Collections.Generic.IEnumerable Intersect (this System.Collections.Generic.IEnumerable first,
System.Collections.Generic.IEnumerable second);
Produces the set intersection of two sequences by using the default equality comparer to compare values.
 */
using System;

namespace ConsoleApp
{
    /// <summary>
    /// Напишите функцию, которая для отсортированного массива целых уникальных чисел определяет,
    /// содержится ли в нем заданное значение.
    /// </summary>
    internal static class Task2
    {
        internal static bool? SearchInArray(int? num)
        {
            if (num == null)
                return null;
            var flag = false;
            var arr = Task1.SortArray(Checkers.ArrayChecker());
            Console.WriteLine("Sorting completed!\nSorted array:");
            foreach (var i in arr)
                Console.Write(i + " ");
            if (Checkers.CheckUnique(arr))
            {
                foreach (int x in arr)
                    if (x == num)
                        flag = true;
                return flag;
            }
            else
            {
                Console.WriteLine("\nError: Array elements are not unique");
                return null;
            }
        }
    }
}
