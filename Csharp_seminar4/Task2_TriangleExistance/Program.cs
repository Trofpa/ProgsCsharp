

int Input(string text)
{
    Console.WriteLine($"Введите длину стороны {text}: ");
    return int.Parse(Console.ReadLine());
}

bool Out(int a, int b, int c)
{
    return !((a + b < c) || (a + c < b) || (c + b < a));
}

Console.WriteLine(Out(Input("a"), Input("b"), Input("c")));


/*
int input(string a)
{
    Console.WriteLine($"Введите длинну отрезка {a}");
    return Convert.ToInt32(Console.ReadLine());
}

bool Output(int a, int b, int c)
{
    return (a+b>c && a+c>b && b+c>a);
}

Console.WriteLine(Output(input("a"), input("b"), input("c")));



*/

