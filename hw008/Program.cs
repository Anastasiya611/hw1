// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int numberA = 0;
while (N > numberA)
{
    numberA += 2;
    if (numberA<=N)
    Console.WriteLine(numberA);
}
