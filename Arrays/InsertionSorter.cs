using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class InsertionSorter : ISortProcessor
    {
        public OrderBy Order { get; set; }
        public int[] Array { get; }

        public InsertionSorter(int[] array, OrderBy order)
        {
            Order = order;
            Array = Sort(array, Order);
        }
        public int[] Sort(int[] arr, OrderBy order = OrderBy.Asc)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return (Order == OrderBy.Asc) ? arr : arr.Reverse().ToArray();
        }
    }
}
