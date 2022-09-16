using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1  Что-то про имя");
            Console.WriteLine("Как тебя зовут, незнакомец?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.ReadKey();


            Console.WriteLine("Упражнение 2.2   Деление чисел");
            Console.Write("Введите первое число(делитель): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число(делимое): ");
            double b = double.Parse(Console.ReadLine());
            if (b == 0)
            {

               Console.WriteLine("Упс, ты попутал и поделил на 0");
            }
            else 
            {
                double c = (double)  a / b; 
                Console.WriteLine($"Ответ:{c}");
            }
            Console.ReadKey();


            Console.WriteLine("Домашнее задание 2.3. Алфавит");
            Console.Write("Введите букву: ");
            char letter = Char.Parse(Console.ReadLine());
            if (letter == 'z' || letter == 'я')
            {
                Console.WriteLine($"За буквой {letter} , следует буква a ");
            }
            else
            {
                Console.WriteLine($"За буквой {letter} , следует буква {letter++} ");
            }
            Console.ReadKey();


            Console.WriteLine("Упражнение 2.4   Решение квадратных уравнений");
            Console.Write("Введите первый коэффицента a: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второй коэффицента b: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Введите третий коэффицента c: ");
            double c1 = double.Parse(Console.ReadLine());
            double D = Math.Pow(b1, 2) - 4*a1*c1;
            if (D >= 0)
            {
                double d = Math.Sqrt(D);
                if (d == 0)
                {
                    double x = -1 * b1  / 2 * a1;
                    Console.WriteLine($"Корень уравнения один и равен x = {x}");
                }
                else { 
                double x1 = (-1 * b1 - d) / 2 * a1;
                double x2 = (-1 * b1 + d) / 2 * a1;
                Console.WriteLine($"Первый корень x1 = {x1}");
                Console.WriteLine($"Второй корень x2 = {x2}");
                }
            }
            else
            {
                Console.WriteLine("D<0 к сожалению программа не может такое решить");
            }
            Console.ReadKey();

        }
    }
}
