// Задача 2: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ConvertBin (int num)
{
    string result = String.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);
string res = ConvertBin(n);
Console.WriteLine($"{n} -> {res}");
