/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

//Метод для заполнения двумерного массива из целых чисел
int[,] FillArray(int[,] array, int min = 0, int max = 10)
{
    //Заполняем двумерный массив случайными значениями
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Random.Shared.Next(min, max + 1);
        }
    }
    return array;
}

//Вывод матрицы в консоль
void PrintArray(int[,] array, string text = "\nСгенерированный массив: \n")
{
    Console.WriteLine(text);
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Метод для произведения
int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Матрицы не перемножаются");
    }
    else
    {
        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    res[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return res;
}

Console.Clear();
int[,] array1 =
{
    {2, 4},
    {3, 2}
};
int[,] array2 =
{
    {3, 4},
    {3, 3}  
};

PrintArray(MultiplyMatrix(array1, array2), " ");