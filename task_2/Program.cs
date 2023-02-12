// See https://aka.ms/new-console-template for more information
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


using System;

Console.Write("Введи первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n1 < n2)
{
    max = n2;
}
if (max < n3)
{
    max = n3;
}
Console.Write($"Максимальное число {max}");