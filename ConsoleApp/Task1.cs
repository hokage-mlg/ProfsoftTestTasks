/*
Additional way:
How to use System Collections:
Sort(Array, Int32, Int32, IComparer)
Sorts the elements in a range of elements in a one-dimensional Array using the specified IComparer.
public static void Sort(T[] array, int index, int length, System.Collections.Generic.IComparer comparer);
Sorts the elements in a range of elements in an Array using the specified IComparer generic interface.
*/
namespace ConsoleApp
{
    /// <summary>
    /// Задание 1. Дан массив целых чисел. Напишите функцию, которая получает данный массив
    /// в качестве аргумента и сортирует его по возрастанию.
    /// </summary>    
    internal static class Task1
    {
        internal static int[] SortArray(int[] array)
        {
            int max;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        max = array[i];
                        array[i] = array[j];
                        array[j] = max;
                    }
                }
            }
            return array;
        }
    }
}