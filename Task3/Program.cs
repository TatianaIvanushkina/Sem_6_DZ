// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом

char[] ConvertStringToCharArray (string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i]; 
    }
    return chars;
}


string str = "salas";
Console.WriteLine($"Stroka: {str}");
char[] chars = ConvertStringToCharArray(str);
int i = 0;
int j = str.Length - 1;
for (int i = 0; i < str.Length; i++, j--)
{
    if (char[i] != char[j])
    {
        return false;
    }
    return true;
}