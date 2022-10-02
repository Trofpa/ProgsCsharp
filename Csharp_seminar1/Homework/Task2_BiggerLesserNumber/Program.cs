/*
Условие задачи:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Автор: Трофимов П.А.
https://github.com/Trofpa/ProgsCsharp/tree/sem1_homework/Csharp_seminar1/Homework/Task2_BiggerLesserNumber
*/
Console.Clear();

int FirstNumber;
int SecondNumber;
Console.WriteLine("Введите первое число: "); // Вводим числа
int.TryParse(Console.ReadLine(), out FirstNumber);
Console.WriteLine("Введите второе число: ");
int.TryParse(Console.ReadLine(), out SecondNumber);

if ((i != 0)&& (j != 0)) // Проверка на то, что были введены числа
{
    if(FirstNumber > SecondNumber) // Сравниваем введенные числа
    {
        Console.WriteLine("Большее число: " + FirstNumber + "\nМеньшее число: " + SecondNumber);
    }
    else 
    {
        if (FirstNumber == SecondNumber)
        {
        Console.WriteLine("\nВведенные числа равны!"); // Проверка на равенство введенных чисел
        }
        else
        {
        Console.WriteLine("\nБольшее число: " + SecondNumber + "\nМеньшее число: " + FirstNumber);
        }
    }
}
else
{
    Console.WriteLine("Одно или оба значения не являлись числом!");
}