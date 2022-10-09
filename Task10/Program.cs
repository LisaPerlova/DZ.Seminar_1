// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// Первое решение:

// Console.WriteLine("Введите трехзначное число: "); 
// int number = Convert.ToInt32(Console.ReadLine());
//if (number > 99 && number < 1000)
// {
//     int num1 = number / 10;
//     int num2 = num1 % 10;
//     Console.WriteLine($"Вторая цифра числа: {num2}");
// }
// else Console.WriteLine("Это не трехзначное число");

// Второе решение:

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SecondNumber(int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}
if (number > 99 && number < 1000)
{
    int result = SecondNumber(number);
    Console.WriteLine($"Вторая цифра числа: {result}");
}
else Console.WriteLine("Это не трехзначное число");