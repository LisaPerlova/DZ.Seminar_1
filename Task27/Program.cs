// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int sum = 0;
    while (num > 0)
    {

        int diff = num % 10;
        sum = sum + diff;
        num = num / 10;

    }
    return sum;
}

int total = Sum(number);
Console.WriteLine($"Сумма цифр числа {number} = {total}");

