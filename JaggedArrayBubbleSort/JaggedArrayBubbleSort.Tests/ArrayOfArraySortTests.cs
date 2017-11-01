﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day5.Tests
{
    public static class ArrayOfArraySortTests
    {
        [Test, TestCaseSource("TestCases")]
        public static void SortTest(int testNum, int[][] array1, int[][] array2,
            IComparer<IEnumerable<int>> comparer, SortOrder order)
        {

            ArrayOfArraySort.Sort(array2, comparer, order);
            Assert.AreEqual(array1, array2);
        }

        static object[] TestCases =
        {
            new object[] { 0, ArrayContainer.Instance.array1SortedSum, ArrayContainer.Instance.array1,
                new ComparerSum<IEnumerable<int>>(), SortOrder.Ascending},
            new object[] { 1, ArrayContainer.Instance.array1SortedMin, ArrayContainer.Instance.array1,
                new ComparerMin<IEnumerable<int>>(), SortOrder.Ascending},
            new object[] { 2, ArrayContainer.Instance.array2SortedSum, ArrayContainer.Instance.array2,
                new ComparerSum<IEnumerable<int>>(), SortOrder.Ascending},
            new object[] { 3, ArrayContainer.Instance.array2SortedMax, ArrayContainer.Instance.array2,
                new ComparerMax<IEnumerable<int>>(), SortOrder.Ascending},
            new object[] { 4, ArrayContainer.Instance.array3SortedSum, ArrayContainer.Instance.array3,
                new ComparerSum<IEnumerable<int>>(), SortOrder.Ascending}
        };
    }

    public class ComparerSum<T> : IComparer<T> where T : IEnumerable<int>
    {
        public int Compare(T x, T y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null && y != null)
                return -1;
            if (x != null && y == null)
                return 1;

            int sumX = 0, sumY = 0;
            foreach (int element in x)
            {
                sumX += element;
            }
            foreach (int element in y)
            {
                sumY += element;
            }
            if (sumX > sumY)
                return 1;
            if (sumX < sumY)
                return -1;
            return 0;
        }
    }

    public class ComparerMax<T> : IComparer<T> where T : IEnumerable<int>
    {
        public int Compare(T x, T y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null && y != null)
                return -1;
            if (x != null && y == null)
                return 1;

            int maxX = int.MinValue, maxY = int.MinValue;
            foreach (int element in x)
            {
                if (element > maxX)
                    maxX = element;
            }
            foreach (int element in y)
            {
                if (element > maxY)
                    maxY = element;
            }
            if (maxX > maxY)
                return 1;
            if (maxX < maxY)
                return -1;
            return 0;
        }
    }

    public class ComparerMin<T> : IComparer<T> where T : IEnumerable<int>
    {
        public int Compare(T x, T y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null && y != null)
                return -1;
            if (x != null && y == null)
                return 1;

            int minX = int.MaxValue, minY = int.MaxValue;
            foreach (int element in x)
            {
                if (element < minX)
                    minX = element;
            }
            foreach (int element in y)
            {
                if (element < minY)
                    minY = element;
            }
            if (minX > minY)
                return 1;
            if (minX < minY)
                return -1;
            return 0;
        }
    }

    public class ArrayContainer
    {
        static readonly private ArrayContainer instance = new ArrayContainer();

        static ArrayContainer()
        {

        }

        static public ArrayContainer Instance
        {
            get { return instance; }
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
