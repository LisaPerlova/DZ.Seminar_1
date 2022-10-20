// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] FillArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 99);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length;)
    {
        Console.WriteLine("[{0}]", string.Join(", ", arr));
        break;
    } 
}
int[] myArr = FillArray(8);
PrintArray(myArr);
