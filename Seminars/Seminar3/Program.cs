// Задание 1. Напишите программу, которая принимает на вход координаты точки (Х и Y), причем Х ≠ 0 и Y ≠ 0 и выдает номер плоскости.

// int FindQuart (double x, double y)
// {
//     if (x > 0 && y > 0)
//     return 1;
//     if (x < 0 && y > 0)
//     return 2;
//     if (x < 0 && y < 0)
//     return 3;
//     if (x > 0 && y < 0)
//     return 4;

//     return 0;
// }

// Console.WriteLine("Input X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input Y: ");
// double y = Convert.ToDouble(Console.ReadLine());

// int result = FindQuart(x, y);

// if (result == 0)
// Console.WriteLine("Point not find");
// else
// Console.WriteLine($"Point located in {result} quart");

// Задание 2. Напишите програму, которая по заданному номеру четверти, показывает диапозон  возможных координат точек этой четверти.

// void FindCoordinats (int quart)
// {
//     if (quart == 1)
//     {
//         Console.WriteLine("Диапозон координат (x+ y+)");
//     }
//     if (quart == 2)
//     {
//         Console.WriteLine("Диапозон координат (x- y+)");
//     }
//     if (quart == 3)
//     {
//         Console.WriteLine("Диапозон координат (x- y-)");
//     }
//     if (quart == 4)
//     {
//         Console.WriteLine("Диапозон координат (x+ y-)");
//     }
//     if (quart < 1 || quart > 4)
//     {
//         Console. WriteLine("Заданной четверти не существует");
//     }
// }

// Console.WriteLine("Введите номер четверти: ");
// int quart = Convert.ToInt32(Console.ReadLine());
// FindCoordinats(quart);