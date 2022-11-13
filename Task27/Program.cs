/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11;    82 -> 10;    9012 -> 12 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int digNum)
{
    int summa = 0;
    int digit = 0;
    while (digNum > 0)
    {
        digit = digNum % 10;
        digNum = digNum / 10;
        summa += digit;
    }
    return summa;
}

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);
