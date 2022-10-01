/*
Задача нахождения квадрата введенного числа
*/

Console.Write("Введите, пожалуйста, вещественное число: ");

double number = Convert.ToDouble(Console.ReadLine());

double square = Math.Pow(number, 2);

Console.WriteLine("Квадрат числа: " + square);
