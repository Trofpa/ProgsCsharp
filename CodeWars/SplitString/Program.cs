/*

Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

Examples:

* 'abc' =>  ['ab', 'c_']
* 'abcdef' => ['ab', 'cd', 'ef']

*/


string str = "abcde";

Console.WriteLine(str);

int array_length = 0;
bool cond = (str.Length % 2 == 1);
if (cond){
    array_length = str.Length / 2 + 1;
}
else{
    array_length = str.Length / 2;
}
string[] str_array = new string[array_length];
    
for (int i = 0; i < array_length; i += 1)
{
    if (cond && (2 * i == str.Length - 1))
    {
        str_array[i] = str[2 * i] + "_";
    }
    else
    {
        str_array[i] = str.Substring(2 * i, 2);
    }
    Console.Write($"[ {str_array[i]} ] ");
}
