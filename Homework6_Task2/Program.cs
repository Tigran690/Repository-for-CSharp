// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
// Пример
// “aBcD1ef!-” => “abcd1ef!-”

string input = "aBcD1ef!-";
string result = input.ToLower();
Console.WriteLine(result);