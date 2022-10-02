/*
22.Найти расстояние между двумя точками в пространстве 2D
Описываем с помощью функций (также называются методами)

*/
//Сама программа. Пользователь начинает вводить значение
double ax = GetValue("ax"); //ax
double ay = GetValue("ay"); //ay
double bx = GetValue("bx"); //bx
double by = GetValue("by"); //by

double dis = GetDistance(ax, ay, bx, by);

Print(ax, ay, bx, by, dis);

//Методы:

// Запрашивает координаты точек (п. 1 readme)
double GetValue(string text) 
{
    Console.Write(text + " : ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}


// Отображает отформатированный ответ (п. 3 readme)
void Print(double x1, double y1, double x2, double y2, double res) 
{
    // string output = "|A(" + ax + ", " + ay + "); B(" + bx + ", " + by + ")| = " + result; - конкатинация
    string output = $"|A({x1}, {y1}) B({x2}, {y2})| = {res}"; // c помощью $ ссылаемся в одной строке к аргументам!
    Console.WriteLine(output);
}


// Вычисляет расстояние между двумя точками по теореме Пифагора (п. 2 readme)
double GetDistance(double ax, double ay, double bx, double by) 
{
    double dx = Math.Pow(ax - bx, 2);
    double dy = Math.Pow(ay - by, 2);
    double result = Math.Sqrt(dx + dy);

    return result;
}

