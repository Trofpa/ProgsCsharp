/*
Write an algorithm that will identify valid IPv4 addresses in dot-decimal format.
IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.
Valid inputs examples:

Examples of valid inputs:
1.2.3.4
123.45.67.89

Invalid input examples:

1.2.3
1.2.3.4.5
123.456.78.90
123.045.067.089

Notes:

    Leading zeros (e.g. 01.02.03.04) are considered invalid
    Inputs are guaranteed to be a single string


*/

using System;


bool IsValidIp(string ipAddres)
{
    bool result = false;
    int temp = 0;
    string[] numbers = ipAddres.Split('.');
    if (numbers.Length != 4) return false;
    else
    {
        foreach (string number in numbers)
        {
            result = 
            (
                number.Contains(' ') ||
                !int.TryParse(number, out temp) ||
                (number.Length > 1 && number[0] == '0') ||
                temp < 0 ||
                temp > 255
            );
            if (result) break;
        }
    }
    return !result;
}


string IP = "823.45.67.89";


Console.WriteLine(IsValidIp(IP));