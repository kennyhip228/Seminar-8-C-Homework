// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] spiralMatrix(int[,] matrix)
{
    int number = 1;
    int row = 0;
    int column = 0;
    while (number <= 16)
    {
        for (int i = column; i < 4 - column; i++)
            matrix[row, i] = number++;

        for (int i = row + 1; i < 4 - row; i++)
            matrix[i, 4 - column - 1] = number++;

        for (int i = 4 - column - 2; i >= column; i--)
            matrix[4 - row - 1, i] = number++;

        for (int i = 4 - row - 2; i >= row + 1; i--)
            matrix[i, column] = number++;

        row++;
        column++;
    }
    return matrix;
}

int[,] matrix = new int[4, 4];
PrintMatrix(spiralMatrix(matrix));