
//Вращение на 90
string[,] Rotate90(string[,] matrix)
{
    int cols = matrix.GetLength(0);
    int rows = matrix.GetLength(1);
    string[,] temp = new string[rows, cols];
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            temp[j, i] = matrix[i, rows - (j + 1)];
        }
    }
    return temp;
}

/*
void Figure(int x, int y, int size_x, int size_y)
{
  Console.Clear();
  for (int i = x; i < x + size_x; i++)
  {
    for (int j = y; j < y + size_y; j++)
    {
      Console.SetCursorPosition(i, j);
      Console.Write("+");
    }
  }
}
*/
// int dx = 2;
// int dy = 3;


void FigurePrint(string[,] block, int x = 0, int y = 0)
{
    Console.Clear();
    for (int i = 0; i < block.GetLength(0); i++)
    {
        for (int j = 0; j < block.GetLength(1); j++)
        {
            Console.SetCursorPosition(x + j, y + i);
            Console.Write($"{block[i, j]}");
        }
    }

}


int x = 10;
int y = 6;
string[,] block =
{
  {"+", "+", "+","+"," "},
  {"+", "+", "+","+"," "},
  {" ", " ", "+","+"," "},
  {" ", " ", "+","+"," "},
  {" ", " ", "+","+"," "},
  {" ", " ", "+","+"," "}

};

// Логика отрисовки всего
Console.Clear();
new Thread(() =>
{
    while (true)
    {
        FigurePrint(block, x, y);
        Thread.Sleep(500);
        y++;
        if (y > 15) y = 1;
    }
}).Start();

// Логика проверки нажатия кнопок

while (true)
{
    int temp;
    var key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.LeftArrow)
    {
        x--;
        FigurePrint(block, x, y);
    }
    if (key == ConsoleKey.RightArrow)
    {
        x++;
        FigurePrint(block, x, y);
    }
    if (key == ConsoleKey.Spacebar)
    {
        block = Rotate90(block);
    }
}


//Поворот фигуры на 90 градусов
//Отображение тестового массива
void PrintArray(int[,] array, string text = "\nСгенерированный массив: \n")
{
    Console.WriteLine(text);
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

