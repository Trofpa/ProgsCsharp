/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/


int[] GenRandArray()
{
    int size = Random.Shared.Next(1, 21);
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(1, 1000);
    }

    return array;
}

void ShowEven(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0) count += 1;
    }
    Console.WriteLine($"[{string.Join(", ", array)}] -> {count}");
}


ShowEven(GenRandArray());

