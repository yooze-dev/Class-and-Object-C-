using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Маша";
            person.age = 25;
            person.SayHello(person.name, person.age);
        }
    }
}
