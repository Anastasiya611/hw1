// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int a = number / 10;
int b = a % 10;
Console.WriteLine (b);

