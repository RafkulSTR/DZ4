using System;
using System.Diagnostics.CodeAnalysis;

namespace DZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Выбери задачу
25 - Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.;
27 - Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
29 - Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
29d - 29 только пользователь сам вводит массив;
q - выход из программы");

                string select = Console.ReadLine();
                switch (select)
                {
                    case "25":
                        Zad25();
                        break;
                    case "27":
                        Zad27();
                        break;
                    case "29":
                        Zad29();
                        break;
                    case "29d":
                        Zad29dop();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        //
        //
        static void Zad25()
        {
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            int sqr = 1; 
            for (int i = 1; i <= B; i++)
            {
                sqr *=  A;
            }
            Console.WriteLine($"Число {A} в степени {B} = {sqr}");
            Console.WriteLine();
        }
        
        //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        //
        //
        static void Zad27()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int copynumber = number;
            int sum = 0;
            while (number > 0)
            {
                int rez = number % 10;
                number /= 10;
                sum += rez;
            }
            Console.WriteLine($"Сумма чисел в числе {copynumber} = {sum}");
            Console.WriteLine();
        }

        static void Zad29()
        {
            int size = 8;
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10,1000);

            }
            Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
            Console.WriteLine();
        }

        static void Zad29dop()
        {
            int size = 8;
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива array[{i}]");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
            Console.WriteLine();
        }


    }
}