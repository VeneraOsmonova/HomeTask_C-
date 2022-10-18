/*Задача 10: Напишите программу, которая 
1.принимает на вход трёхзначное число и 
2.на выходе показывает вторую цифру этого числа. 456 -> 5; 782 -> 8; 918 -> 1*/

// Console.Write("Введиет треxзначное число: ");
// int digit = Convert.ToInt32(Console.ReadLine());
// int secondNum = digit / 10 % 10;
// Console.WriteLine($"Вторая цифра этого числа: {secondNum}");



Console.Write("Введите трехзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

int GetSecondNum(int digit)
{
    return digit / 10 % 10;
}

int result = GetSecondNum(digit);
Console.WriteLine($"Вторая цифра этого числа: {result}");
