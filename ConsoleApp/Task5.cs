/*
Additional ways:
1. Using LINQ:
var line = arr.Where(a => arr.Count(x => x == a) == 1);
foreach(var i in line)
    Console.WriteLine(i);
2. Using LINQ in other way:
var res = arr.GroupBy(x => x).FirstOrDefault(x=>x.Count()==1);
if (res != null)
    Console.WriteLine(res.Key);
3. Using XOR:
var res = 0;
foreach (var x in arr) 
    res ^= x;
*/
namespace ConsoleApp
{
    /// <summary>
    /// Задание 5. Дан массив целых чисел, в котором все числа, кроме одного,
    /// встречаются ровно два раза (например: 2, 5, 3, 8, 0, 5, 2, 0, 8).
    /// Напишите программу, которая определяет то число, которое встречается ровно один раз (3 для приведенного выше массива).
    /// </summary>
    internal static class Task5
    {
        internal static int? FindUnique(int[] arr)
        {
            int? res = null;
            for (var i = 0; i < arr.Length; i++)
            {
                var temp = 0;
                for (var j = 0; j < arr.Length; j++)
                    if (arr[j] == arr[i])
                        temp++;
                if (temp == 1)
                {
                    res = arr[i];
                    break;
                }
            }
            return res;
        }
    }
}
