using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.brand = "Apple";
            phone.batteryLevel = 100;
            phone.UsePhone(phone.brand, phone.batteryLevel);
            
        }
    }
}
