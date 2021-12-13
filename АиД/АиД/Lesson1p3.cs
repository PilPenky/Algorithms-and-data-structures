using System;
using System.Collections.Generic;
using System.Text;

namespace АиД
{
    class Lesson1p3
    {
        public Lesson1p3()
        {
            Console.WriteLine("Реализация функции вычисления числа Фибоначчи через рекурсию.");
            Console.WriteLine("Введите значение, определяющее количество элементов формируемой последовательности числа Фибоначчи:");
            int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
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

