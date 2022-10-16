/*Условие задачи

55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Можно группой, или один демонстрацию экрана делает - остальные помогают

*/


//Метод для генерации двумерного массива из целых чисел
//*Замечание - Одна функция на метод*
int[,] GenArray(int Nrows, int Mcolumns, int Erange)
{
    //Заполняем двумерный массив случайными значениями
    int[,] result = new int[Nrows, Mcolumns];
    for (int i = 0; i < Nrows; i++)
    {
        for (int j = 0; j < Mcolumns; j++)
        {
            result[i, j] = new Random().Next(0, Erange + 1);
        }
    }

    //Отображение сгенерированного двумерного массива
    Console.WriteLine("\nСгенерированный массив: \n");
    for (int i = 0; i < Nrows; i++)
    {
        for (int j = 0; j < Mcolumns; j++)
        {
            Console.Write($"{result[i, j]} \t");
        }
        Console.WriteLine();
    }
    return result;
}

double[] SrArifm(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j, i];
        }
        result[i] /= matrix.GetLength(0);
    }
    return result;
}

// int[,] matr =
// {
//                 {4, 2, 1, 7},
//                 {2, 6, 3, 2},
//                 {7, 2, 7, 7},
//                 {6, 1, 0, 5}
// };

int[,] matr = GenArray(6, 4, 10);
Console.WriteLine();
Console.WriteLine($"Ответ -> [{String.Join(", ", SrArifm(matr))}]");


/*
int n = 8000;
int[,] m = new int[n, n];
int sum = 0;
// time start
DateTime dt = DateTime.Now;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum += m[i, j];
    }
}
//time end
DateTime te = DateTime.Now;
Console.Clear();
Console.WriteLine((te - dt).TotalMilliseconds);
*/