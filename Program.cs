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
                    int[] Mas = new int[15];
                    int sum = 0, product = 1, max = 0, min = 0;
                    bool NotEmpty = false;

                    Console.WriteLine("\nХотите ли вы запустить программу? (Да/Нет):");
                    string a = Console.ReadLine();

                    if (a == "Нет")
                    {
                        Console.WriteLine("Программа завершена.\nДо свидания!");
                        break;
                    }
                    else if (a == "Да")
                    {
                        for (int i = 0; i < Mas.Length; i++)
                        {
                            Console.Write($"Элемент [{i + 1}]: ");
                            try
                            {
                                Mas[i] = Int32.Parse(Console.ReadLine());

                                if (Mas[i] % 2 != 0 && Mas[i] % 3 == 0)
                                {
                                    sum += Mas[i];
                                    product *= Mas[i];
                                    NotEmpty = true;
                                }
                            }
                            catch (IndexOutOfRangeException ore)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\nОшибка ввода \n" + ore.Message);
                                Console.ForegroundColor = ConsoleColor.White;
                                i--;
                            }
                        }
                        for (int i = 0; i < Mas.Length; i++)
                        {
                            if (Mas[i] > Mas[max]) max = i;
                            if (Mas[i] < Mas[min]) min = i;
                        }
                        Mas[max] = sum;
                        Mas[min] = product;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Введите Да или Нет! (Ввод ответа требуется с большой буквы)");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    if (NotEmpty)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"\nИсходная сумма: {sum}");
                        Console.WriteLine($"Исходное произведение: {product}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nИсходный массив: " + String.Join(", ", Mas));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else Console.WriteLine("Условие не было выполнено.");
                }
                catch (FormatException fe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nОшибка ввода \n" + fe.Message);
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
