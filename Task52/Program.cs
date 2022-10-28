// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
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

void MeanMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double mean = 0;
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            mean = sum / matrix.GetLength(0);
            mean = Math.Round(mean, 1);
        }
        Console.Write($"{mean}; ");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
// double meanMatrix = MeanMatrix(resMean);
// PrintMatrix(meanMatrix);
MeanMatrix(array2D);
