// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondNumber (int num) // 456
// {
//     int a = num / 10 % 10;
//     return a;
// }

// int randomNumber = new Random().Next(100,1000);
// Console.WriteLine(randomNumber);
// int result = SecondNumber(randomNumber);
// Console.WriteLine(result);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int ThirdNumber (int num) // 10123
// {
//     if (num >= 100 && num < 1000)
//     {
//         num = num % 10;
//         return num;
//     }
//     else
//     {
//         if (num >=1000)
//         {
//             while(num >=1000)
//             {
//                 num = num / 10;
//             }
//             num = num % 10;
//             return num;
//         }
//         else
//         {
//             Console.WriteLine($"Третьей цифры нет!");
//             return num;
//         }
//     }
// }

// Console.WriteLine("Введите любое число: ");
// int numberN = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(numberN);
// int result = ThirdNumber(numberN);
// Console.WriteLine(result);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Week (int num)
{
    if(num > 5)
    {
        Console.WriteLine($"{num} -> да");
        return num;
    }
    else
    {  
        Console.WriteLine($"{num} -> нет");
        return num;
    }
}

Console.WriteLine("Введите цифру от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Week(num));