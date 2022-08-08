// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int NumberA = 0;
while (N > NumberA)
{
NumberA += 2;
Console.WriteLine(NumberA);
}
