Console.WriteLine("Введите трехзначное число: ");

int a = int.Parse(Console.ReadLine());

int SecondDigit = (a % 100)/10;

Console.WriteLine("Вторая цифра введенного числа: " + SecondDigit + "!");