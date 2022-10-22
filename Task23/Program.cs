/*Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubesOfNumbers(int x)
{
    int count = 1;
    int result = 1;
    while (x >= count)
    {
        result = count * count * count;
        System.Console.WriteLine($" {count}^3 = {result}");
        //System.Console.WriteLine($" {count} | {result}");
        count++;
    }
}
CubesOfNumbers(number);