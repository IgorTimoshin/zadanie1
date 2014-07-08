using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление площади круга, ограниченного окружностью известный длины. ");
            Console.Write("Введите длину окружности: ");
            Double Z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь равна: {0}", Z * Z / (4 * 3.14));
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти");
            Console.ReadKey();
        }
    }
}
