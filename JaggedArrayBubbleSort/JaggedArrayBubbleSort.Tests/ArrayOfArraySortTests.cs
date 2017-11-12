using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day5.Tests
{
    public class ArrayOfArraySortTests
    {
        private static object[] testCases =
                {
            new object[] 
            {
                0, ArrayContainer.Instance.array1SortedSum, ArrayContainer.Instance.array1,
                new Comparer(ComparerSum), SortOrder.Straight
            },
            new object[] 
            {
                1, ArrayContainer.Instance.array1SortedMin, ArrayContainer.Instance.array1,
                new Comparer(ComparerMin), SortOrder.Straight
            },
            new object[] 
            {
                2, ArrayContainer.Instance.array2SortedSum, ArrayContainer.Instance.array2,
                new Comparer(ComparerSum), SortOrder.Straight
            },
            new object[] 
            {
                3, ArrayContainer.Instance.array2SortedMax, ArrayContainer.Instance.array2,
                new Comparer(ComparerMax), SortOrder.Straight
            },
            new object[]
            {
                4, ArrayContainer.Instance.array3SortedSum, ArrayContainer.Instance.array3,
                new Comparer(ComparerSum), SortOrder.Straight
            }
        };

        [Test, TestCaseSource("testCases")]
        public static void SortTest(
            int testNum,
            int[][] array1,
            int[][] array2,
            Comparer comparer,
            SortOrder order)
        {
            ArrayOfArraySort.Sort(array2, comparer, order);
            Assert.AreEqual(array1, array2);
        }

        public static int ComparerSum(int[] x, int[] y)
        {
            if (x == null && y == null)
            {
                return 0;
            }

            if (x == null && y != null)
            {
                return -1;
            }

            if (x != null && y == null)
            {
                return 1;
            }

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
            {
                return 1;
            }

            if (sumX < sumY)
            {
                return -1;
            }

            return 0;
        }

        public static int ComparerMax(int[] x, int[] y)
        {
            if (x == null && y == null)
            {
                return 0;
            }

            if (x == null && y != null)
            {
                return -1;
            }

            if (x != null && y == null)
            {
                return 1;
            }

            int maxX = int.MinValue, maxY = int.MinValue;
            foreach (int element in x)
            {
                if (element > maxX)
                {
                    maxX = element;
                }
            }

            foreach (int element in y)
            {
                if (element > maxY)
                {
                    maxY = element;
                }
            }

            if (maxX > maxY)
            {
                return 1;
            }

            if (maxX < maxY)
            {
                return -1;
            }

            return 0;
        }

        public static int ComparerMin(int[] x, int[] y)
        {
            if (x == null && y == null)
            {
                return 0;
            }

            if (x == null && y != null)
            {
                return -1;
            }

            if (x != null && y == null)
            {
                return 1;
            }

            int minX = int.MaxValue, minY = int.MaxValue;
            foreach (int element in x)
            {
                if (element < minX)
                {
                    minX = element;
                }
            }

            foreach (int element in y)
            {
                if (element < minY)
                {
                    minY = element;
                }
            }

            if (minX > minY)
            {
                return 1;
            }

            if (minX < minY)
            {
                return -1;
            }

            return 0;
        }
    }
}
