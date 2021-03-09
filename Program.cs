﻿using System;

namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a,b;
                Console.WriteLine("\nВыберите задачу 1-30 ");
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
                    case 3:
                        Console.WriteLine("Упражнение 3Напишите консольную программу, в которую пользователь вводит с клавиатуры число.\nЕсли число либо равно 5, либо равно 10, то программа выводит Число либо равно 5, либо равно 10.\nИначе программа выводит сообщение Неизвестное число");
                        a = Convert.ToInt32(Console.ReadLine());
                        if ((a == 5) ^ (a == 10))
                        {
                            Console.WriteLine($"Число {a} либо равно 5, либо равно 10");
                        }
                        else
                        {
                            Console.WriteLine("Неизвестное число");
                        }
                        break;
                    case 4:
                        Console.WriteLine("В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.\n Напишите консольную программу, в которую пользователь вводит сумму вклада.\n Если сумма вклада меньше 100, то начисляется 5%.\n Если сумма вклада от 100 до 200, то начисляется 7%.\n Если сумма вклада больше 200, то начисляется 10%.\n В конце программа должна выводить сумму вклада с начисленными процентами.\nДля получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())");
                        a = Convert.ToDouble(Console.ReadLine());
                        if ((a < 100))
                        {
                            a = a + a / 100 * 5;
                            Console.WriteLine($"{a} 5");
                        }
                        if ((a >= 100) & (a <= 200))
                        {
                            a = a + a / 100 * 7;
                            Console.WriteLine($"{a} 7");
                        }
                        if ((a > 200))
                        {
                            a = a + a / 100 * 10;
                            Console.WriteLine($"{a} 10");
                        }
                        break;
                    case 5:

                        break;
                }

            }
        }

    }
}
