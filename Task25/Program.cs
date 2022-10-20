// Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 <= 0) Console.WriteLine($"{number2} не натуральное число!");
else Power(number1, number2);
void Power (int num1, int num2)
{
    int count = 2;
    int n1 = num1;
    while (count <= num2)
    {
        num1 = num1 * n1;
        count++;
    }
    Console.WriteLine($"{number1} в степени {number2} = {num1}");
}







