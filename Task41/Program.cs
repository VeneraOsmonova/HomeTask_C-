/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите количество чисел для ввода: ");
int amountNumbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите числа, количество которых => {amountNumbers}");

int[] CreateArrayInt(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int AmountOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] arr = CreateArrayInt(amountNumbers);
int amountOfNumbers = AmountOfNumbers(arr);
Console.WriteLine($"Количество чисел больше 0 => {amountOfNumbers}");
