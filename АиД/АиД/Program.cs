using System;
using System.Threading;

namespace АиД
{
    class Program
    {
        static void Main(string[] args)
        {
            string Loading = "Идет загрузка приложения. Пожалуйста, подождите..... ";
            string ProgressBar = "";
            Console.WriteLine(Loading);
            int Counter = 20;
            while (Counter >= 0)
            {
                Console.Write("[{0}", ProgressBar);
                Console.SetCursorPosition(20 + 1, 1);
                Console.Write("] {0}%", 100 - Counter * 5);
                Console.SetCursorPosition(0, 1);
                ProgressBar += "|";
                Thread.Sleep(40);
                Counter--;
            }
            Console.SetCursorPosition(Loading.Length, 0);
            Console.WriteLine("Загрузка завершена.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Нажмите 'Enter' для запуска приложения.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Домашние задания по курсу 'Алгоритмы и структуры данных'.");
            Console.WriteLine();
            bool toExit = true;
            while (toExit)
            {
                Console.WriteLine("Введите номер задания, решение которого хотите просмотреть.");
                Console.WriteLine("Для выхода из приложения введите 'ext'.\n\n");
                Console.WriteLine("Урок № 1 'Блок-схемы, асимптотическая сложность, рекурсия':\n");
                Console.WriteLine("Задание 1.1  - Реализовать функцию согласно указанной блок-схеме в методической документации. Вычисление простого и не простого числа.");
                Console.WriteLine("Задание 1.2  - Вычислить асимптотическую сложность функции из примера в методической документации.");
                Console.WriteLine("Задание 1.3  - Реализовать функцию вычисления числа Фибоначчи через рекурсию.");
                Console.WriteLine("Задание 1.4  - Реализовать функцию вычисления числа Фибоначчи через цикл.");
                //Console.WriteLine("Урок № 2 'Массив, список, поиск':\n");

                Console.WriteLine();
                Console.Write("Введите номер задания: ");
                string lessonNumber = Console.ReadLine();
                Console.WriteLine("---------------");
                Console.Clear();


                switch (lessonNumber)
                {
                    case "1.1":
                        Lesson1p1 l1p1 = new Lesson1p1();
                        break;
                    case "1.2":
                        Lesson1p2 l1p2 = new Lesson1p2();
                        break;
                    case "1.3":
                        Lesson1p3 l1p3 = new Lesson1p3();
                        break;
                    case "1.4":
                        Lesson1p4 l1p4 = new Lesson1p4();
                        break;
                    //case "2":
                    //    Lesson4 l4 = new Lesson4();
                    //    break;
                    case "ext":
                        toExit = false;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильный номер урока. Пожалуйста, либо введите номер урока, либо введите «exit», чтобы выйти.");
                        Console.WriteLine("Нажмите 'Enter', чтобы продолжить работу.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            Console.WriteLine("Всего хорошего. Нажмите 'Enter', чтобы закрыть приложение.");
            Console.ReadLine();
            Console.Clear();
            


        }
    }
}
