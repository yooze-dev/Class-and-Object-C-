using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    internal class Phone
    {
        public string brand;
        public int batteryLevel;

        public void UsePhone(string brand, int batteryLevel)
        {
            if (batteryLevel > 100 || batteryLevel < 0)
            {
                Console.WriteLine("Ошибка: Введите корректный заряд");
            }
            else
            {
                if (batteryLevel - 10 < 0)
                {
                    Console.WriteLine($"Телефон {brand}, заряд: {0}%");
                }
                else
                {
                    Console.WriteLine($"Телефон {brand}, заряд: {batteryLevel - 10}%");
                }
            }
        }
    }
}
