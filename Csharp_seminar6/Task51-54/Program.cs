/*Условие задачи
51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

53. В двумерном массиве показать позиции числа,
заданного пользователем или указать, что такого элемента нет

54. В матрице чисел найти сумму элементов главной диагонали


Автор: Трофимов П.А.
*/
//51 ЗАДАЧА

//Метод для заполнения двумерного массива из сумм индексов
int[,] FillArraySums(int[,] array)
{
    //Заполняем двумерный массив случайными значениями
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

//Отображение сгенерированного двумерного массива
void PrintArray(int[,] array, string text = "\nСгенерированный массив: \n")
{
    Console.WriteLine(text);
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
/*
//Программа
int[,] matrix = new int[5, 5];
matrix = FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
*/

//52 ЗАДАЧА

//Метод для заполнения двумерного массива из целых чисел
int[,] FillArray(int[,] array, int min = 0, int max = 100)
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

int[,] SqrIndex(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matr.GetLength(1); j = j + 2)
        {
            matr[i, j] *= matr[i, j];
        }
    }
    return matr;
}

//Программа
/*
int[,] matrix = new int[5, 5];
matrix = FillArray(matrix, 0, 10);
PrintArray(matrix);
matrix = SqrIndex(matrix);
PrintArray(matrix, "----------------");
Console.WriteLine();
*/

//53 ЗАДАЧА
//Ввод числа
int IntNumber(string text)
{
    bool Condition = true;
    int number = 0;
    while (Condition)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            Condition = false;
        }
        else
        {
            Console.WriteLine("Введенный символ не является числом!");
        }
    }
    return number;
}

string Positions(int[,] matr, int number)
{
    string result = string.Empty;
    //int[,] result = new int[]
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number) result += $"[{i},{j}]; ";
        }
    }
    if (result == string.Empty) result += "Такого элемента нет";
    return result;
}

//Программа
/*
int[,] matrix = new int[5, 5];
matrix = FillArray(matrix, 0, 10);
PrintArray(matrix);
int N = IntNumber("Введите число для поиска: ");
Console.WriteLine($"Позиции числа в массиве: "
                + $"{Positions(matrix, N)}");
*/

//54 ЗАДАЧА
//В матрице чисел найти сумму элементов главной диагонали

int DiagonalSum(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) >= array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i, i];
        }
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, i];
        }
    }
    return sum;
}

//Программа:

int[,] matrix = new int[4, 6];
matrix = FillArray(matrix, 0, 10);
PrintArray(matrix);
Console.WriteLine($"Сумма элементов главной диагонал -> {DiagonalSum(matrix)}");
