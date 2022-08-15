using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class SorterHandler
    {
        public static ISortProcessor CreateSorter(int userSelect, int[] intArray, OrderBy order)
        {
            ISortProcessor sortProcessor = null;
            switch (userSelect)
            {
                case 1:
                    {
                        sortProcessor = new SelectingSorter(intArray, order);
                        break;
                    }
                case 2:
                    {
                        sortProcessor = new BubbleSorter(intArray, order);
                        break;
                    }
                case 3:
                    {
                        sortProcessor = new InsertionSorter(intArray, order);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return sortProcessor;
        }
    }
}
