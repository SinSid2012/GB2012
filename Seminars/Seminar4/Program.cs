// Задача 1. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

// int FindSum (int num)
// {
//     int sum = 0;
//     for (int current = 1; current <= num; current++)
//     {
//         sum += current;
//     }
//     return sum;
// }

// Console.WriteLine("Input A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = FindSum(a);
// Console.WriteLine(result);

// задача 2. Напишите программу, которая выводит массив из N элементов, заполненный заданными числами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный масив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(length, min, max);
// ShowArray(newArray);

ShowArray(CreateRandomArray(length, min, max));