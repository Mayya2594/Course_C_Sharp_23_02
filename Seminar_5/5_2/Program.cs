// Задача 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.


void Print (int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums (int size, int from, int to)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void MassIsNum (int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
        {
            Console.WriteLine("Yes");
            return;
        }
    }
    Console.WriteLine("No");
}

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество элементов массива:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальную границу:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальную границу:");
int max = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(num, min, max);
Print(mass);
MassIsNum(mass, a);