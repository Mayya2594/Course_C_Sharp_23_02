// Задача 3: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Massive (int mas)
{
    int[] numbers = new int[mas];
    for(int i = 0; i < mas; i++)
    {
        numbers[i] = new Random().Next(0, 2);
        Console.Write($"{numbers[i]}, ");
    }

}

Massive(8);