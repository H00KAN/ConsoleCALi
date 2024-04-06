using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCALi
{
    class Program
    {
        char MainMenu()
        {
            while (true)
            {
                Console.WriteLine("1 - Умножение");
                Console.WriteLine("2 - Деление");
                Console.WriteLine("3 - Сложение");
                Console.WriteLine("4 - Вычитание");

                char choice = Console.ReadKey().KeyChar;
                if (choice < '1' || choice > '4')
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
            char choice = (char)0;

            while (choice != '4') 
            {
                choice = MainMenu();
                switch (choice)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + a*b);
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int c = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + c / d);
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int g = int.Parse(Console.ReadLine());
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + g + e);
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int r = int.Parse(Console.ReadLine());
                        int z = int.Parse(Console.ReadLine());
                       // Console.WriteLine("Ответ - " + r - z);
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

