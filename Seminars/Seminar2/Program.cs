// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8
// 12 -> 2
// 85 -> 8

// int MaxNumber (int num) // 27
// {
//     int a = num / 10;
//     int b = num % 10;
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// int randomNumber = new Random().Next(10,99+1); // 100
// Console.WriteLine(randomNumber);
// int result = MaxNumber(randomNumber);
// Console.WriteLine(result);

// Напишите программу, которая принимает на вход трёхзначное число и на выходе не показывает вторую цифру этого числа.

// int DeleteNumber (int num) // 456
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;
// }

// int randomNumber = new Random().Next(100,1000); // 999+1
// Console.WriteLine(randomNumber);
// int result = DeleteNumber(randomNumber);
// Console.WriteLine(result);