// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int n_celoe = int.Parse(Console.ReadLine()!);
int n_celoe2 = n_celoe * -1;
int nach_chislo = 2;

if (n_celoe > 2)
   {
    while (nach_chislo <= n_celoe)
    {
        Console.Write(nach_chislo + " ");
        nach_chislo += 2;
    }
   }