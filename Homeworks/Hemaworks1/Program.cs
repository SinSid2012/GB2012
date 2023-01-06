// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberA > numberB)
// {
//     Console.WriteLine("Первое число " + numberA + " больше чем второе " + numberB);
// }
// else
// {
//     Console.WriteLine("Второе число " + numberB + " больше чем первое " + numberA);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите 3 числа:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());
// int max = number1;

// if (number2 > max)
// {
//     max = number2;
// }
// if (number3 > max)
// {
//     max = number3;
// }
// Console.WriteLine("Максимальное из этих чисел - " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 1)
// {
//     Console.WriteLine("Число " + number + " является нечетным");
// }
// else
// {
//     Console.WriteLine("Число " + number + "является четным");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool not = true;

Console.WriteLine("Чётные числа от 1 до " + number);
while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}