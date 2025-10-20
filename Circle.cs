using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    internal class Circle
    {
        public double radius;

        public void GetArea(double radius)
        {
            if (radius > 0)
            {
                Console.WriteLine($"Площадь круга: {Math.PI * radius * radius}");
            }
            else
            {
                Console.WriteLine("Радиус должен быть больше 0");
            }
        }
    }
}
