using System;

namespace MatrixAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the square matrix (less than 5): ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[size, size];
            int[,] matrix2 = new int[size, size];
            int[,] sumMatrix = new int[size, size];

            Console.WriteLine("Input elements in the first matrix:");
            InputMatrixElements(matrix1);

            Console.WriteLine("Input elements in the second matrix:");
            InputMatrixElements(matrix2);

            Console.WriteLine("The First matrix is:");
            PrintMatrix(matrix1);

            Console.WriteLine("The Second matrix is:");
            PrintMatrix(matrix2);

            // Perform addition of matrices
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("The Addition of two matrices is:");
            PrintMatrix(sumMatrix);

            string input2 = Console.ReadLine();
            string input3= Console.ReadLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void InputMatrixElements(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
