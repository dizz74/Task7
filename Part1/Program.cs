using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите 3 стороны:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            double S = SqrBy3(a, b, c);
            
            if (S == 0 || Double.IsNaN(S)) Console.WriteLine("Неверные исх.данные");
            else
            Console.WriteLine("Площадь:{0:f4}", S);
            Console.ReadKey();
        }


        static double SqrBy3(int a, int b, int c) {
            double p=((double)(a+b+c))/2;
            return  Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
