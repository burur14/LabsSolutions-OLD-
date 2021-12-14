using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num of rows");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num of cols");
            int m = Convert.ToInt32(Console.ReadLine());

            double[,] matrixC = fillMatrix(n, m);
            double[,] matrixB = fillMatrix(n, m);

            Console.WriteLine("\nMatrix C: ");
            printMatrix(matrixC);
            int kMax = getIndexOfColWithMaxElement(matrixC);


            Console.WriteLine("\nMatrix B: ");
            printMatrix(matrixB);       
            int kMin = getIndexOfColWithMinElement(matrixB);

            double[] maxColOfC = getCol(matrixC, kMax);
            Console.WriteLine("\nmax col of C: ");
            printArr(maxColOfC);

            double[] minColofB = getCol(matrixB, kMin);
            Console.WriteLine("\nmin col of B: ");
            printArr(minColofB);

            
            double[,] matrixY = replaceCol(matrixC, minColofB, kMin);
            Console.WriteLine("\nMatrix Y(matrix C with col of B): ");
            printMatrix(matrixY);


            double[,] matrixZ = replaceCol(matrixB, maxColOfC, kMax);
            Console.WriteLine("\nMatrix Z(matrix B with col of C): ");
            printMatrix(matrixZ);
        }


        static double[,] fillMatrix(int n, int m)
        {
            var rand = new Random();
            double[,] matrix = new double[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    
                    matrix[i, j] = Math.Round(rand.NextDouble() * 10, 2);
                }
            }

            return matrix;
        }

        static void printMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        static int getIndexOfColWithMaxElement(double[,] matrix)
        {
            int k = 0;
            double max = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        k = j;
                    }
                }
            }

            Console.WriteLine("Col index with max elem: " + k);
            return k;
        }

        static int getIndexOfColWithMinElement(double[,] matrix)
        {
            int k = 0;
            double min = matrix[0,0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        k = j;
                    }
                }
            }

            Console.WriteLine("Col index with min elem: " + k);
            return k;
        }

        static double[] getCol(double[,] matrix, int k)
        {
            double[] arr = new double[matrix.GetLength(0)];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                arr[i] = matrix[i, k];
            }

            return arr;
        }

        static void printArr(double[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static double[,] replaceCol(double[,] matrix, double[] arr, int k)
        {
            double[,] result = matrix;

            for(int i = 0; i < arr.Length; i++)
            {
                result[i, k] = arr[i];
            }

            return result;
        }
    }
}
