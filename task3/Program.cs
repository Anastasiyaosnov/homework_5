// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76


int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArray(double[] first)
{
    for (int i = 0; i < first.Length; i++)
    {
        first[i] = Convert.ToDouble(new Random().Next(100, 1000)/10);
    }
}

void PrintArray(double[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
}


int userv1 = Promt("Введите длину массива");

CreateArray(userv1);
PrintArray(total1);

