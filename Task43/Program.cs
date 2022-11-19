/*Задача 43. Напишите программу, 
1. которая найдёт точку пересечения двух прямых,
2. заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;

значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5*/

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] FindPointXY(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}

double[] findPointXY = FindPointXY(b1, k1, b2, k2);
Console.WriteLine($"Точки пересечения двух прямых x и y => ({findPointXY[0]}, {findPointXY[1]})");
