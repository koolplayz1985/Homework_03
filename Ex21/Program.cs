//Задача 21:
//Напишите программу, которая принимает на вход координаты двух точек и находит
//расстояние между ними в 2D пространстве.
//A (0,0); B (1,1), -> ~1.4
//A (2,4); B (0,7) -> ~3.6

Console.Clear();
Console.WriteLine("Введите координату x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double GetDistance(int ax, int ay, int bx, int by)
{
    return Math.Round(Math.Sqrt(((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay))), 2, MidpointRounding.ToZero);
}
double result = GetDistance(x1, y1, x2, y2);
Console.WriteLine(result);