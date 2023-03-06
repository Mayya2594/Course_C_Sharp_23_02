// Задача 3: Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

void RandMassive (int num, int min, int max)
{
    int[] numbers = new int[num];
    Console.Write("[");
    for(int i = 0; i < num; i++)
    {
        numbers[i] = new Random().Next(min, max);
        if(i < num - 1) Console.Write($"{numbers[i]}, ");
        if(i == num - 1) Console.Write($"{numbers[i]}]"); 
    }
}

Console.WriteLine("Введите количество элементов массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальную границу:");
int minNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальную границу:");
int maxNum = int.Parse(Console.ReadLine()!);
RandMassive(length, minNum, maxNum);