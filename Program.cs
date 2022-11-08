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

// Не совсем понял почему в задаче массив из 8 элементов, а пример ответа из 5 и 3 чисел. Также не понятно числа должны быть рандомные или нет, на всякий случай сделаю две версии:
// Первая-вывод массива из 8 случайных чисел 

// int[] Array = new int[8];
//     Random rnd = new Random();
//     Console.WriteLine("Вывод массива:");
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = rnd.Next(0,100);
//         Console.Write($"{Array[i]}, ");
//     }

// Вторая-вывод массива из указанных в ответе чисел

Console.WriteLine("Enter number of elements in array: ");
int count = int.Parse(Console.ReadLine());
int[] Array = new int[count];

for (int i = 0; i < Array.Length; i++)
{
Console.WriteLine($"Enter number in index {i}: ");
Array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < Array.Length; i++)
{
    System.Console.Write($"{Array[i]}, ");
}
