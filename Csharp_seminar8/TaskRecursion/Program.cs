/*
Есть два числа, 5 и 18

Сколько есть вариантов перехода (маршруты) из числа 5 -> 18  ответ 3!

через команды +1 и *3 

23 -> 2022 (через команды +1 и *3)
2 -> 11 (через команды +1 и *3)

*/


long[] storage = new long[2023];

long Ways1(long st_numb, long end_numb, long multiply)
{
    if(end_numb < st_numb) return 0;
    if(end_numb == st_numb) return 1;
    else if (end_numb % multiply == 0)
    {
        long d = 0;
        if (storage[end_numb/multiply] != 0) d = storage[end_numb/multiply];
        else
        {
            d = Ways1(st_numb, end_numb / multiply, multiply);
            storage[end_numb/multiply] = d;
        }
        long q = 0;

        if (storage[end_numb - 1] != 0) q = storage[end_numb - 1];
        else
        {
            q = Ways1(st_numb, end_numb - 1, multiply);
            storage[end_numb - 1] = q;
        }
        return d + q;
    }
    else
    {
        long q = 0;

        if (storage[end_numb - 1] != 0) q = storage[end_numb - 1];
        else
        {
            q = Ways1(st_numb, end_numb - 1, multiply);
            storage[end_numb - 1] = q;
        }
        return q;
    }
}


Console.WriteLine($"2 to 11 by multi 3 and +1:  {Ways1(2, 6, 3)}");




