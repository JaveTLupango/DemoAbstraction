using System;

namespace DemoAbstraction.Classes
{
    internal class ClassBird : Animal
    {
        public ClassBird(string name, int age, string sound) : base(name, age, sound)
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