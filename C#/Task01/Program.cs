﻿Console.WriteLine("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число неявляется квадратом второго");
}



