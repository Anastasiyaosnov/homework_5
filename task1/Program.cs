// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int lenght)
{
    int[] first = new int[lenght];
    for (int i = 0; i < first.Length; i++)
    {
        first[i] = new Random().Next(100, 1000);
    }
    return first;
}

void PrintArray(int[] array1)
{
    int lenght1 = array1.Length;
    for (int i = 0; i < lenght1; i++)
        Console.Write($"{array1[i]} ");
}

int ElemArray(int[] array2)
{
    int index = 0;
    foreach (int element in array2)
    {
        if (element %2 ==0)
        {
            index ++;
        }
    }
    return index;
}

int userv1 = Promt("Введите длину массива");

int[] total1 = CreateArray(userv1);
PrintArray(total1);

int total2 = ElemArray(total1);
Console.WriteLine();

Console.WriteLine($"всего четных чисел в массиве > {total2} ");