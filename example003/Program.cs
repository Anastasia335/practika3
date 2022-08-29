// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int x1, y1, z1, x2, y2, z2;
// Console.WriteLine("ВВедите координаты по порядку x1, y1, z1, x2, y2, z2 ");
// x1 = Convert.ToInt32(Console.ReadLine());
// y1 = Convert.ToInt32(Console.ReadLine());
// z1 = Convert.ToInt32(Console.ReadLine());
// x2 = Convert.ToInt32(Console.ReadLine());
// y2 = Convert.ToInt32(Console.ReadLine());
// z2 = Convert.ToInt32(Console.ReadLine());

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coor, string tochka)
{
    Console.Write($"Введите координату {coor} точки {tochka}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double rast = Math.Round((Rasstoyanie(x1, y1, z1, x2, y2, z2)),2);
Console.WriteLine($"Длина отрезка  {rast}");

double Rasstoyanie (double arg1,
                    double arg2,
                    double arg3,
                    double arg4,
                    double arg5,
                    double arg6)
{
return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}