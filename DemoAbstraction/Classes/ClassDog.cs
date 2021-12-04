using System;

namespace DemoAbstraction.Classes
{
    internal class ClassDog : Animal
    {
        public ClassDog(string name, int age, string sound) : base(name, age, sound)
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