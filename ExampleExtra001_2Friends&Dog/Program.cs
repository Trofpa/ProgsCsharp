/* Задача с собакой и друзьями:
2 друга находятся на заданном расстоянии друг от друга и движутся навстречу с различной скоростью.
Собака бегает от одного друга к другому, пока они не встретятся.
    Вопрос: имея расстояние между друзьями, скорости двух друзей и собаки, определить, сколько раз собака
проделает путь от одного друга к другому?

Автор: Трофимов П.А. */

double time = 0;
int FirstFrSpeed = 1;
int SecondFrSpeed = 2;
int DogSpeed = 5;
int friend = 2;
int count = 0;
double distance = 0;

bool condition = true;

while (condition)
{
    Console.Clear();
    count = 0;
    Console.Write("Введите, пожалуйста, расстояние между друзьями, в метрах: ");
    distance = Convert.ToDouble(Console.ReadLine());

    while (distance > 10)
    {
        if (friend == 1)
        {
            time = distance/(FirstFrSpeed + DogSpeed);
            friend = 2;
        }
        else
        {
            time = distance/(SecondFrSpeed + DogSpeed);
            friend = 1;
        }

        distance -= time * (FirstFrSpeed + SecondFrSpeed);
        count++;
    }

    int rest = count % 10;

    if (((rest == 2)&&(count != 12))||((rest == 3)&&(count != 13))||((rest == 4)&&(count != 14)))
    {
        Console.WriteLine("Собака пробежит " + count + " раза!");
    }
    else
    {
        Console.WriteLine("Собака пробежит " + count + " раз!");    
    }
    Console.WriteLine("Нажмите любую клавишу, чтобы начать заново!\nЧтобы закончить, нажмите Esc"); 
    var btn = Console.ReadKey(true);
    if (btn.Key == ConsoleKey.Escape)
    {
        condition = false;
    }
}



