/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.  3, 5 -> 243 (3⁵);      2, 4 -> 16*/

System.Console.WriteLine("Введите два числа: ");
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());

double RaisesNaturalPow(double numA, double numB)
{
    double res = Math.Pow(numA, numB);
    return res;
}
double raisesNaturalPow = RaisesNaturalPow(a, b);
System.Console.WriteLine(raisesNaturalPow);
