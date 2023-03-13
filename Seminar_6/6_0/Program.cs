// Задача 0: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] FillArray (int size, int from, int to)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to);
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1) Console.Write($"{array[i]}]");
    Console.WriteLine();    
}

void RevMas (int[] array)
{
    int size = array.Length;
    for(int i = 0; i < size / 2; i++)
        (array[i], array[size - i - 1]) = (array[size - i - 1], array[i]); 
} 


Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение:");
int max = int.Parse(Console.ReadLine()!);
int[] massive = FillArray(length, min, max);
PrintArray(massive);
RevMas(massive);
PrintArray(massive);