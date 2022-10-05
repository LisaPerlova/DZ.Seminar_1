// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2)
{
    Console.WriteLine($"{number}");
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");