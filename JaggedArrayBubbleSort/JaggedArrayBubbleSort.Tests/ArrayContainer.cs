using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Tests
{
    public class ArrayContainer
    {
        private static readonly ArrayContainer Finstance = new ArrayContainer();

        static ArrayContainer()
        {

        }

        static public ArrayContainer Instance
        {
            get { return Finstance; }
        }

        public int[][] array1 = new int[5][];
        public int[][] array1SortedSum = new int[5][];
        public int[][] array1SortedMin = new int[5][];
        public int[][] array2 = new int[4][];
        public int[][] array2SortedMax = new int[4][];
        public int[][] array2SortedSum = new int[4][];
        public int[][] array3 = new int[6][];
        public int[][] array3SortedSum = new int[6][];

        private ArrayContainer()
        {
            array1 = new int[5][];
            array1SortedSum = new int[5][];
            array1SortedMin = new int[5][];
            array2 = new int[4][];
            array2SortedMax = new int[4][];
            array2SortedSum = new int[4][];
            array3 = new int[6][];
            array3SortedSum = new int[6][];
            array1[0] = new int[] { 4, 5, 0, 100 };
            array1[1] = new int[] { 4, 1030 };
            array1[2] = new int[] { 1 };
            array1[3] = new int[] { 12, 100 };
            array1[4] = new int[] { -434444411, 1324300 };
            array1SortedSum[0] = new int[] { -434444411, 1324300 };
            array1SortedSum[1] = new int[] { 1 };
            array1SortedSum[2] = new int[] { 4, 5, 0, 100 };
            array1SortedSum[3] = new int[] { 12, 100 };
            array1SortedSum[4] = new int[] { 4, 1030 };
            array1SortedMin[0] = new int[] { -434444411, 1324300 };
            array1SortedMin[1] = new int[] { 4, 5, 0, 100 };
            array1SortedMin[2] = new int[] { 1 };
            array1SortedMin[3] = new int[] { 4, 1030 };
            array1SortedMin[4] = new int[] { 12, 100 };
            array2[0] = new int[] { 23, 2, 11, 10, -53453452 };
            array2[1] = new int[] { 123, -223, 2 };
            array2[2] = new int[] { 3, 13, 2, -4, -12342, 0, 11, 12, 13, -14 };
            array2[3] = new int[] { 3, 3, 2 };
            array2SortedMax[0] = new int[] { 3, 3, 2 };
            array2SortedMax[1] = new int[] { 3, 13, 2, -4, -12342, 0, 11, 12, 13, -14 };
            array2SortedMax[2] = new int[] { 23, 2, 11, 10, -53453452 };
            array2SortedMax[3] = new int[] { 123, -223, 2 };
            array2SortedSum[0] = new int[] { 23, 2, 11, 10, -53453452 };
            array2SortedSum[1] = new int[] { 3, 13, 2, -4, -12342, 0, 11, 12, 13, -14 };
            array2SortedSum[2] = new int[] { 123, -223, 2 };
            array2SortedSum[3] = new int[] { 3, 3, 2 };
            array3[0] = new int[] { 5, 1, 20 };
            array3[1] = null;
            array3[2] = new int[] { 25, 19, -2012 };
            array3[3] = new int[] { 5, 192, 1, 123, 0, 12533 };
            array3[4] = null;
            array3[5] = new int[] { 1, 2, 3, 4, -3 };
            array3SortedSum[0] = null;
            array3SortedSum[1] = null;
            array3SortedSum[2] = new int[] { 25, 19, -2012 };
            array3SortedSum[3] = new int[] { 1, 2, 3, 4, -3 };
            array3SortedSum[4] = new int[] { 5, 1, 20 };
            array3SortedSum[5] = new int[] { 5, 192, 1, 123, 0, 12533 };
        }
    }
}
