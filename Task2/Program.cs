// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Write("Vvedite stroku: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower();
Console.Write(inputString);