using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0210
{
    internal class Program
    {
        public class Date
        {
            public int day; public int month; public int year;

            public Date(int day, int month, int year)
            {
                if (year > 0 && month > 0 && day > 0)
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
            }

            public Date(Date date)
            {
                this.day = date.day;
                this.month = date.month;
                this.year = date.year;
            }

            public int Next()
            {
                day += 1;

                if (day > 31)
                {
                    day = 1;
                    month += 1;
                }
                if (month > 12)
                {
                    month = 1;
                    year += 1;
                }

                Console.WriteLine($"{day}.{month}.{year}");

                return day;
            }
            public int Prev()
            {
                day -= 1;

                if (day < 1)
                {
                    day = 31;
                    month -= 1;
                }
                if (month < 1)
                {
                    month = 12;
                    year -= 1;
                }

                Console.WriteLine($"{day}.{month}.{year}");

                return day;
            }

            public void IsLeapLear()
            {
                if (year % 4 == 0)
                    Console.WriteLine($"{year}-й год является високосным.");
                else
                    Console.WriteLine($"{year}-й год не является високосным.");
            }

            public void Minus(int xDays)
            {
                Console.WriteLine($"Предыдущие {xDays} дней: ");

                for (int i = 1; i <= xDays; i++)
                {
                    if (day - i < 1)
                    {
                        Console.Write($"{day - i + 31}; ");
                    }
                    else
                    {
                        Console.Write($"{day - i}; ");
                    }
                }

                Console.WriteLine();
            }

            public void Plus(int xDays)
            {
                Console.WriteLine($"Следующие {xDays} дней: ");

                for (int i = 1; i <= xDays; i++)
                {
                    if (day + i > 31)
                    {
                        Console.Write($"{day + i - 31}; ");
                    }
                    else
                    {
                        Console.Write($"{day + i}; ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Date date1 = new(3, 4, 2006);

            date1.Plus(5);

            date1.Minus(5);

            date1.Next();
            date1.Next();
            date1.Next();

            date1.Prev();
            date1.Prev();

            date1.IsLeapLear();

            Date date2 = new(date1);

            date2.Prev();

            Console.ReadLine();
        }
    }
}
}
