// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] startArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Ввести колчество четных элементов в массиве = {GetEvenCount(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
    result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int GetEvenCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}
*/

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] startArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Ввести сумму нечетных элементов в массиве = {GetSumOdd(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
    result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int GetSumOdd (int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (i %2 !=0) sum += array[i];
}
return sum;
}
*/

//Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
int[] startArray = GetArray(3, 7, 22);
Console.WriteLine($"[{String.Join(" ", startArray)}]");
Console.WriteLine($"Ввести разницу макс и мин элементов массива = {GetDifference(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
    result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int GetDifference(int[]array)
{
    int min = array[0];
    int max = array[0];
    foreach (var item in array){
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}
*/