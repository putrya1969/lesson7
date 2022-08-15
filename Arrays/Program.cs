using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = new int[] {85, 11, 23, 0, 46, 5 };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Source array: {intArray.PrintIntArray()}");
            sb.AppendLine("Select sort type, by entering the appropriate number, and press Enter\n1. Selection sort\n2. Bubble sort\n3. Insertion sort\n");
            Console.WriteLine(sb);
            int userSelect = 0;
            while (!int.TryParse(Console.ReadLine(), out userSelect))
            {
                Console.WriteLine("Invalid enter");
                Console.WriteLine(sb);
            }
            OrderBy order = OrderBy.Asc;
            do
            {
                Console.WriteLine("Sort in reverse order yes/no?");
                Console.WriteLine("Enter Y or N");
            }
            while (!(Console.ReadLine().CheckInput(out order)));
            ISortProcessor sortProcessor = SorterHandler.CreateSorter(userSelect, intArray, order);
            if (sortProcessor!=null)
                Console.WriteLine($"Sort type: {sortProcessor.GetType().ToString()}\nSort order: {order}\nSorted array {sortProcessor.Array.PrintIntArray()}"); 
            else
                Console.WriteLine("The user specified non-existent sort type!");
            Console.ReadKey();
        }

        public enum SortAlgorithmType
        {
            SelectingSort = 1,
            BubbleSort,
            InsertionSort
        }
    }

    public static class IntArrayExtension
    {
        public static string PrintIntArray(this int[] array)
        {
            return string.Join(" ", array);
        }
    }

    public static class UserInputExtension
    {
        public static bool CheckInput(this string str, out OrderBy order)
        {
            string[] keys = new[] { "y", "n" };
            bool result = keys.Any(str.Contains);
            if (result)
                order = str.Contains("y") ? OrderBy.Desc : OrderBy.Asc;
            else
                order = OrderBy.Asc;
            return result;
        }
    }
}
