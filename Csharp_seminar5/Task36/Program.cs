/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

// See https://aka.ms/new-console-template for more information

int[] GenRandArray()
{
    int size = Random.Shared.Next(1, 21);
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(1, 50);  
    }
    return array;
}

int GetSum(int[] array)
{
    int res = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        res += array[i];
    }
    return res;
}
int[] array = GenRandArray();
Console.WriteLine($"[{string.Join(", ", array)}] -> {GetSum(array)}");