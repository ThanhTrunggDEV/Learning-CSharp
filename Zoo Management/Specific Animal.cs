using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Zoo_Management
{
    public class Lion : Animal, ICarnivor
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Lion roars!");
        }
        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting for prey");
        }
        public Lion(string name, int age) : base(name,"Lion" , age) { }
    }
    public class Elephant : Animal, IHerbivore
    {
        public void Graze()
        {
            Console.WriteLine($"{Name} the Elephant is grazing on plants.");
        }
        public Elephant(string name, int age) : base(name, "Elephant", age) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Elephant trumpets!");
        }
    }
    public class Parrot : Animal
    {
        public Parrot(string name, int age) : base(name, "Parrot",age) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Parrot squawks!");
        }
    }
}
