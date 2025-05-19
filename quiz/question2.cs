using System;

class question2
{
    static void Main(string[] args)
    {
        int[,] matrix = {
            {9,1,8},
            {2,3,7},
            {6,5,4}
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        SortMatrix(matrix);
        Console.WriteLine("\nSorted Matrix:");
        PrintMatrix(matrix);

        SwapDiagonals(matrix);
        Console.WriteLine("\nAfter Swapping Diagonals:");
        PrintMatrix(matrix);

        Console.ReadKey();
    }

    static void SortMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] temp = new int[rows * cols];
        int index = 0;

        // Flatten
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                temp[index++] = matrix[i, j];

        // Sort
        Array.Sort(temp);

        // Fill back
        index = 0;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = temp[index++];
    }

    static void SwapDiagonals(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            int temp = matrix[i, i];
            matrix[i, i] = matrix[i, size - 1 - i];
            matrix[i, size - 1 - i] = temp;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }
}

