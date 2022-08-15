using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SelectingSorter : ISortProcessor
    {
        public OrderBy Order { get; set; }
        public int[] Array { get; }

        public SelectingSorter(int[] array, OrderBy order)
        {
            Order = order;
            Array = Sort(array, Order);
        }
        public int[] Sort(int[] arr, OrderBy order = OrderBy.Asc)
        {
            var n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                var min_index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_index])
                        min_index = j;
                }
                var temp = arr[min_index];
                arr[min_index] = arr[i];
                arr[i] = temp;
            }
            return (Order == OrderBy.Asc) ? arr : arr.Reverse().ToArray();
        }
    }
}
