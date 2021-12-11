using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите 3 стороны 1 треугольника:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double S1 = SqrBy3(a, b, c);


            Console.WriteLine("Введите 3 стороны 2 треугольника:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            double S2 = SqrBy3(a, b, c);



            if (S1 == 0 || Double.IsNaN(S1) || S2 == 0 || Double.IsNaN(S2)) Console.WriteLine("Неверные исх.данные");
            else
            {
                if (S1 > S2) Console.WriteLine("Площадь первого больше");
                else if (S2 > S1) Console.WriteLine("Площадь второго больше");
                else Console.WriteLine("Одинаковые по площади");
            }
            Console.ReadKey();
        }


        static double SqrBy3(int a, int b, int c) {
            double p=((double)(a+b+c))/2;
            return  Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
