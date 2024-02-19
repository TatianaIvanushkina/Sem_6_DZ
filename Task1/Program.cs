// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

string GetStringFromCharArray(char[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + array[i, j];
        }
    }
    return result;
}

char[,] charMatrix = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
string res = GetStringFromCharArray(charMatrix);
Console.WriteLine(res);