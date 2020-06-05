namespace ConsoleApp
{
    /// <summary>
    /// Напишите программу, которая определяет сумму целых чисел из интервала от 1 до 1000,
    /// которые делятся без остатка на 3 или на 5.
    /// </summary>
    internal static class Task4
    {
        internal static int SumOfNumbers()
        {
            var sum = 0;
            var lim = 1000;
            for (var i = 1; i < lim; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            return sum;
        }
    }
}
