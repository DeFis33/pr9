//***************************************************************
//* Практическая работа № 9                                     *
//* Выполнил: Пирогов Д., группа 2ИСП                           *
//* Задание: составить программу обработки одномерных массивов  *
//***************************************************************

using System;

namespace pr9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Практическая работа №9.\nЗдравствуйте!");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nХотите ли вы запустить программу? (Да/Нет):");
                    string a = Console.ReadLine();

                    if (a == "Нет")
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да")
                    {
                        int[] Mas = new int[15];
                        int sum = 0, product = 0;
                        bool f = false;

                        for (int i = 0; i < Mas.Length; i++)
                        {
                            try
                            {
                                Console.Write($"Введите элемент массива [{i}]: ");
                                Mas[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException fe)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\nОшибка ввода элемента массива. Введите целое число. \n" + fe.Message);
                                Console.ForegroundColor = ConsoleColor.White;
                                i--;
                            }
                        }

                        for (int i = 0; i < Mas.Length; i++)
                        {
                            if (Mas[i] % 2 != 0 && Mas[i] % 3 == 0)
                            {
                                sum += Mas[i];

                                if (!f)
                                {
                                    f = true;
                                    product = Mas[i];
                                }
                                else product *= Mas[i];
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nСумма нечетных элементов, кратных 3: {sum}");
                        Console.WriteLine($"Произведение нечетных элементов, кратных 3: {product}");
                        Console.ForegroundColor = ConsoleColor.White;

                        int max = 0, min = 0, max1 = Mas[0], min1 = Mas[0];

                        for (int i = 1; i < Mas.Length; i++)
                        {
                            if (Mas[i] % 2 != 0 && Mas[i] % 3 != 0)
                            {
                                if (Mas[i] > max1)
                                {
                                    max1 = Mas[i];
                                    max = i;
                                }

                                if (Mas[i] < min1)
                                {
                                    min1 = Mas[i];
                                    min = i;
                                }
                            }
                        }

                        Mas[max] = sum;
                        Mas[min] = product;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nИзмененный массив:");
                        for (int i = 0; i < Mas.Length; i++)
                        {
                            Console.WriteLine($"Элемент массива [{i}]: {Mas[i]}");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
                catch (FormatException fe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + fe.Message, ConsoleColor.Red);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
