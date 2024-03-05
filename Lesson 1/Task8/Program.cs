// Задача 1: Задайте двумерный массив символов
//  (тип char [,]). Создать строку из символов этого массива.
char[][] symbols = new char[3][];
symbols[0] = new char[] { 'i' };
symbols[1] = new char[] { 'l', 'o', 'v', 'e' };
symbols[2] = new char[] { 'p', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'i', 'n', 'g' };

string makeStringfromCharArray(char[][] charArray)
{
    string result = "";
    for (int i = 0; i < charArray.Length; i++)
    {
        for (int j = 0; j < charArray[i].Length; j++)
        {
            result += charArray[i][j];
        }
        result += " ";
    }
    return result;
}

Console.Clear();
string symbolsToString = makeStringfromCharArray(symbols);
Console.WriteLine(symbolsToString);

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку,
//  в которой все заглавные буквы заменены на строчные.

string makeStringLowerCase(string s)
{
    return s.ToLower();
}

string s = "CamelCase";
Console.WriteLine("Before lower case : " + s);
Console.WriteLine("After lower case : " + makeStringLowerCase(s));


// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


Console.WriteLine("Input palindrome");
string input = Console.ReadLine()!;

Boolean isPalindrome(string checkString)
{

    //char [] arr = new char [checkString.Length];
    for (int i = 0; i < checkString.Length / 2; i++)
    {
        if (!checkString[i].Equals(checkString[checkString.Length - 1 - i]))
        {
             Console.WriteLine("This string is not palindrome");
            return false;
        }
    }
    Console.WriteLine("This string is palindrome");
    return true;
}

Console.WriteLine(isPalindrome(input));


