using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    internal class Pet
    {
        public string name;
        public int energy;

        public void Play(string name, int energy)
        {
            if (energy >= 20)
            {
                Console.WriteLine($"{name} играет, энергия: {energy - 20}");
            }
            else
            {
                Console.WriteLine("Недостаточно энергии");
            }

        }
        public void Rest(string name, int energy)
        {
            if (energy < 100 && energy + 30 < 100)
            {
                Console.WriteLine($"{name} отдыхает, энергия: {energy + 30}");
            }
        }
    }
}
