/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите первое натуральное число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int SummOfNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    return num1 + SummOfNaturalNumbers(num1 + 1, num2);
}

int result = default;
if(firstNum > secondNum) 
{
    result = SummOfNaturalNumbers(firstNum, secondNum);
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {firstNum} до {secondNum} = {result}");
}
else 
{
    result = SummOfNaturalNumbers(firstNum, secondNum);
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {firstNum} до {secondNum} = {result}");
}
