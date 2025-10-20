using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    internal class Person
    {
        public string name;
        public int age;

        public void SayHello(string name, int age)
        {
            if (age < 0 || age > 120)
            { 
                Console.WriteLine($"Ошибка: введите корректный возраст"); 
            }
            else
            {
                Console.WriteLine($"Привет, я {name}, мне {age} лет!");
            }
        }
    }
}
