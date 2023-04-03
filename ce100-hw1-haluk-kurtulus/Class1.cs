using System;


namespace ce100_hw2_haluk_kurtulus

{
    // C# program for implementation of Heap Sort
    using System;

    public class HeapSort
    {
        public void sort(int[] arr)
        {
            int N = arr.Length;

            // Build heap (rearrange array)
            for (int i = N / 2 - 1; i >= 0; i--)
                heapify(arr, N, i);

            // One by one extract an element from heap
            for (int i = N - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is
        // an index in arr[]. n is size of heap
        void heapify(int[] arr, int N, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < N && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < N && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                heapify(arr, N, largest);
            }
        }

        /* A utility function to print array of size n */
        static void printArray(int[] arr)
        {
            int N = arr.Length;
            for (int i = 0; i < N; ++i)
                Console.Write(arr[i] + " ");
            Console.Read();
        }

        // Driver's code
        public static void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int N = arr.Length;

            // Function call
            HeapSort ob = new HeapSort();
            ob.sort(arr);

            Console.WriteLine("Sorted array is");
            printArray(arr);
        }
    }





    public class GFG
    {

        // Matrix Ai has dimension p[i-1] x p[i]
        // for i = 1..n
       public static int MatrixChainOrder(int[] p, int i, int j)
        {

            if (i == j)
                return 0;

            int min = int.MaxValue;

            // Place parenthesis at different places
            // between first and last matrix,
            // recursively calculate count of multiplications
            // for each parenthesis placement
            // and return the minimum count
            for (int k = i; k < j; k++)
            {
                int count = MatrixChainOrder(p, i, k)
                            + MatrixChainOrder(p, k + 1, j)
                            + p[i - 1] * p[k] * p[j];

                if (count < min)
                    min = count;
            }

            // Return minimum count
            return min;
        }

        // Driver code
        public static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 3 };
            int N = arr.Length;

            // Function call
            Console.Write(
                "Minimum number of multiplications is "
                + MatrixChainOrder(arr, 1, N - 1));
        }
    }

    // Dynamic Programming C# implementation of
    // Matrix Chain Multiplication.
    // See the Cormen book for details of the
    // following algorithm


    public class GFG2
    {

        // Matrix Ai has dimension p[i-1] x p[i]
        // for i = 1..n
       public static int MatrixChainOrder(int[] p, int n)
        {

            /* For simplicity of the program, one
            extra row and one extra column are
            allocated in m[][]. 0th row and 0th
            column of m[][] are not used */
            int[,] m = new int[n, n];

            int i, j, k, L, q;

            /* m[i, j] = Minimum number of scalar
            multiplications needed
            to compute the matrix A[i]A[i+1]...A[j]
            = A[i..j] where dimension of A[i] is
            p[i-1] x p[i] */

            // cost is zero when multiplying
            // one matrix.
            for (i = 1; i < n; i++)
                m[i, i] = 0;

            // L is chain length.
            for (L = 2; L < n; L++)
            {
                for (i = 1; i < n - L + 1; i++)
                {
                    j = i + L - 1;
                    if (j == n)
                        continue;
                    m[i, j] = int.MaxValue;
                    for (k = i; k <= j - 1; k++)
                    {
                        // q = cost/scalar multiplications
                        q = m[i, k] + m[k + 1, j]
                            + p[i - 1] * p[k] * p[j];
                        if (q < m[i, j])
                            m[i, j] = q;
                    }
                }
            }

            return m[1, n - 1];
        }

       
    }
    // C# program using memoization

    public class GFG3
    {

        public static int[,] dp = new int[100, 100];

        // Function for matrix chain multiplication
        static int matrixChainMemoised(int[] p, int i, int j)
        {
            if (i == j)
            {
                return 0;
            }
            if (dp[i, j] != -1)
            {
                return dp[i, j];
            }
            dp[i, j] = Int32.MaxValue;
            for (int k = i; k < j; k++)
            {
                dp[i, j] = Math.Min(
                  dp[i, j], matrixChainMemoised(p, i, k)
                  + matrixChainMemoised(p, k + 1, j)
                  + p[i - 1] * p[k] * p[j]);
            }
            return dp[i, j];
        }

       public static int MatrixChainOrder(int[] p, int n)
        {
            int i = 1, j = n - 1;
            return matrixChainMemoised(p, i, j);
        }

       
    }
    public class LCS
    {


        /* Returns length of LCS for X[0..m-1], Y[0..n-1] */
       public static int lcs(char[] X, char[] Y, int m, int n, int[,] L)
        {
            if (m == 0 || n == 0)
                return 0;

            if (L[m, n] != -1)
                return L[m, n];

            if (X[m - 1] == Y[n - 1])
            {
                L[m, n] = 1 + lcs(X, Y, m - 1, n - 1, L);
                return L[m, n];
            }

            L[m, n] = max(lcs(X, Y, m, n - 1, L), lcs(X, Y, m - 1, n, L));
            return L[m, n];
        }

        /* Utility function to get max of 2 integers */
        public static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public static void Main()
        {
            String s1 = "AGGTAB";
            String s2 = "GXTXAYB";

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
            Console.Write("Length of LCS is" + " "
                + lcs(X, Y, m, n, L));
        }
    }
    /* A Naive recursive implementation of
0-1 Knapsack problem */


    public static class KNAPSACK
    {

        // A utility function that returns
        // maximum of two integers
        static int max(int a, int b) { return (a > b) ? a : b; }

        // Returns the maximum value that can
        // be put in a knapsack of capacity W
       public static int knapSack(int W, int[] wt, int[] val, int n)
        {

            // Base Case
            if (n == 0 || W == 0)
                return 0;

            // If weight of the nth item is
            // more than Knapsack capacity W,
            // then this item cannot be
            // included in the optimal solution
            if (wt[n - 1] > W)
                return knapSack(W, wt, val, n - 1);

            // Return the maximum of two cases:
            // (1) nth item included
            // (2) not included
            else
                return max(val[n - 1]
                               + knapSack(W - wt[n - 1], wt,
                                          val, n - 1),
                           knapSack(W, wt, val, n - 1));
        }

      
    }

}