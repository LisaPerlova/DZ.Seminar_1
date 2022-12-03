// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());

void SumNumbers(int num1, int num2, int sum)
{
    sum = sum + num2;
    if (num2 <= num1)
    {
        Console.Write($" {sum} ");
        return;
    }
    SumNumbers(num1, num2 - 1, sum);

    int temp = num1;
    if (num1 > num2)
    {
        num1 = num2;
        num2 = temp;
    }
}
Console.Write($"M = {number1}, N = {number2} -> ");
SumNumbers(number1, number2, 0);