using System;

namespace ConsoleApp1
{

    class Program
    {
        static bool TryParse(string input, out int number)
        {
            number = 0;

            // Проверка на пустой ввод
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Прочитайте условие еще раз и попробуйте ввести снова ;)");
                return false;
            }

            // Попытка преобразовать строку в число
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Прочитайте условие еще раз и попробуйте ввести снова ;)");
                return false;
            }

            // Проверка на наличие лишних символов
            if (input != number.ToString())
            {
                Console.WriteLine("Прочитайте условие еще раз и попробуйте ввести снова ;)");
                return false;
            }

            return true;
        }
        static long factnechet(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * factnechet(n - 2);
        }
        static long factchet(int n)
        {
            int fact = 1;
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            else
            {
                if (n % 2 != 0) n = n-1;
                for(int i = n; i != 0; i-=2)
                {
                    fact *= i;
                }
                return fact;
            }
                
        }
        static void Main(string[] args)
        {
            int zadanie = 1;
            while (!(zadanie == 0))
            {
                Console.Write("какое задание хотите включить?: ");
                zadanie = Convert.ToInt32(Console.ReadLine());
                if (zadanie == 1)
                {
                    string number;
                    do
                    {
                        Console.Write("Введите целое число в диапазоне 100-999: ");
                        number = Console.ReadLine();
                        if ((number.Length > 3 || number.Length < 3))
                        {
                            Console.Write("Прочитайте условие еще раз и попробуйте ввести снова ;)\r\n");
                        }
                    }
                    while ((number.Length > 3 || number.Length < 3));
                    int i = 0;

                    while (!(i == 3))
                    {
                        switch (number[i])
                        {
                            case '0':
                                break;

                            case '1':
                                if (i == 0)
                                    Console.Write("сто ");
                                if (i == 2)
                                    Console.Write("один ");
                                if (number[2] == '0' && number[1] == '1')
                                {
                                    Console.Write("десять ");
                                    i = 2;
                                }
                                if (number[2] == '1' && number[1] == '1')
                                {
                                    Console.Write("одинадцать ");
                                    i = 2;
                                }
                                if (number[2] == '2' && number[1] == '1')
                                {
                                    Console.Write("двенадцать ");
                                    i = 2;
                                }
                                if (number[2] == '3' && number[1] == '1')
                                {
                                    Console.Write("тринадцать ");
                                    i = 2;
                                }
                                if (number[2] == '4' && number[1] == '1')
                                {
                                    Console.Write("четырнадцать ");
                                    i = 2;
                                }
                                if (number[2] == '5' && number[1] == '1')
                                {
                                    Console.Write("пятнадцать ");
                                    i = 2;
                                }
                                if (number[2] == '6' && number[1] == '1')
                                {
                                    Console.Write("шестнадцать ");
                                    i = 2;
                                }
                                if (number[2] == '7' && number[1] == '1')
                                {
                                    Console.Write("семнадцать ");
                                    i = 2;
                                }
                                if (number[2] == '8' && number[1] == '1')
                                {
                                    Console.Write("восемнадцать ");
                                    i = 2;
                                }
                                if (number[2] == '9' && number[1] == '1')
                                {
                                    Console.Write("девятнадцать ");
                                    i = 2;
                                }
                                break;

                            case '2':
                                if (i == 0)
                                    Console.Write("двесте ");
                                if (i == 2)
                                    Console.Write("два ");
                                if (i == 1)
                                {
                                    Console.Write("двадцать ");
                                }
                                break;

                            case '3':
                                if (i == 0)
                                    Console.Write("тристо ");
                                if (i == 1)
                                    Console.Write("тридцать ");
                                if (i == 2)
                                    Console.Write("три ");
                                break;

                            case '4':
                                if (i == 0)
                                    Console.Write("четыресто ");
                                if (i == 1)
                                    Console.Write("сорок ");
                                if (i == 2)
                                    Console.Write("четыре ");
                                break;

                            case '5':
                                if (i == 0)
                                    Console.Write("пятьсот ");
                                if (i == 1)
                                    Console.Write("пятьдесят ");
                                if (i == 2)
                                    Console.Write("пять ");
                                break;

                            case '6':
                                if (i == 0)
                                    Console.Write("шестьсот ");
                                if (i == 1)
                                    Console.Write("шесдесят ");
                                if (i == 2)
                                    Console.Write("шесть ");
                                break;

                            case '7':
                                if (i == 0)
                                    Console.Write("семьсот ");
                                if (i == 1)
                                    Console.Write("семьдесят ");
                                if (i == 2)
                                    Console.Write("семь ");
                                break;

                            case '8':
                                if (i == 0)
                                    Console.Write("восемьсот ");
                                if (i == 1)
                                    Console.Write("восемьдесят ");
                                if (i == 2)
                                    Console.Write("восемь ");
                                break;

                            case '9':
                                if (i == 0)
                                    Console.Write("девятьсот ");
                                if (i == 1)
                                    Console.Write("девяносто ");
                                if (i == 2)
                                    Console.Write("девять ");
                                break;

                            default:
                                Console.Write("что-то пошло не так :)\r\n");
                                i = 2;
                                break;
                        }
                        i++;
                    }
                    Console.Write("\r\n");
                }
                if (zadanie == 2)
                {
                    double x = 10;
                    try
                    {
                        while (!(Math.Abs(x) < 1))
                        {
                            Console.Write("Введите вещественное число |X| < 1: ");
                            x = Convert.ToDouble(Console.ReadLine());
                            if (!(Math.Abs(x) < 1))
                            {
                                Console.Write("Прочитайте условие еще раз и попробуйте ввести снова ;)\r\n");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.Write("что-то пошло не так :)\r\n");
                    }

                    try
                    {
                        int n = 0;
                        while (!(n > 0))
                        {
                            Console.Write("Введите натуральное число N > 0: ");
                            n = Convert.ToInt32(Console.ReadLine());
                            if (!(n > 0))
                            {
                                Console.Write("Прочитайте условие еще раз и попробуйте ввести снова ;)\r\n");
                            }
                        }
                        double rez = 0;
                        for (int j = 1; j < n; ++j)
                        {
                            rez += factnechet(2 * j - 1) * Math.Pow(x, 2 * j + 1) / factchet(2 * j + 1);
                        }
                        rez = Math.Asin(x);
                        Console.Write("Приближенное значение arcsin в точке X: " + rez);
                    }
                    catch (Exception)
                    {
                        Console.Write("что-то пошло не так :)\r\n");
                    }
                    Console.Write("\r\n");
                }
                if(zadanie == 3)
                {
                    int a,b;
                    do
                    {
                        Console.Write("Введите число A: ");
                    } 
                    while (!TryParse(Console.ReadLine(), out a));
                    do
                    {
                        Console.Write("Введите число B: ");
                    }
                    while (!TryParse(Console.ReadLine(), out b));
                    while (a != b)
                    {
                        if (a > b)
                        {
                            a = a - b;
                        }
                        else
                        {
                            b = b - a;
                        }
                    }

                    int nod = a;
                    Console.WriteLine("НОД: " + nod);
                }
            }
        }
    }
}