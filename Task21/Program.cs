// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Range (int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double diffX = Math.Pow((xc2 - xc1), 2);
    double diffY = Math.Pow((yc2 - yc1), 2);
    double diffZ = Math.Pow((zc2 - zc1), 2);
    double sumXYZ = diffX + diffY + diffZ;
    double rangeXYZ = Math.Sqrt(sumXYZ);
    return Math.Round(rangeXYZ, 2, MidpointRounding.ToZero);
}
double result = Range (x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);