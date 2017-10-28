using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public static class ArrayOfArraySort
    {
        public static void Sort(int[][] array, SortMethod sortMethod = SortMethod.BySum,
            SortOrder sortOrder = SortOrder.Ascending)
        {
            if (array == null)
                throw new ArgumentNullException("array", "Null Reference");
            int border = array.Length, tempBorder = 0;
            for (int i = 0; i < border - 1; ++i)
            {
                if (NeedSwap(array[i], array[i + 1], sortMethod, sortOrder))
                {
                    Swap(ref array[i], ref array[i + 1]);
                    tempBorder = i + 1;
                }
                if (tempBorder == 0)
                    break;
                border = tempBorder;
                tempBorder = 0;
            }
        }

        private static bool NeedSwap(int[] low, int[] high, SortMethod method, SortOrder order)
        {
            if (order == SortOrder.Ascending)
                if (Compare(low, high, method) > 0)
                    return true;
                else
                    return false;
            else if (order == SortOrder.Descending)
                if (Compare(low, high, method) < 0)
                    return true;
                else
                    return false;
            else
                throw new ArgumentException("Argument \"order\" should be of SortOrder values");
        }

        private static int Compare(int[] a, int [] b, SortMethod method)
        {
            if (a == null)
                if (b == null)
                    return 0;
                else
                    return -1;
            else if (b == null)
                return 1;

            switch (method)
            {
                case SortMethod.BySum:
                    int sumA = 0, sumB = 0;
                    for (int i = 0; i < a.Length; ++i)
                        sumA += a[i];
                    for (int i = 0; i < b.Length; ++i)
                        sumB += b[i];
                    return sumA - sumB;
                case SortMethod.ByMax:
                    int maxA = int.MinValue, maxB = int.MinValue;
                    for (int i = 0; i < a.Length; ++i)
                        if (a[i] > maxA)
                            maxA = a[i];
                    for (int i = 0; i < b.Length; ++i)
                        if (b[i] > maxB)
                            maxB = b[i];
                    return maxA - maxB;
                case SortMethod.ByMin:
                    int minA = int.MaxValue, minB = int.MaxValue;
                    for (int i = 0; i < a.Length; ++i)
                        if (a[i] < minA)
                            minA = a[i];
                    for (int i = 0; i < b.Length; ++i)
                        if (b[i] < minB)
                            minB = b[i];
                    return minA - minB;
                default:
                    throw new ArgumentException("Argument \"method\" should be of SortMethod values");
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }

    public enum SortMethod { BySum, ByMax, ByMin }
    public enum SortOrder { Ascending, Descending }
}
