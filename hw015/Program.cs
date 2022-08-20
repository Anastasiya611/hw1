// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 5)
Console.WriteLine ("yes");
else
Console.WriteLine ("no");
