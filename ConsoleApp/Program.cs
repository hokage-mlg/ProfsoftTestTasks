using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test tasks for Profsoft:");
            int select;
            do
            {
                Console.Clear();
                Console.WriteLine("Select the number of a task:");
                Console.WriteLine("1. Task #1.");
                Console.WriteLine("2. Task #2.");
                Console.WriteLine("3. Task #3.");
                Console.WriteLine("4. Task #4.");
                Console.WriteLine("5. Task #5.");
                Console.WriteLine("0. Exit.");
                if (int.TryParse(Console.ReadLine(), out select))
                {
                    switch (select)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Task #1:");
                            string str = null;
                            foreach (var i in Task1.SortArray(Checkers.ArrayChecker()))
                                str += i + " ";
                            Console.WriteLine($"Sorting completed!\nSorted array: {str}");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Task #2:");
                            var res = Task2.SearchInArray(Checkers.CheckNumber());
                            if (res != null)                         
                                Console.WriteLine($"\nThe number is in the array: {res}");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Task #3:");
                            var coordinates = Checkers.CoordinatesChecker();
                            Console.WriteLine($"Gets into:{Task3.CheckCoordinates(coordinates[0], coordinates[1])}");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Task #4:");
                            Console.WriteLine($"Sum: {Task4.SumOfNumbers()}");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Task #5:");
                            Console.WriteLine("Warning: All elements, except one, occur exactly two times.");
                            Console.WriteLine($"Unique element: {Task5.FindUnique(Checkers.ArrayChecker())}");
                            Console.ReadKey();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Wrong number!");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    select = -1;
                    Console.WriteLine("Invalid input!");
                    Console.ReadKey();
                }
            }
            while (select != 0);
        }
    }
}
