// Задача 1. Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т. д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный масив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++) // 4 6 8 1
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// Console.WriteLine("Введите размер массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(length, min, max);

// ShowArray(newArray);
// newArray = ReverseArray(newArray);
// ShowArray(newArray);

// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
// самое важное знать правило, что каждая сторона должна быть меньше (строго) суммы двух других сторон

bool CheckTriangle (int x, int y, int z)
{
    if ((x < y + z) && (y < x + z) && (z < x + y))
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите длину стороны a: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны b: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны c: ");
int z = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"CheckTriangle(x , y, z)");
bool res = CheckTriangle(x, y, z);
if (res == true)
{
    Console.WriteLine($"Треугольник со сторонами {x} {y} {z} может существовать ");
}
else
Console.WriteLine($"Треугольник со сторонами {x} {y} {z} не может существовать ");