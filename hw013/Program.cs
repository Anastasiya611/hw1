// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if ( number < 100)
{
    Console.WriteLine ("третьей цифры нет");
}
else
{
    Console.WriteLine (number.ToString () [2]);
}

