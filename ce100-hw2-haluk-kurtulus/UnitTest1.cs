using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw2_haluk_kurtulus;

namespace ce100_hw2_haluk_kurtulus_test
{
    
    [TestClass]
    public class HeapSortTests
    {
        [TestMethod]
        public void TestHeapSort()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int[] expected = { 5, 6, 7, 11, 12, 13 };
            HeapSort ob = new HeapSort();
            ob.sort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestHeapSortWithEmptyArray()
        {
            int[] arr = { };
            int[] expected = { };
            HeapSort ob = new HeapSort();
            ob.sort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestHeapSortWithSingleElementArray()
        {
            int[] arr = { 1 };
            int[] expected = { 1 };
            HeapSort ob = new HeapSort();
            ob.sort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestHeapSortWithSortedArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            HeapSort ob = new HeapSort();
            ob.sort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestHeapSortWithReverseSortedArray()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };
            HeapSort ob = new HeapSort();
            ob.sort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestHeapSortWithDuplicateElements()
        {
            int[] arr = { 1, 2, 3, 3, 2, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 3 };
            HeapSort ob = new HeapSort();
            ob.sort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestHeapSortWithLargeArray()
        {
            int N = 1000;
            int[] arr = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            int[] expected = new int[N];
            Array.Copy(arr, expected, N);
            Array.Sort(expected);
            HeapSort ob = new HeapSort();
            ob.sort(arr);
            CollectionAssert.AreEqual(expected, arr);
        }
    }
}

[TestClass]
    public class MatrixChainOrderTests
    {
        [TestMethod]
        public void MatrixChainOrder_Test()
        {
            // Arrange
            int[] arr = new int[] { 1, 2, 3, 4, 3 };
            int expectedMin = 30;

            // Act
            int actualMin = GFG.MatrixChainOrder(arr, 1, arr.Length - 1);

            // Assert
            Assert.AreEqual(expectedMin, actualMin);
        }
    }
    [TestClass]
    public class MatrixChainMultiplicationTests
    {
        [TestMethod]
        public void TestMatrixChainMultiplication()
        {
            int[] arr = { 1, 2, 3, 4 };
            int n = arr.Length;

            int[,] dp = new int[100, 100];

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    dp[i, j] = -1;
                }
            }

            int expected = 18; // Expected minimum number of multiplications for the given input array
            int actual = GFG3.MatrixChainOrder(arr, n, dp);

            Assert.AreEqual(expected, actual, "Matrix chain multiplication result is not as expected.");
        }
    }
    [TestClass]
    public class LCSUnitTest
    {
        [TestMethod]
        public void TestLCS()
        {
            // Arrange
            string s1 = "AGGTAB";
            string s2 = "GXTXAYB";
            char[] X = s1.ToCharArray();
            char[] Y = s2.ToCharArray();
            int m = X.Length;
            int n = Y.Length;
            int[,] L = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    L[i, j] = -1;
                }
            }

            // Act
            int result = LCS.lcs(X, Y, m, n, L);

            // Assert
            Assert.AreEqual(4, result);
        }
    }
    [TestClass]
    public class KNAPSACKTests
    {
        [TestMethod]
        public void TestKnapSack()
        {
            // Arrange
            int[] profit = new int[] { 60, 100, 120 };
            int[] weight = new int[] { 10, 20, 30 };
            int W = 50;
            int expected = 220; // expected maximum profit

            // Act
            int actual = KNAPSACK.knapSack(W, weight, profit, profit.Length);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

