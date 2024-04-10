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
                Console.Clear();
                Console.WriteLine("1 - Умножение");
                Console.WriteLine("2 - Деление");
                Console.WriteLine("3 - Сложение");
                Console.WriteLine("4 - Вычитание");
                Console.WriteLine("5 - Корень числа");
                Console.WriteLine("6 - Косинус числа");
                Console.WriteLine("7 - Синус числа");
                Console.WriteLine("8 - Тангенс числа");
                Console.WriteLine("9 - Число в степень");

                //  Console.WriteLine("9 - Котангенс числа");
                //  Console.WriteLine("10 - Возвести в степень");


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
            char choice = (char)0;

            while (choice != '9') 
            {
                choice = MainMenu();
                switch (choice)
                {
                    case '1':
                        
                        Console.WriteLine("Введите 2 числа");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + (a*b));
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int c = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + (c / d));
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int g = int.Parse(Console.ReadLine());
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + (g + e));
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("Введите 2 числа");
                        int r = int.Parse(Console.ReadLine());
                        int z = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + (r - z));
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("Введите число");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Sqrt(n));
                        break;
                    case '6':
                        Console.Clear();
                        Console.WriteLine("Введите число");
                        int C = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Cos(C));
                        break;
                    case '7':
                        Console.Clear();
                        Console.WriteLine("Введите число");
                        int A = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Sin(A));
                        break;
                    case '8':
                        Console.Clear();
                        Console.WriteLine("Введите число");
                        int B = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Tan(B));
                        break;
                    case '9':
                        Console.Clear();
                        Console.WriteLine("Введите число а после степень");
                        int G = int.Parse(Console.ReadLine());
                        int j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ответ - " + Math.Pow(G, j));
                        break;
                        /*  case '9':
                              Console.Clear();
                              Console.WriteLine("Введите число");
                              int E = int.Parse(Console.ReadLine());
                              Console.WriteLine("Ответ - " );
                              break;
                          case '10':
                              Console.Clear();
                              Console.WriteLine("Введите число a степень в которую хотите возвести");
                              int D = int.Parse(Console.ReadLine());
                              int X = int.Parse(Console.ReadLine());
                              Console.WriteLine("Ответ - " + Math.Pow(D, X));
                              break; */



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

