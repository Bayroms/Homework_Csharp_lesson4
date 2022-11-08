// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void ExponantionAtoB()
// {
//     System.Console.WriteLine("Enter number A");
//     int a = int.Parse(Console.ReadLine());
//     System.Console.WriteLine("Enter number B");
//     int b = int.Parse(Console.ReadLine());
//     int step = a;

//     for (int i = 1; i < b; i++)
//     {
//         step *= a;
//     }
//     System.Console.WriteLine($"Exponantion A to B = {step}");
// }
// ExponantionAtoB();


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SummOfDigits()
// {
//     System.Console.WriteLine("Enter number: ");
//     int a = int.Parse(Console.ReadLine());
//     int sum = 0;
//     while (a > 0)
//     {
//     sum = sum + a % 10;
//     a = a / 10;
//     }
//     Console.WriteLine(sum);
// }
// SummOfDigits();


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] Array = new int;
//     Random rnd = new Random();
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = rnd.Next(0,2);
//         Console.Write($"{Array[i]}, ");
//     }