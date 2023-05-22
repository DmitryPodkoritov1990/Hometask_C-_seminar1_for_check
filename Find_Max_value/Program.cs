// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число ");
int chislo1 = int.Parse(Console.ReadLine()!);
int chislo2 = int.Parse(Console.ReadLine()!);
int chislo3 = int.Parse(Console.ReadLine()!);

int Max = chislo1;

if (chislo2 > Max) Max = chislo2;
if (chislo3 > Max) Max = chislo3;

Console.Write("Max = ");
Console.WriteLine(Max);