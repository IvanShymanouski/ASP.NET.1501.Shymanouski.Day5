using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMatrixSortTask2
{
    public class MatrixSort
    {
        /// <summary>
        /// Sort strings of matrix by custom function and custom selector
        /// </summary>
        /// <param name="array"></param>
        /// <param name="comparer">
        ///  set the rule of following for near lines
        ///  <example>for exemple: (i, j) => i.Max() > j.Max()</example>
        /// </param>
        public static void Sort(int[][] array, Func<int[], int[], bool> comparer)
        {
            int[] index;

            //Initialization
            try
            {
                index = new int[array.Length];
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("", ex);
            }
            for (int i = 0; i < array.Length; i++)
            {
                index[i] = i;
            }
            try
            {
                Qsort(array, 0, array.Length - 1, comparer, index);
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException("", ex);
            }
            RearrangementOfArrayByIndex(array, index);
        }

        private static void Qsort(int[][] array, int left, int right, Func<int[], int[], bool> comparer, int[] index)
        {
            int i = left;
            int j = right;
            int[] medium = array[index[(left + right) / 2]];

            while (i <= j)
            {
                while (comparer(array[index[i]], medium)) i++;
                while (comparer(medium, array[index[j]])) j--;
                if (i <= j)
                {
                    Swap(ref index[i], ref index[j]);
                    i++; j--;
                }
            }

            if (left < j) Qsort(array, left, j, comparer, index);
            if (i < right) Qsort(array, i, right, comparer, index);

        }

        private static void Swap(ref int a1, ref int a2)
        {
            int temp = a1;
            a1 = a2;
            a2 = temp;
        }

        private static void RearrangementOfArrayByIndex(int[][] array, int[] index)
        {
            int[][] newArray = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[index[i]];
            }
            Array.Copy(newArray, array, array.Length);
        }
    }
}
