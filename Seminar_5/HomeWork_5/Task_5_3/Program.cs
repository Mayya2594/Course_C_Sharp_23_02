// Задача 3. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray (int size, double from, double to)
{

    double[] array = new double [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() * (to - from) + from; // new Random.NextDouble() * (end - begin) + begin
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1) Console.Write($"{array[i]}]");
    Console.WriteLine();    
}

void DiffMaxMin (double[] array)
{
    double minNum = array[0];
    double maxNum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNum) minNum = array[i];
        if (array[i] > maxNum) maxNum = array[i];
    }
    Console.WriteLine($"max = {maxNum}, min = {minNum}, разность = {maxNum - minNum}");
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение:");
double min = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение:");
double max = double.Parse(Console.ReadLine()!);
double[] massive = FillArray(length, min, max);
PrintArray(massive);
DiffMaxMin(massive);