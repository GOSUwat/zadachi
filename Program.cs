using System;

namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a,b;
                Console.WriteLine("\nВыберите задачу ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Упражнение 1\nНапишите консольную программу, в которую пользователь вводит с клавиатуры два числа.\nА программа сранивает два введенных числа и выводит на консоль результат сравнения(два числа равны, первое число больше второго или первое число меньше второго).");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        if (a < b)
                        {
                            Console.WriteLine($"{a} < {b}");
                        }
                        else if(a > b)
                        {
                            Console.WriteLine($"{a} > {b}");
                        }
                        else
                        {
                            Console.WriteLine($"{a} = {b}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Упражнение 2\nНапишите консольную программу, в которую пользователь вводит с клавиатуры число.\nЕсли число одновременно больше 5 и меньше 10, то программа выводит Число больше 5 и меньше 10.\nИначе программа выводит сообщение Неизвестное число.");
                        a = Convert.ToInt32(Console.ReadLine());
                        if ((a > 5)&(a < 10))
                        {
                            Console.WriteLine($"{a} больше 5 и меньше 10 ");
                        }
                        else
                        {
                            Console.WriteLine("Неизвестное число");
                        }
                        break;
                }
            }
        }

    }
}
