// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// string num = Console.ReadLine();
// int len = num.Length;

// if (len == 5)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         Console.WriteLine($"{num} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{num} - Не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"Число {num} - не является пятизначным");
// }

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int a = x2 - x1;
// int b = y2 - y1;
// int c = z1 - z2;

// double length = Math.Sqrt(a * a + b * b + c * c);
// Console.WriteLine($"Расстояние между двух точек в 3D пространстве {length}");

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int number = ReadInt("Введите число: ");

// for (int i = 1; i <= number; i++)
// {
//     Console.Write($"{i * i * i}, ");
// }