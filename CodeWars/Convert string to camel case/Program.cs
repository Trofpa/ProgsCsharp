/*
Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.
Examples

"the-stealth-warrior" gets converted to "theStealthWarrior"

"The_Stealth_Warrior" gets converted to "TheStealthWarrior"

"The_Stealth-Warrior" gets converted to "TheStealthWarrior"

*/

using System;

string ToCamelCase(string str)
{
    string NewString = "";

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == '-' || str[i] == '_')
        {
            continue;
        }
        else 
        {
            if (i == 0)
            {
                NewString += str[i];
                continue;
            }
            else if (str[i - 1] == '-' || str[i - 1] == '_')
            {
                NewString += str[i].ToString().ToUpper();
            }
            else
            {
                NewString += str[i];
            }
        }
    }
    return NewString;

}




string a = "The_Stealth___Warrior___";

Console.WriteLine(ToCamelCase(a));

// Рабочий вариант

// using System;
// using System.Globalization;
// public class Kata
// {
//         public static string ToCamelCase(string str)
//         {
//             var words = str.Split('-','_');
//             for (int i = 1; i < words.Length; i++)
//             {
//               words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i]);
//             }
//             return String.Join("", words);

