using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;
            {
                Console.Write("Приветствую. Введите своё имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите даду вашего рождения. ");
            restart1:
                Console.Write("Год: ");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year > 2020)
                {
                    Console.Write("Некорректно введен год! ");
                    goto restart1;
                }
            restart2:
                Console.Write("Месяц (цифра): ");
                int month = Convert.ToInt32(Console.ReadLine());
                if (month > 12)
                {
                    Console.Write("Некорректно введен месяц! ");
                    goto restart2;
                }
                i = year;
            restart3:
                Console.Write("День: ");
                int day = Convert.ToInt32(Console.ReadLine());
                if (month == 1 | month == 3 | month == 5 | month == 7 | month == 8 | month == 10 | month == 12)
                {
                    if (day > 31 | day <= 0)
                    {
                        Console.Write("Некорректно введен день! ");
                        goto restart3;
                    }
                }
                if (month == 4 | month == 6 | month == 9 | month == 11)
                {
                    if (day > 30 | day <= 0)
                    {
                        Console.Write("Некорректно введен день! ");
                        goto restart3;
                    } 
                }
                if (i % 4 == 0 & month == 2)
                {
                    if (day <= 0 | day > 29)
                    {
                        Console.Write("Некорректно введен день! ");
                        goto restart3;
                    }
                }
                if (i % 4 > 0 & month == 2)
                {
                    if (day <= 0 | day > 28)
                    {
                        Console.Write("Некорректно введен день! ");
                        goto restart3;
                    }
                }
                Console.WriteLine($"Приветстую,  {name }. Ваша дата рождения {day}.{month}.{year}");
                Console.ReadKey();
            }
        }
    }
}
