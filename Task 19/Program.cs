// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string Palindrome (int num)
{
    int num1 = num / 1000;
    int num2 = num % 100;
    int num3 = num2 / 10;
    int num4 = num2 % 10;
    num4 = num4 * 10;
    int sum = num3 + num4;
    if (num1 == sum) return ($"{number} -> Да");
    else return ($"{number} -> Нет");
}
string result = Palindrome (number);
Console.WriteLine(result);