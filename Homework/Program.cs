using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Вывести e");
            string e = "2,7";
            Console.WriteLine($"Число e = {e}");  
            Console.ReadKey();


            Console.WriteLine("Задание 2. Чиселки 50 и 10"); 
            Console.WriteLine(50);
            Console.WriteLine(10);
            Console.ReadKey();


            Console.WriteLine("Задание 3. Любимые числа"); 
            Console.WriteLine(13);
            Console.WriteLine(17);
            Console.WriteLine(69);
            Console.WriteLine(113);
            Console.ReadKey();


            Console.WriteLine("Задание 4. Увеличение числа на 10");
            Console.Write("Введите любое число:");
            double num1 = double.Parse(Console.ReadLine());
            double sum1 = num1 + 10;
            Console.WriteLine($"Число увеличенное на 10 = {sum1}");
            Console.ReadKey();


            Console.WriteLine("Задание 5. Квадрат");
            Console.Write("Введите размер стороны квадрата:");
            double a = double.Parse(Console.ReadLine());
            double P = a * 4;
            Console.WriteLine($"Периметр квадрата = {P}");
            Console.ReadKey();


            Console.WriteLine("Задание 6. Круг");
            Console.Write("Введите радиус круга:");
            double r = double.Parse(Console.ReadLine());
            double pi = double.Parse("3,14");
            double S = pi * Math.Pow(r,2);
            double l = pi * 2 * r;
            Console.WriteLine($"Площадь круга = {S}");
            Console.WriteLine($"Длина окружности = {l}");
            Console.ReadKey();


            Console.WriteLine("Задание 7. Функция нахождения косинуса");
            Console.Write("Введите угол(в радианах):");
            double x = double.Parse(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine($"Косинус угла = {y}");
            Console.ReadKey();


            Console.WriteLine("Задание 8. Равнобедренная трапеция");
            Console.Write("Введите большее основание трапеции:");
            double osn1 = double.Parse(Console.ReadLine());
            Console.Write("Введите меньшее основание трапеции:");
            double osn2 = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту трапеции:");
            double h = double.Parse(Console.ReadLine());
            double cos1 = Math.Cos(1/2);
            double st = h / cos1;    
            double P1 = st * 2 + osn1 + osn2;
            Console.WriteLine($"Периметр трапеции = {P1}");
            Console.ReadKey();


            Console.WriteLine("Задание 9. Магазин");
            Console.WriteLine("Цены в магазине(за кг) конфеты: 80руб, печенье: 50руб, яблоки: 35руб");
            Console.Write("Сколько хотите купить конфет(кг):");
            double sweet = double.Parse(Console.ReadLine());
            Console.Write("Сколько хотите купить печеньев(кг):");
            double cookie = double.Parse(Console.ReadLine());
            Console.Write("Сколько хотите купить яблок(кг):");
            double apple = double.Parse(Console.ReadLine());
            double sum8 = sweet * 80 + cookie * 50 + apple * 35;
            Console.WriteLine($"Cумма покупки = {sum8}руб");
            Console.ReadKey();


            Console.WriteLine("Задание 10. Мир Труд Май");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("{0,10}", "Труд");
            Console.WriteLine("{0,17}", "Май");
            Console.ReadKey();


            Console.WriteLine("Задание 11. Числа меняющиеся местами");
            Console.Write("Введите первое число:");
            string number1 = Console.ReadLine();
            Console.Write("Введите второе число:");
            string number2 = Console.ReadLine();
            Console.ReadLine().Replace(".", ",");
            double parsnumber1, parsnumber2;
            bool rezult1 = double.TryParse(number1, out parsnumber1);
            bool rezult2 = double.TryParse(number2, out parsnumber2);
            if (rezult1 || rezult2)
            {
                Console.WriteLine($"{parsnumber2} {parsnumber1}");
            }
            else
            {
                Console.WriteLine("Ошибка в наборе данных");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 12. Вычесление площади или периметра у фигуры");
            Console.Write("Выберете фигуру(треугольник - 1, четырехугольник - 2 или круг - 3):");
            int figure = int.Parse(Console.ReadLine());
            Console.Write("Искать площадь - 1 или периметр - 2?:");
            int X12 = int.Parse(Console.ReadLine());
            if (figure == 1)
            {
                if (X12 == 2)
                {
                    Console.Write("Введите первую сторну четырехугольника:");
                    int a12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите вторую сторну четырехугольника:");
                    int b12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите третью сторну четырехугольника:");
                    int c12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите четвертую сторну четырехугольника:");
                    int d12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите радиус круга:");
                    int r12 = int.Parse(Console.ReadLine());
                    int pp12 = a12 + b12 + c12 + d12;
                    int pc12 = d12 * 2 * 3;
                    Console.WriteLine($"Периметр четырехугольника = {pp12}");
                    Console.WriteLine($"Периметр круга = {pc12}");
                }
                else
                {
                    Console.Write("Введите первую диагональ четырехугольника:");
                    int a12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите вторую диагональ четырехугольника:");
                    int b12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите угол между диагоналями:");
                    int c12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите радиус круга:");
                    int r12 = int.Parse(Console.ReadLine());
                    double sp12 = (double)1 / 2 * a12 * b12 * Math.Sin(c12);
                    int sc12 = 3 * r12 * r12;
                    Console.WriteLine($"Площадь четырехугольника = {sp12}");
                    Console.WriteLine($"Площадь круга = {sc12}");
                }
            }
            if (figure == 2)
            {
                if (X12 == 2)
                {
                    Console.Write("Введите первую сторну треугольника:");
                    int a12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите вторую сторну треугольника:");
                    int b12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите третью сторну треугольника:");
                    int c12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите :");
                    int r12 = int.Parse(Console.ReadLine());
                    int pt12 = a12 + b12 + c12;
                    int pc12 = r12 * 2 * 3;
                    Console.WriteLine($"Периметр треугольника = {pt12}");
                    Console.WriteLine($"Периметр круга = {pc12}");
                }
                else
                {
                    Console.Write("Введите основание треугольника:");
                    int a12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите высоту треугольника:");
                    int b12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите радиус круга:");
                    int r12 = int.Parse(Console.ReadLine());
                    double st12 = (double)a12 * b12 / 2;
                    int sc12 = 3 * r12 * r12;
                    Console.WriteLine($"Площадь треугольника = {st12}");
                    Console.WriteLine($"Площадь круга = {sc12}");
                }
            }


            if (figure == 3)
            {
                if (X12 == 2)
                {
                    Console.Write("Введите первую сторну треугольника:");
                    int a12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите вторую сторну треугольника:");
                    int b12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите третью сторну треугольника:");
                    int c12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите первую сторну четырехугольника:");
                    int d12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите вторую сторну четырехугольника:");
                    int e12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите третью сторну четырехугольника:");
                    int g12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите четвертую сторну четырехугольника:");
                    int h12 = int.Parse(Console.ReadLine());
                    int pt12 = a12 + b12 + c12;
                    int pp12 = d12 + e12 + g12 + h12;
                    Console.WriteLine($"Периметр треугольника = {pt12}");
                    Console.WriteLine($"Периметр четырехугольника = {pp12}");
                }
                else
                {
                    Console.Write("Введите основание треугольника:");
                    int a12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите высоту треугольника:");
                    int b12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите первую диагональ четырехугольника:");
                    int c12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите вторую диагональ четырехугольника:");
                    int d12 = int.Parse(Console.ReadLine());
                    Console.Write("Введите угол между диагоналями:");
                    int e12 = int.Parse(Console.ReadLine());
                    double st12 = (double)a12 * b12 / 2;
                    double sp12 = (double)1 / 2 * c12 * d12 * Math.Sin(e12);
                    Console.WriteLine($"Площадь треугольника = {st12}");
                    Console.WriteLine($"Площадь четырехугольника = {sp12}");
                }
            }
            Console.ReadKey();


            Console.WriteLine("Задание 13. Вывод числа");
            Console.Write("Введите число: ");
            double number13 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {number13}");
            Console.ReadKey();


            Console.WriteLine("Задание 14. Вывод инфы на экран");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            Console.ReadKey();


            Console.WriteLine("Задание 15. Вывод рандомных чисел на экран");
            Random random = new Random();

            int value = random.Next();  
            int value1 = random.Next(); 
            int value2 = random.Next(); 
            int value3 = random.Next(); 

            Console.WriteLine(value);  
            Console.WriteLine(value1); 
            Console.WriteLine(value2); 
            Console.WriteLine(value3); 
            Console.ReadKey();



            Console.WriteLine("Упражнение 16   Решение квадратных уравнений");
            Console.Write("Введите первый коэффицента a: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второй коэффицента b: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Введите третий коэффицента c: ");
            double c1 = double.Parse(Console.ReadLine());
            double D = Math.Pow(b1, 2) - 4 * a1 * c1;
            if (D >= 0)
            {
                double d = Math.Sqrt(D);
                if (d == 0)
                {
                    double X = -1 * b1 / 2 * a1;
                    Console.WriteLine($"Корень уравнения один и равен x = {X}");
                }
                else
                {
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


            Console.WriteLine("Задание 17. Cреднее арифметическое и геометрическое ");
            Console.Write("Введите первое челочисленное число: ");
            int a17 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе челочисленное число: ");
            int b17 = int.Parse(Console.ReadLine());
            double Arif = (double)(a17 + b17) / 2;
            double Geom = (double)Math.Sqrt(a17 * b17);
            Console.WriteLine($"Среднее арифметическое: {Arif}");
            Console.WriteLine($"Среднее геометрическое: {Geom}");
            Console.ReadKey();


            Console.WriteLine("Задание 18. Координаты");
            Console.Write("Введите координату x первой точки: ");
            double x18 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y первой точки: ");
            double y18 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату x второй точки: ");
            double X18 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y второй точки: ");
            double Y18 = double.Parse(Console.ReadLine());
            double Lx18 = X18 - x18;
            double Ly18 = Y18 - y18;
            double L18 = Math.Sqrt(Lx18 * Lx18 + Ly18 * Ly18);
            Console.WriteLine($"Расстояние между точками = {L18}");
            Console.ReadKey();


            Console.WriteLine("Задание 19. Обмен величин");
            Console.Write("Введите величину a: ");
            double a19 = double.Parse(Console.ReadLine());
            Console.Write("Введите величину b: ");
            double b19 = double.Parse(Console.ReadLine());
            Console.Write("Введите величину c: ");
            double c19 = double.Parse(Console.ReadLine());
            double d19 = c19;
            c19 = a19; //
            a19 = b19;
            b19 = d19;
            Console.WriteLine($"a)Значение а = {a19}, значение b = {d19}, значение c = {c19}");
            b19 = c19;
            c19 = a19;
            a19 = d19;
            Console.WriteLine($"б)Значение а = {d19}, значение b = {b19}, значение c = {c19}");
            Console.ReadKey();


            Console.WriteLine("Задание 20. Время");
            Console.Write("Введите сколько секунд прошло с начало суток: ");
            int time = int.Parse(Console.ReadLine());
            int hour = time / 3600;
            int minute = (time % 3600) / 60;
            int second = (time % 3600) % 60;
            Console.WriteLine($"Прошло {hour}ч с начала суток, {minute}мин с начала часа, {second}cек с начала минуты");
            Console.ReadKey();


            Console.WriteLine("Задание 21. Cколько квадратов со стороной 130мм можно отрезать от прямоугольника 543мм x 130мм");
            int Sq = 130 * 130;
            int Sp = 543 * 130;
            int rezult21 = Sp / Sq;
            Console.WriteLine($"В прямоугольника 543мм x 130мм помещяется {rezult21} квадрата со стороной 130мм");
            Console.ReadKey();


            Console.WriteLine("Задание 22. Последнюю цифру переставляем вперед");
            Console.Write("Введите трехзначное число: ");
            string number22 = Console.ReadLine();
            char three22 = number22[2];
            char two22 = number22[0];
            char one22 = number22[1];
            Console.Write(three22 + "" + two22 + "" + one22);
            Console.ReadKey();


            Console.WriteLine("Задание 23. Нахождение сотен и тысяч в числе");
            Console.Write("Введите число > 999: ");
            int number23 = int.Parse(Console.ReadLine());
            int thous23 = number23 / 1000;
            int hund23 = (number23 % 1000) / 100;
            Console.Write($"В данном числе {thous23} тысяч и {hund23} сотен");
            Console.ReadKey();


            Console.WriteLine("Задание 24. Манипуляции с числами");
            Console.Write("Введите четырехзначное число: ");
            string number24 = Console.ReadLine();
            char four24 = number24[3];
            char three24 = number24[2];
            char two24 = number24[1];
            char one24 = number24[0];
            Console.WriteLine(four24 + "" + three24 + "" + two24 + "" + one24);
            char four24b = number24[1];
            char three24b = number24[0];
            char two24b = number24[3];
            char one24b = number24[2];
            int four24bb = Convert.ToInt32(new string (four24b, 1));
            if (four24bb == 0)
            {
                Console.WriteLine(three24b + "" + two24b + "" + one24b);
            }
            else
            {
                Console.WriteLine(four24b + "" + three24b + "" + two24b + "" + one24b); 
            }
            char four24c = number24[0];
            char three24c = number24[2];
            char two24c = number24[1];
            char one24c = number24[3];
            Console.WriteLine(four24c + "" + three24c + "" + two24c + "" + one24c);
            char four24d = number24[2];
            char three24d = number24[3];
            char two24d = number24[0];
            char one24d = number24[1];
            int four24dd = Convert.ToInt32(new string(four24d, 1));
            if (four24dd == 0)
            {
                Console.WriteLine(three24d + "" + two24d + "" + one24d);
            }
            else
            {
                Console.WriteLine(four24d + "" + three24d + "" + two24d + "" + one24d);
            }
            Console.ReadKey();


            Console.WriteLine("Задание 25. Что-то с числом");
            Console.Write("Введите число 100 <= n =< 999: ");
            string number25 = Console.ReadLine();
            if ((int.Parse(number25) / 10) % 10 == 0)
            {
                Console.WriteLine("Введите другое число");
            }
            else
            {
                Console.WriteLine("Число x = " + number25[1] + number25[2] + number25[0]); 
            }
            Console.ReadKey();

           

            Console.WriteLine("Задание 28. Большее число по модулю");
            Console.Write("Введите первое число: ");
            double a28 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b28 = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c28 = double.Parse(Console.ReadLine());
            double A28 = Math.Abs(a28);
            double B28 = Math.Abs(b28);
            double C28 = Math.Abs(c28);
            if (A28 < B28)
            {
                if (A28 > C28)
                {
                    Console.WriteLine($"Самое меньшее число по модулю = {c28}");
                }
                else
                {
                    Console.WriteLine($"Самое большое число по модулю = {a28}");
                }
            }
            else
            {
                if (B28 > C28)
                {
                    Console.WriteLine($"Самое меньшее число по модулю = {c28}");
                }
                else
                {
                    Console.WriteLine($"Самое большое число по модулю = {b28}");
                }

            }
            Console.ReadKey();


            Console.WriteLine("Задание 29. Большее и меньшее число");
            Console.Write("Введите первое число: ");
            double a29 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b29 = double.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c29 = double.Parse(Console.ReadLine());
            if (a29 < b29)
            {
                if (a29 > c29)
                {
                    Console.WriteLine($"Самое меньшее число = {c29}");
                    Console.WriteLine($"Самое большее число = {b29}");
                }
                else
                {
                    if (b29 > c29)
                    {
                        Console.WriteLine($"Самое меньшее число = {a29}");
                        Console.WriteLine($"Самое большее число = {b29}");
                    }
                    else
                    {
                        Console.WriteLine($"Самое меньшее число = {a29}");
                        Console.WriteLine($"Самое большее число = {c29}");
                    }
                }
            }
            else
            {
                if (b29 > c29)
                {
                    Console.WriteLine($"Самое меньшее число = {c29}");
                    Console.WriteLine($"Самое большее число = {a29}");
                }
                else
                {
                    if (a29 > c29)
                    {
                        Console.WriteLine($"Самое меньшее число = {b29}");
                        Console.WriteLine($"Самое большее число = {a29}");
                    }
                    else
                    {
                        Console.WriteLine($"Самое меньшее число = {b29}");
                        Console.WriteLine($"Самое большее число = {c29}");
                    }
                }

            }
            Console.ReadKey();


            Console.WriteLine("Задание 30. Кол-во делителей");
            Console.Write("Введите натуральное число: ");
            int n30 = int.Parse(Console.ReadLine());
            int j30 = 0;
            for (int i = 1; i < n30 + 1; i++)
            {
                if (n30 % i == 0)
                {
                    j30++;
                }
            }
            Console.WriteLine($"У данного числа {j30} делителей ");
            Console.ReadKey();


            Console.WriteLine("Задание 31. Уравнение");
            Console.Write("Введите а ");
            double a31 = double.Parse(Console.ReadLine());
            Console.Write("Введите b ");
            double b31 = double.Parse(Console.ReadLine());
            Console.Write("Введите c ");
            double c31 = double.Parse(Console.ReadLine());
            Console.Write("Введите d ");
            double d31 = double.Parse(Console.ReadLine());
            for (int x31 = -100; x31 == 100; x31++)
            {
                if (a31 * Math.Pow(x31,3) + b31 * x31 * x31 + c31 * x31 + d31 == 0)
                {
                    Console.Write($"Корень уравнения = {x31}" );
                    Console.WriteLine();
                }
            }


            Console.WriteLine("Задание 32. Арифметическая прогессия");
            Console.Write("Введите первый член арифметической прогрессии: ");
            int a32 = int.Parse(Console.ReadLine());
            Console.Write("Введите второй член арифметической прогрессии: ");
            int b32 = int.Parse(Console.ReadLine());
            Console.Write("Номер какого члена прогрессии хотите найти: ");
            int с32 = int.Parse(Console.ReadLine());
            int d32 = b32 - a32;
            int an32 = a32 + (с32 - 1) * d32;
            Console.WriteLine($"{с32} член арифметической прогрессии = {an32}");
            Console.ReadKey();


            Console.WriteLine("Задание 33. Кобала(кредит)");
            Console.Write("Вы студент или пенсионер?(0- я студент/ 1- я пенсионер/ 2- и пенсионер и студент): ");
            int stat33 = int.Parse(Console.ReadLine());
            Console.Write("Вы трудоустроены?(0 - да/ 1 - нет): ");
            int job33 = int.Parse(Console.ReadLine());
            if (stat33 == 2)
            {
                Console.WriteLine("Кредит не оформлен");
            }
            else
            {
                if (stat33 == 0)
                {
                    if (job33 == 0)
                    {
                        Console.WriteLine("Кредит не оформлен");
                    }
                    else
                    {
                        Console.WriteLine("Кредит оформлен");
                    }
                }
                else
                {
                    if (job33 == 0)
                    {
                        Console.WriteLine("Кредит не оформлен");
                    }
                    else
                    {
                        Console.WriteLine("Кредит оформлен");
                    }
                }
            }
            Console.ReadKey();


            Console.WriteLine("Задание 34. Вывод имени");
            Console.Write("Введите свое имя: ");
            string name34 = Console.ReadLine();
            Console.WriteLine($"a) {name34}");
            Console.WriteLine($"б) Добрый день, {name34}");
            Console.ReadKey();


            Console.WriteLine("Задание 35. Диалог Тома Реддла и Гарри Поттер");
            Console.WriteLine("Добрый день");
            string d1 = Console.ReadLine();
            Console.WriteLine("Как вас зовут?");
            string d2 = Console.ReadLine();
            Console.WriteLine($"Привет, {d2}");
            string d3 = Console.ReadLine();
            Console.WriteLine("Да");
            string d4 = Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Random color = new Random();
            int c = color.Next(1, 15);
            Console.WriteLine(c);
            ConsoleColor color1 = (ConsoleColor)c;
            Console.BackgroundColor = color1;
            Console.Clear();
            Console.ReadKey();


            Console.WriteLine("Задание 36. Штрих код ");
            Random random36 = new Random();
            int ran1 = random36.Next(10);
            int ran2 = random36.Next(10);
            int ran3 = random36.Next(10);
            int ran4 = random36.Next(10);
            int ran5 = random36.Next(10);
            int ran6 = random36.Next(10);
            int ran7 = random36.Next(10);
            int ran8 = random36.Next(10);
            int ran9 = random36.Next(10);
            int ran10 = random36.Next(10);
            int ran11 = random36.Next(10);
            int ran12 = random36.Next(10);
            int n1 = ran2 + ran4 + ran6 + ran8 + ran10 + ran12;
            int n2 = n1 * 3;
            int n3 = ran1 + ran3 + ran5 + ran7 + ran9 + ran11;
            int n4 = n2 + n3;
            int n5 = n4 % 10;
            int n6 = 10 - n5;
            Console.WriteLine($"Контрольная цифра штрих кода = {n6}");
            Console.Write("Введите перовое число штрих кода: ");
            int numb1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число штрих кода: ");
            int numb2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число штрих кода: ");
            int numb3 = int.Parse(Console.ReadLine());
            Console.Write("Введите четвертое число штрих кода: ");
            int numb4 = int.Parse(Console.ReadLine());
            Console.Write("Введите пятое число штрих кода: ");
            int numb5 = int.Parse(Console.ReadLine());
            Console.Write("Введите шестое число штрих кода: ");
            int numb6 = int.Parse(Console.ReadLine());
            Console.Write("Введите седьмое число штрих кода: ");
            int numb7 = int.Parse(Console.ReadLine());
            Console.Write("Введите восьмое число штрих кода: ");
            int numb8 = int.Parse(Console.ReadLine());
            Console.Write("Введите девятое число штрих кода: ");
            int numb9 = int.Parse(Console.ReadLine());
            Console.Write("Введите десятое число штрих кода: ");
            int numb10 = int.Parse(Console.ReadLine());
            Console.Write("Введите одинадцатое число штрих кода: ");
            int numb11 = int.Parse(Console.ReadLine());
            Console.Write("Введите двенадцатое число штрих кода: ");
            int numb12 = int.Parse(Console.ReadLine());
            int n7 = numb2 + numb4 + numb6 + numb8 + numb10 + numb12;
            int n8 = n7 * 3;
            int n9 = numb1 + numb3 + numb5 + numb7 + numb9 + numb11;
            int n10 = n8 + n9;
            int n11 = n10 % 10;
            int n12 = 10 - n11;
            Console.WriteLine($"Контрольная цифра штрих кода = {n12}");

            Console.ReadKey();

        }
    }
    }

