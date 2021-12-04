using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstraction.Classes
{
    class ClassHorse : Animal
    {
        public ClassHorse(string name, int age, string sound) : base(name, age, sound) { }
        public override void Details()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age.ToString());
            Console.WriteLine("Make Sound :" + sound);
        }
    }
}
