// Задача 1. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите число № {i + 1}:");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1) Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void CountNum (int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) result +=1;
    Console.WriteLine($"Введено {array.Length} числа (чисел), из них {result} больше 0");
}


Console.WriteLine("Сколько чисел Вы хотите ввести?");
int M = int.Parse(Console.ReadLine()!);
int[] massive = FillArray(M);
PrintArray(massive);
CountNum(massive);

