// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

string stringNumbers = ReadString("Введите числа через зяпятую: ");
int count = 0;
string tempStr = string.Empty;

for (int i = 0; i < stringNumbers.Length; i++)
{
    if (stringNumbers[i] != ',') tempStr += stringNumbers[i];
    else
    {
        if (Convert.ToInt32(tempStr) > 0) count++;
        tempStr = string.Empty;
    }
}
if (Convert.ToInt32(tempStr) > 0) count++;
Console.WriteLine($"Чисел больше 0 -> {count}");

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

