Console.WriteLine("Введите число а:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine()!);

if(a == b * b)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}