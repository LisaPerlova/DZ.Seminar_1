// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.

double[] CreateArrayRndDouble(int size, int min, int max)
{
var array = new double[size];
var rnd = new Random();

for (int i = 0; i < size; i++)
{
double rndNum = rnd.NextDouble() * (max - min) + min;
array[i] = Math.Round(rndNum, 2);
}
return array;
}

void PrintArrayDouble (double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write($"{array[i]}; ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

double FindMax (double[] array)
{
    int i = 0; 
    double maxPosition = array[0];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > maxPosition) maxPosition = array[i];
    }
    return maxPosition;
}

double FindMin (double[] array)
{
    int i = 0; 
    double minPosition = array[0];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < minPosition) minPosition = array[i];
    }
    return minPosition;
}

double[] arr1 = CreateArrayRndDouble(12, -99, 99);
PrintArrayDouble (arr1);
double findMax = FindMax (arr1);
Console.WriteLine($"Максимальное число массива = {findMax}");
double findMin = FindMin (arr1);
Console.WriteLine($"Минимальное число массива = {findMin}");