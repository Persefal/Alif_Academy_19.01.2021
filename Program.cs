using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1

            double a = 16.80;
            double b = 12.40;

            double result = Math.Sqrt(a*b);
            System.Console.WriteLine(result);

            //Задание №2

            double A = 1.40;
            double B = -5.50;
            double C = 0.60;
            
            double AC = A - C;
            double BC = C - B;
            double summa = AC + BC;

            System.Console.WriteLine(AC);
            System.Console.WriteLine(BC);
            System.Console.WriteLine(summa);

            //Задание №3

            double x1 = -6.20;
            double y1 = 5.20;
            double x2 = 2.10;
            double y2 = 9.80;

            double rastoyanie = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2));
            System.Console.WriteLine(rastoyanie);

            //Задание №4

            int z = 41;
            int x = z / 10;
            int v = (z % 10)*10;
            int resul = v + x;

            System.Console.WriteLine(resul);

            //Задание №5

            int N = 10985;
            int second = N / 60;

            System.Console.WriteLine(second);

            //Задание №6

            int K = 202;
            int n = K  % 7;
            System.Console.WriteLine(n);



        }
    }
}
