/*
Пример работы с текстовыми файлами при помощи программ

*/
/*
string path = @"C:/Users/Ignorance/Desktop/file.txt";
string text = File.ReadAllText(path);


int pos = text.IndexOf("\n");

//str[] lines = text.Split("\n");
//string[] lines = File.ReadAllLines(path); // читает файл


// for (int i = 0; i < lines.Length; i++)
// {
//     Console.WriteLine($"{i + 1}: {lines[i]}");
// }

int a = 0;
int b = 0;
string[] lines = File.ReadAllLines(path); // читает файл

for (int i = 0; i < lines.Length; i++)
{
    string[] symbols = lines[i].Split('=');
    if(symbols[0].Trim() == "a")
        a = Convert.ToInt32(symbols[0].Trim());
    if(symbols[1].Trim() == "b")
        b = Convert.ToInt32(symbols[0].Trim());
 
}

Console.WriteLine($"a = {a}; b = {b}");

File.WriteAllText("output.db", $"результат = {a, b}");// - вывод в файл

*/

string[] fNames = File.ReadAllLines("names.txt");
string[] lNames = File.ReadAllLines("last_names.txt");


string output = String.Empty;

//File.WriteAllLines("result.csv", "ID; Имя;Фамилия;Возраст;");  - заранее создать файл с заголовком

for (int i = 0; i < 10000; i++)
{
    string manFName = fNames[Random.Shared.Next(fNames.Length)];
    string manLName = lNames[Random.Shared.Next(lNames.Length)];
    int age = Random.Shared.Next(18, 78);
    string currentMan = $"{i + 1};{manFName};{manLName};{age};";
    output += $"{currentMan}\n";

}

File.WriteAllText("result.csv", output);

//File.AppendAllText("result.csv", output); - с заранее созданным файлом используем Append

