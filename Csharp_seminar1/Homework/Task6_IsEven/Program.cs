﻿/*
Выяснить является ли число чётным.
*/

Console.WriteLine("Введите число");

int Number = int.Parse(Console.ReadLine());

if (Number % 2 == 0)
{
    Console.WriteLine(Number + " - четное число!");
}
else
{
    Console.WriteLine(Number + " - нечетное число!");
}
