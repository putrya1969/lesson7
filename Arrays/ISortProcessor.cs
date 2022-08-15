using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public interface ISortProcessor
    {
        OrderBy Order { get; set; }
        int[] Array { get; }
        int[] Sort(int[] array, OrderBy order);
    }

    public enum OrderBy
    {
        Asc,
        Desc
    }
}
