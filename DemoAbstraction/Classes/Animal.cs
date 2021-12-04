namespace DemoAbstraction
{
    internal abstract class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public string sound { get; set; }

        public Animal(string name, int age, string sound)
        {
            this.name = name;
            this.age = age;
            this.sound = sound;
        }

        public abstract void Details();
    }
}