using System;
using System.Collections.Generic;
using System.Text;

namespace АиД
{
    class Lesson1p4
    {
        public Lesson1p4()
        {
            Console.WriteLine("Реализация функции вычисления числа Фибоначчи через цикл.");
            Console.WriteLine("Введите значение, определяющее количество элементов формируемой последовательности числа Фибоначчи:");
            static int Fibonachi(int n)
            {
                int result = 0;
                int b = 1;
                int tmp;

                for (int i = 0; i < n; i++)
                {
                    tmp = result;
                    result = b;
                    b += tmp;
                }

                return result;
            }
            int fib = Fibonachi(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Число Фибоначчи составляет {fib}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Нажмите 'Enter' для возврата в главное меню.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
