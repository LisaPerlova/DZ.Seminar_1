// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= num)
{
    Console.WriteLine(Cube(count));
    count++;
}
string Cube (int number)
{
    return ($"{number} | {number * number * number}");
}
