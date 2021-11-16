using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребpa");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Объем куба:{0:f0} Площадь: {1:f0}",GetV(a),GetS(a));
        }

        static double GetS(int a) {
            return a * a * 6;
        }
        static double GetV(int a)
        {
            return Math.Pow(a, 3);
        }
    }
}
