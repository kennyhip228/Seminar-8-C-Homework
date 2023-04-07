// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(-10, 10);
    }
}

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

int [,] FindProductOfNumbers(int[,] firstMatrix, int[,] secondMatrix)
{
    int [,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
    return result;
}


Console.Write("Введите размер первой матрицы: ");
int[] firstSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] firstMatrix = new int[firstSize[0], firstSize[1]];
Console.Write("Введите размер второй матрицы: ");
int[] secondSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] secondMatrix = new int[secondSize[0], secondSize[1]];

while (firstSize[1] != secondSize[0])
{
    Console.WriteLine("Вы ввели неверные значения");
    Console.Write("Введите размер первой матрицы: ");
    firstSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    firstMatrix = new int[firstSize[0], firstSize[1]];
    Console.Write("Введите размер второй матрицы: ");
    secondSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    secondMatrix = new int[secondSize[0], secondSize[1]];
}

InputMatrix(firstMatrix);
PrintMatrix(firstMatrix);
InputMatrix(secondMatrix);
PrintMatrix(secondMatrix);
int [,] resultOfMatrix = FindProductOfNumbers(firstMatrix, secondMatrix);
PrintMatrix(resultOfMatrix);