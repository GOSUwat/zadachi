using System;

namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tУсловные конструкции");
            while (true)
            {
                double a,b;
                Console.WriteLine("\nВыберите задачу 1-7 ");
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
                            Console.WriteLine($"{a} 5%");
                        }
                        if ((a >= 100) & (a <= 200))
                        {
                            a = a + a / 100 * 7;
                            Console.WriteLine($"{a} 7%");
                        }
                        if ((a > 200))
                        {
                            a = a + a / 100 * 10;
                            Console.WriteLine($"{a} 10%");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Изменим предыдущую задачу.\n Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы.\n И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы.\n Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.");
                        a = Convert.ToDouble(Console.ReadLine());
                        if ((a < 100))
                        {
                            a = a + a / 100 * 5 + 15;
                            Console.WriteLine($"{a} 5% + 15");
                        }
                        if ((a >= 100) & (a <= 200))
                        {
                            a = a + a / 100 * 7 + 15;
                            Console.WriteLine($"{a} 7% + 15");
                        }
                        if ((a > 200))
                        {
                            a = a + a / 100 * 10 + 15;
                            Console.WriteLine($"{a} 10% + 15");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Напишите консольную программу, которая выводит пользователю сообщение Введите номер операции:\n 1.Сложение\n 2.Вычитание\n 3.Умножениe.\n Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2.\n Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.\nДля определения операции по введенному номеру используйте конструкцию switch...case.\nЕсли введенное пользователем число не соответствует никакой операции(например, число 120),\n то выведите пользователю сообщение о том, что операция неопределена.");
                        Console.WriteLine("\nВведите номер операции:\n 1.Сложение\n 2.Вычитание\n 3.Умножениe.");
                        a = Convert.ToDouble(Console.ReadLine());
                            switch (a)
                            {
                                case 1:
                                    Console.WriteLine("Сложение");
                                    break;
                                case 2:
                                    Console.WriteLine("Вычитание");
                                    break;
                                case 3:
                                    Console.WriteLine("Умножениe");
                                    break;
                            default:
                                Console.WriteLine("Oперация неопределена.");
                                break;
                            }
                        break;
                    case 7:
                        Console.WriteLine("Измените предыдущую программу.\n Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются).\n Результа операции выводиться на консоль.");
                        Console.WriteLine("\nВведите номер операции:\n 1.Сложение\n 2.Вычитание\n 3.Умножениe.");
                        a = Convert.ToDouble(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                Console.WriteLine("Сложение");
                                Console.WriteLine("Введите числа а и б");
                                a = Convert.ToDouble(Console.ReadLine());
                                b = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Результат = {a + b}");
                                break;
                            case 2:
                                Console.WriteLine("Вычитание");
                                Console.WriteLine("Введите числа а и б");
                                a = Convert.ToDouble(Console.ReadLine());
                                b = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Результат = {a-b}");
                                break;
                            case 3:
                                Console.WriteLine("Умножениe");
                                Console.WriteLine("Введите числа а и б");
                                a = Convert.ToDouble(Console.ReadLine());
                                b = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Результат = {a * b}");
                                break;
                            default:
                                Console.WriteLine("Oперация неопределена.");
                                break;
                        }
                        break;
                }

            }
        }

    }
}
