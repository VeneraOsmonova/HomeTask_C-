
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мaксимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write("; ");
    }
    Console.WriteLine("]");
}

double DifferenceMinMaxValue(double[] array)
{
    double differenceValue = 0;
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minValue > array[i]) minValue = array[i];
        if (maxValue < array[i]) maxValue = array[i];
        differenceValue = maxValue - minValue;
    }
    return Math.Round(differenceValue, 1);
}

double[] arr = CreateArrayRndDouble(size, min, max);
Console.WriteLine($"Ваш массив из {size} элементов: ");
PrintArray(arr);
double differenceMinMaxValue = DifferenceMinMaxValue(arr);
Console.WriteLine($"Разницу между max и min элементом массива = {differenceMinMaxValue} ");