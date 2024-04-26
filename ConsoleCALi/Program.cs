﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCALi
{
    class Program
    {

        public interface ICalculator
        {
            double add(double a, double b);
            double subtract(double a, double b);
            double multiply(double a, double b);
            double divide(double a, double b);
        }

        public class addCalculator : ICalculator
        {
            public double add(double a, double b) => a + b;
        }

        char MainMenu()
        {
            while (true)
            {
               Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("1 - Умножение        ");
                Console.WriteLine("2 - Деление          ");
                Console.WriteLine("3 - Сложение         ");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("4 - Вычитание        ");
                Console.WriteLine("5 - Корень числа     ");
                Console.WriteLine("6 - Косинус числа    ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("7 - Синус числа      ");
                Console.WriteLine("8 - Тангенс числа    ");
                Console.WriteLine("9 - Число в степень\n");
                Console.BackgroundColor = ConsoleColor.Black;


                char choice = Console.ReadKey().KeyChar;
                if (choice < '1' || choice > '9')
                {
                    Console.Clear();
                    Console.WriteLine("Такого Варианта не существует ");
                    Console.ReadKey();
                }
                else
                {
                    return choice;
                }
            }
        }

        public int Logika () 
        {
            double result = 0;
            char choice = (char)0;

            while (choice != '9') 
            {
                choice = MainMenu();
                switch (choice)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        result = ((ICalculator)addCalculator).add(a, b);
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int c = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + (c / d));
                        Console.ReadLine();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int g = int.Parse(Console.ReadLine());
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + (g + e));
                        Console.ReadLine();
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int r = int.Parse(Console.ReadLine());
                        int z = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + (r - z));
                        Console.ReadLine();
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("Введите число");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Sqrt(n));
                        Console.ReadLine();
                        break;
                    case '6':
                        Console.Clear();
                        Console.WriteLine("Введите число");
                        int C = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Cos(C));
                        Console.ReadLine();
                        break;
                    case '7':
                        Console.Clear();
                        Console.WriteLine("Введите число");
                        int A = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Sin(A));
                        Console.ReadLine();
                        break;
                    case '8':
                       Console.Clear();
                        Console.WriteLine("Введите число");
                        int B = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Tan(B));
                        Console.ReadLine();
                        break;
                    case '9':
                       Console.Clear();
                        Console.WriteLine("Введите число а после степень");
                        int G = int.Parse(Console.ReadLine());
                        int j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Pow(G, j));
                        Console.ReadLine();
                        break;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            new Program().MainMenu();
            new Program().Logika();
        }
    }
}

