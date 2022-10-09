// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double l = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2);
    double len = Math.Sqrt(l);
    return len;
}

Console.Clear();
Console.Write("Введите координаты Х точки А: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты Y точки А: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты Z точки А: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Введите кординаты Х точки В: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты Y точки В: ");
int by = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты Z точки B: ");
int bz = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Расстояние между точками {Dist(ax, ay, az, bx, by, bz):f2}");