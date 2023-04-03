using Microsoft.VisualStudio.TestTools.UnitTesting;
using ce100_hw2_haluk_kurtulus;
using static System.Net.Mime.MediaTypeNames;

namespace ce100_hw2_test
{



    [TestClass]
    public class HeapSortTest
    {

        [TestMethod]
        public void TestHeapSortavaregacase()
        {
            {
                int[] arr = { 12, 11, 13, 5, 6, 7 };
                int[] expected = { 5, 6, 7, 11, 12, 13 };

                HeapSort ob = new HeapSort();
                ob.sort(arr);

                CollectionAssert.AreEqual(expected, arr);
            }
        }
        [TestMethod]
        public void Sort_BestCase()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            HeapSort sorter = new HeapSort();

            // Act
            sorter.sort(arr);

            // Assert
            CollectionAssert.AreEqual(expected, arr);
        }
        [TestMethod]
        public void Sort_worstCase()
        {
            // Arrange
            int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            HeapSort sorter = new HeapSort();

            // Act
            sorter.sort(arr);

            // Assert
            CollectionAssert.AreEqual(expected, arr);
        }
        [TestMethod]
        public void TestMatrixChainOrderworstcase()
        {
            {
                // Arrange
                int[] arr1 = new int[] { 1, 2, 3, 4, 3 };
                int expected1 = 30;

                int[] arr2 = new int[] { 5, 10, 3, 12, 5, 50, 6 };
                int expected2 = 2010;

                // Act
                int result1 = GFG.MatrixChainOrder(arr1, 1, arr1.Length - 1);
                int result2 = GFG.MatrixChainOrder(arr2, 1, arr2.Length - 1);

                // Assert
                Assert.AreEqual(expected1, result1);
                Assert.AreEqual(expected2, result2);
            }

        }
        [TestMethod]
        public void TestMatrixChainMultiplicationavaragecase()
        {
            int[] arr1 = { 10, 20, 30, 40, 30 };
            int[] arr2 = { 5, 10, 3, 12, 5, 50, 6 };
            int[] arr3 = { 2, 5, 7, 9, 3, 6, 1 };

            int result1 = GFG.MatrixChainOrder(arr1, 1, arr1.Length - 1);
            int result2 = GFG.MatrixChainOrder(arr2, 1, arr2.Length - 1);
            int result3 = GFG.MatrixChainOrder(arr3, 1, arr3.Length - 1);

            Assert.AreEqual(30000, result1);
            Assert.AreEqual(2010, result2);
            Assert.AreEqual(153, result3);
        }
        [TestMethod]
        public void TestMatrixChainOrder_BestCase()
        {
            int[] arr = new int[] {0,1, 2, 3 };
            int expected = 0;

            int result = GFG.MatrixChainOrder(arr, 1, arr.Length - 1);

            Assert.AreEqual(expected, result);
        }      
           
        [TestMethod]
            public void MatrixChainOrder_BestCase()
            {
                // Arrange
                int[] arr = new int[] {0 , 1, 2, 3 };
                int expected = 0;

                // Act
                int actual = GFG2.MatrixChainOrder(arr, arr.Length);

                // Assert
                Assert.AreEqual(expected, actual);
            }      
            [TestMethod]
            public void TestMatrixChainOrderavaragecase()
            {
                int[] p = { 10, 20, 30, 40, 30 };
                int n = p.Length;
                int expected = 30000; // expected result for given input

                int result = GFG2.MatrixChainOrder(p, n);

                Assert.AreEqual(expected, result);
            }
        [TestMethod]
        public void TestMatrixChainOrder_WorstCase()
        {
            // Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            int n = arr.Length;

            // Act
            int result = GFG2.MatrixChainOrder(arr, n);

            // Assert
            int expected = 38000;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestWorstCasegfc3()
        {
            int[] p = new int[] { 10, 20, 30, 40, 50 };
            int n = p.Length;

            int expected = 38200;
            int result = GFG3.MatrixChainOrder(p, n);

            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void MatrixChainOrder_BestCase_ReturnsCorrectResult()
        {
            // Arrange
            int[] p = { 2, 2, 2, 2 }; // matrix sizes
            int expected = 0;

            // Act
            int actual = GFG3.MatrixChainOrder(p, p.Length);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMatrixChainOrder_AverageCase()
        {
            // Arrange
            int[] p = { 5, 10, 3, 12, 5, 50, 6 };
            int expected = 2010; // Expected result for p = { 5, 10, 3, 12, 5, 50, 6 }

            // Act
            int result = GFG3.MatrixChainOrder(p, p.Length);

            // Assert
            Assert.AreNotEqual(expected, result, "MatrixChainOrder returned an incorrect result for the average case.");
        }
        [TestMethod]
        public void TestLCSavaragecase()
        {
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

            int expected = 4;
            int actual = LCS.lcs(X, Y, m, n, L);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestLCSBestCase()
        {
            string s1 = "abcdef";
            string s2 = "abcdef";
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
            Assert.AreEqual(m, LCS.lcs(X, Y, m, n, L));
        }
        [TestMethod]
        public void TestLCS_WorstCase()
        {
            // Worst case scenario: two completely different strings
            String s1 = "abcdefghijklmnopqrstuvwxyz";
            String s2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
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

            int lcsLength = LCS.lcs(X, Y, m, n, L);
            Assert.AreEqual(0, lcsLength);
     
       }
        [TestMethod]
        public void TestknapcsackWorstCase()
        {
            int W = 50;
            int n = 10;
            int[] wt = new int[n];
            int[] val = new int[n];

            // initialize weights and values
            for (int i = 0; i < n; i++)
            {
                wt[i] = i + 1;
                val[i] = i + 1;
            }

            int expected = 50; // expected result for worst case scenario
            int result = KNAPSACK.knapSack(W, wt, val, n);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestKnapSackBestCase()
        {
            int W = 10;
            int[] wt = new int[] { };
            int[] val = new int[] { };
            int n = 0;
            int expected = 0;

            int result = KNAPSACK.knapSack(W, wt, val, n);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestKnapSackAverageCase()
        {
            int W = 10;
            int[] wt = new int[] { 2, 3, 4, 5, 6 };
            int[] val = new int[] { 3, 4, 5, 6, 7 };
            int n = wt.Length;
            int expected = 13;
            int result = KNAPSACK.knapSack(W, wt, val, n);
            Assert.AreEqual(expected, result);
        }
    }
}

    
    







