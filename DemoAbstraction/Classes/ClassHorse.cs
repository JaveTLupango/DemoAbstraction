using System;

namespace DemoAbstraction.Classes
{
    internal class ClassHorse : Animal
    {
        public ClassHorse(string name, int age, string sound) : base(name, age, sound)
        {
        }

        public override void Details()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age.ToString());
            Console.WriteLine("Make Sound :" + sound);
        }
    }
}