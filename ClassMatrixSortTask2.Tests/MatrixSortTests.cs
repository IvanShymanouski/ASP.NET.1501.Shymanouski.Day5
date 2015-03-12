using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ClassMatrixSortTask2;

namespace ClassMatrixSortTask2.Tests
{
    [TestClass]
    public class MatrixSortTests
    {
        [TestMethod]
        public void MatrixSortSum()
        {
            const int xSize = 10;

            int[][] matrix = new int[xSize][];
            Random random = new Random();

            for (int i = 0; i < xSize; i++)
            {
                int ySize = random.Next(1, 11);
                matrix[i] = new int[ySize];
                for (int j = 0; j < ySize; j++)
                {
                    matrix[i][j] = random.Next(-1000, 1000);
                }
            }
            int[][] matrix1 = (Int32[][])matrix.Clone();

            Func<int[], int[], bool> comparer = (i, j) => i.Sum() < j.Sum();

            MatrixSort.Sort(matrix, comparer);

            Comparison<int[]> sysComparer = (i, j) =>
            {
                if (i.Sum() > j.Sum()) return 1;
                else if (i.Sum() < j.Sum()) return -1;
                else return 0;
            };

            Array.Sort<int[]>(matrix1, sysComparer);

            CollectionAssert.AreEqual(matrix, matrix1);

        }

        [TestMethod]
        public void MatrixSortAbs()
        {
            const int xSize = 10;

            int[][] matrix = new int[xSize][];
            Random random = new Random();

            for (int i = 0; i < xSize; i++)
            {
                int ySize = random.Next(1, 11);
                matrix[i] = new int[ySize];
                for (int j = 0; j < ySize; j++)
                {
                    matrix[i][j] = random.Next(-1000, 1000);
                }
            }
            int[][] matrix1 = (Int32[][])matrix.Clone();
            
            Func<int[], int[], bool> comparer = (i, j) => i.Max((k) => Math.Abs(k)) < j.Max((k) => Math.Abs(k));

            MatrixSort.Sort(matrix, comparer);

            Comparison<int[]> sysComparer = (i, j) =>
            {
                if (i.Max((k) => Math.Abs(k)) > j.Max((k) => Math.Abs(k))) return 1;
                else if (i.Max((k) => Math.Abs(k)) < j.Max((k) => Math.Abs(k))) return -1;
                else return 0;
            };

            Array.Sort<int[]>(matrix1, sysComparer);

            CollectionAssert.AreEqual(matrix, matrix1);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MatrixSortAbsOperationExeption()
        {
            const int xSize = 10;

            int[][] matrix = new int[xSize][];
            Random random = new Random();

            for (int i = 0; i < xSize; i++)
            {
                int ySize = random.Next(1, 11);
                if (i==4) continue;
                matrix[i] = new int[ySize];
                for (int j = 0; j < ySize; j++)
                {
                    matrix[i][j] = random.Next(-1000, 1000);
                }
            }

            Func<int[], int[], bool> comparer = (i, j) => i.Max((k) => Math.Abs(k)) < j.Max((k) => Math.Abs(k));

            MatrixSort.Sort(matrix, comparer);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MatrixSortAbsArgumentNullExeption()
        {
            int[][] matrix = null;

            Func<int[], int[], bool> comparer = (i, j) => i.Max((k) => Math.Abs(k)) < j.Max((k) => Math.Abs(k));

            MatrixSort.Sort(matrix, comparer);

        }
    }
}
