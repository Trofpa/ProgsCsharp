/*
 5. Написать программу вычисления значения функции  
 Функция:
 `f(a) = Sin(a + Cos(1 / a))`
*/

//Методы:
//Считаем функцию
void GetFunction(double arg)
{
    double Cosine = Math.Cos(1/arg);
    double result = Math.Sin(arg + Cosine);
    Console.WriteLine($"Значение косинуса внутри: {Cosine}");
    Console.WriteLine($"Значение функции: {result}");
}

// Запрашиваем у пользователя значения аргумента и запоминаем значение в переменную
double GetValue(string text) 
{
    Console.Write(text + " : ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}


//Программа:
double number = GetValue("Введите аргумент функции");
GetFunction(number);

