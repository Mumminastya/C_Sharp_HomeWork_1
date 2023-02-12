// See https://aka.ms/new-console-template for more information
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
int evNum = 1;

while(evNum <= n)
{
    if (evNum % 2 == 0)
    Console.Write($"{evNum}, "); 
    evNum++;
}