// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите в какую степень возвести число:");
// int exponent = Convert.ToInt32(Console.ReadLine());
// int result = number;
// for (int i = 2; i <= exponent; i++)
// {
//     result *= number;
// }
// System.Console.WriteLine($"Число [{number}] в степени [{exponent}] = [{result}]");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int sum (int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result = result + num % 10;
//         num = num / 10;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма цифр в числе [{number}] = [{sum(number)}]");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] array = new int[8];
// System.Console.WriteLine("Введите 8 чисел:");
// for (int i = 0; i < 8; i++)
// {
//     int number = Convert.ToInt32(Console.ReadLine());
//     array[i] = number;
// }
// System.Console.Write("Полученный массив = [");
// for (int i = 0; i < 8; i++)
// {
//     System.Console.Write($"{array[i]} ");
// }
// System.Console.Write("]");