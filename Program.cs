using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    // zadanie 1
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
    // zadanie 2
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
//zadanie 3
internal class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.owner = "Маша";
        account.balance = 1000;
        account.Deposit(account.owner, account.balance, account.plus);
        account.WithDraw(account.owner, account.balance, account.minus);
    }
}
    //zadanie 4
    internal class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.radius = 10;
        circle.GetArea(circle.radius);
    }
}

    //zadanie 5
    internal class Program
{
    static void Main(string[] args)
    {
        Pet pet = new Pet();
        pet.name = "Шарик";
        pet.energy = 50;
        pet.Play(pet.name, pet.energy);
        pet.Rest(pet.name, pet.energy);
    }
}
            
}

