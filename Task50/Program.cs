// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите число 1: ");
int returnNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int returnNumber2 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void ReturnElement(int[,] matrix, int a, int b)
{

    if (a > matrix.GetLength(1) && b > matrix.GetLength(0))
    {
        Console.Write($"{a}, {b} -> Такого элемента в массиве нет");
    }
    else Console.Write($"{matrix[a, b]}");
}

int[,] array2D = CreateMatrixRndInt(4, 6, -10, 10);
PrintMatrix(array2D);
ReturnElement(array2D, returnNumber1, returnNumber2);