//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
//а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using System;

namespace c__HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи первое число: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи второе число: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.Write($"Max = {n1}, min = {n2}");    
            }
            else if (n1 < n2)
            {
                Console.Write($"Max = {n2}, min = {n1}"); 
            }
            else
            {
                Console.Write("Числа равны, попробуй еще раз!");
            }
        } 
    }
}
