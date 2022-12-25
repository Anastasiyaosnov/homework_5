// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int Sum(int[] array2)
{
    int sum = 0;
    int lenght2 = array2.Length;
    for (int index = 0; index < lenght2; index = index + 2)
    {
        sum += array2[index];
    }
    return sum;
}

int userv1 = Promt("Введите длину массива");

int[] total1 = CreateArray(userv1);
PrintArray(total1);

int total2 = Sum(total1);
Console.WriteLine();

Console.WriteLine($"сумма элементов, стоящих на нечетных позициях в массиве, равна > {total2} ");