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
                    Console.WriteLine("\nХотите ли вы бы запустить программу? (Да/Нет):");
                    string a = Console.ReadLine();
                    int i = 0, m = 15;
                    int[] Mas = new int[m];
                    bool err;

                    if (a == "Нет")
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да")
                    {
                        while (i < m)
                        {
                            err = false; // ошибки нет
                            Console.Write("Введите " + i + " элемент массива: ");
                            try
                            {
                                Mas[i] = Convert.ToInt32(Console.ReadLine()); // запись числа в текущий элемент массива
                            }
                            catch (FormatException e) // обработка исключения
                            {
                                err = true; // ошибка ввода
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Возникла ошибка: " + e.Message);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (!err) i++; // если ошибки нет, то переход к следующему элементу массива
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
                catch (FormatException e) // частное исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e) // общее исключение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + e.Message); // вывод ошибки на экран
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}