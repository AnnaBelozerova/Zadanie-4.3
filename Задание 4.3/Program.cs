using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._3
{
    class Program
    {   //Найти количество квадратов в прямоугольнике
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника:");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите размер стороны квадрата:");
            double C = Convert.ToDouble(Console.ReadLine());

            double i = C;
            double j = C;
            uint sum = 0;
            uint sumi = 0;

            while (i <= A)
            {
                i = i + C;
                sumi++;                
            }
            while (j <= B)
            {
                j = j + C;
                sum = sum + sumi;
            }
            Console.WriteLine("Количество квадратов, размещенных в прямоугольнике: {0}", sum);
            Console.ReadKey();
        }
    }
}
