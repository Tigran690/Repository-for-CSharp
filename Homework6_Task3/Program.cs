// Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// Пример
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

class Task3
{
    static void Main(string[] args)
    {
        string input = "aBcD1ef!-";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine(isPalindrome ? "Да" : "Нет");
    }
    static bool IsPalindrome(string str)
    {
        string normalized = new
        string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return normalized.SequenceEqual(normalized.Reverse());
    }
}