/*Условие задачи:
21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

Автор: Трофимов П.А.

*/

//Программа:

int[] Point1 = InputCoordinates("Введите координаты 1 точки: ");
int[] Point2 = InputCoordinates("Введите координаты 2 точки: ");

GetDistance();





//Методы:

int[] InputCoordinates(string text)
{
    bool Condition = true;
    int[] array = new int[1];
    int i = 0;
    while (i < array.Length)
    {
        while (Condition)
        {
            Console.Write(text);
            if (int.TryParse(Console.ReadLine(), out array[i]))
            {
                Condition = false;
            }
            else
            {
                Console.WriteLine("Введенный символ не является числом!");
            }
        }
    }
    return array;
}

void GetDistance(int[] arr1, int[] arr2)
{
    return System.Math.Sqrt(Math.Pow(arr1[0]-arr2[0])+Math.Pow(arr1[1]-arr2[1])))
}