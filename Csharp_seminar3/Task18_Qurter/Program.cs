/* Условие задачи:

Напишите программу,которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).

Автор: Трофимов П.А.
*/

// Программа

Console.Clear();
int Q = InputNumbers("Введите номер четверти: ");
Quarter(Q);


//Методы

int InputNumbers(string text)
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

void Quarter(int number)
{

    if ((number <= 0) || (number > 4))
    {
        Console.WriteLine("Есть всего 4 четверти! (-_-)");
    }
    else
    {
        switch (number)
        {
            case 1:
                Console.WriteLine($"\n{number}-я четверть плоскости." +
                "\nДиапазон значений X: [0, 100]" +
                "\nДиапазон значений Y: [0, 100]");
                break;

            case 2:
                Console.WriteLine($"\n{number}-я четверть плоскости." +
                "\nДиапазон значений X: [0, 100]" +
                "\nДиапазон значений Y: [0, -100]");
                break;

            case 3:
                Console.WriteLine($"\n{number}-я четверть плоскости." +
                "\nДиапазон значений X: [0, -100]" +
                "nДиапазон значений Y: [0, -100]");
                break;

            case 4:
                Console.WriteLine($"\n{number}-я четверть плоскости." +
                "\nДиапазон значений X: [0, 100]" +
                "\nДиапазон значений Y: [0, -100]");
                break;
        }
    }
}


