using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public static class ArrayOfArraySort
    {
        public static void Sort(int[][] array, IComparer<int[]> comparer, SortOrder sortOrder = SortOrder.Ascending)
        {
            if (array == null)
                throw new ArgumentNullException("array", "Null Reference");
            int border = array.Length, tempBorder = 0;
            while (border != 0)
            {
                for (int i = 0; i < border - 1; ++i)
                {
                    if (NeedSwap(array[i], array[i + 1], comparer, sortOrder))
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        tempBorder = i + 1;
                    }
                }
                border = tempBorder;
                tempBorder = 0;
            }
        }

        private static bool NeedSwap(int[] low, int[] high, IComparer<int[]> comparer, SortOrder order)
        {
            if (order == SortOrder.Ascending)
                if (comparer.Compare(low, high) > 0)
                    return true;
                else
                    return false;
            else if (order == SortOrder.Descending)
                if (comparer.Compare(low, high) < 0)
                    return true;
                else
                    return false;
            else
                throw new ArgumentException("Argument \"order\" should be of SortOrder values");
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
    
    public enum SortOrder { Ascending, Descending }
}
