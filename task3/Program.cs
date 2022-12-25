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


int len = Promt("Введите длину массива");
double[] userarray = new double [len];


CreateArray(userarray);
PrintArray(userarray);

double min = userarray[0];
double max = userarray[0];

for (int i = 0; i < userarray.Length; i ++)
{
    if (userarray[i] >= max)
    {
        max = userarray[i];
    }
    if (userarray[i] < min)
    {
        min = userarray[i];
    } 
       
}

double totalvalue = max - min;

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значением равна {totalvalue}");