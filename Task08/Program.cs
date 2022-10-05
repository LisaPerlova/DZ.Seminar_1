// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 2;
int counter = a;
while (counter <= number)
{
    Console.Write($"{counter} ");
    counter = counter + 2;
}