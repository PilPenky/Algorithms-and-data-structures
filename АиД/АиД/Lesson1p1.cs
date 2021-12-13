using System;
using System.Collections.Generic;
using System.Text;

namespace АиД
{
    class Lesson1p1
    {
        public Lesson1p1()
        {
            Console.WriteLine("Вычисление простого и не простого числа.\n");
            int number;
            int d = 0;
            int i = 2;
            Console.WriteLine("Введите значение:");
            number = int.Parse(Console.ReadLine());
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    i++;
                }
                if (number % i != 0)
                {
                    i++;
                }
            }
            if (d == 0)
            {
                Console.WriteLine("Это простое число.");
            }
            if (d != 0)
            {
                Console.WriteLine("Это не простое число.");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Нажмите 'Enter' для возврата в главное меню.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
