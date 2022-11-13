/*Задача 4: Напишите программу, которая 
1. принимает на вход три числа
2. выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

System.Console.WriteLine("Введите три числа: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double max = a;
while (max < b || max < c)
{
   if (max < b)
   {
    max = b;
   } 
   else if (max < c)
   {
    max = c;
   }
}
System.Console.WriteLine($"Максимальное число = {max}");

