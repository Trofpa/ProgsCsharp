/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

double[] GenRandArray()
{
    var rand = new Random();
    int size = Random.Shared.Next(1, 4);
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 10, 3);  
    
    }
    return array;
}

double GetDiff(double[] array)
{
    return array.Max() - array.Min();
}

double[] array = GenRandArray();

Console.WriteLine($"[{string.Join(", ", array)}] -> {Math.Round(GetDiff(array), 3)}");