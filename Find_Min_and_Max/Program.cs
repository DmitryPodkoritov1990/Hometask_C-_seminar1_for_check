// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Найти макс. и мин из чисел ");
int first_number = int.Parse(Console.ReadLine()!);
int second_number = int.Parse(Console.ReadLine()!);
if (first_number > second_number)
{
Console.WriteLine("Max = " + first_number);
Console.WriteLine("Min = " + second_number);
}
if (second_number > first_number)
{
Console.WriteLine("Max = " + second_number);
Console.WriteLine("Min = " + first_number);
}