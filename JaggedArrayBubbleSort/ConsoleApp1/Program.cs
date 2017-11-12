using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[][] array1 = new int[5][];
            int[][] array1SortedSum = new int[5][];
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
            Console.WriteLine(array1.ToStr() + '\n');
            ArrayOfArraySort.Sort(array1);
            Console.WriteLine(array1.ToStr() + '\n');
            Console.WriteLine(array1SortedSum.ToStr());
            Console.ReadLine();
        }

        static string ToStr(this int[][] array)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('{');
            builder.Append('\n');
            foreach (int[] element in array)
            {
                builder.Append(element.ToStr());
                builder.Append('\n');
            }
            builder.Append('}');
            return builder.ToString();
        }

        static string ToStr(this int[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (int element in array)
            {
                builder.Append(element.ToString());
                builder.Append(", ");
            }
            return builder.ToString();
        }
    }
}
