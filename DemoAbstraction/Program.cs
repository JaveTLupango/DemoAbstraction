using System;
using DemoAbstraction.Classes;

namespace DemoAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new ClassBird("Birdie", 1, "tweet");
            Animal b = new ClassCat("Mingay", 2, "Meow");
            Animal c = new ClassCow("Calfie", 1, "Moo");
            Animal d = new ClassDog("Doggie", 3, "Arf");
            Animal e = new ClassHorse("Whinny", 4, "Neigh");

            Console.WriteLine(" ------------------ ");
            a.Details();
            Console.WriteLine(" ------------------ ");
            b.Details();
            Console.WriteLine(" ------------------ ");
            c.Details();
            Console.WriteLine(" ------------------ ");
            d.Details();
            Console.WriteLine(" ------------------ ");
            e.Details();
            Console.WriteLine(" ------------------ ");

        }
    }
}

