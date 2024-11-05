using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Zoo_Management
{
    public abstract class Animal
    {
        #region Fields
        private string name;
        private string species;
        private int age;
        #endregion
        #region Properties
        public string Name {  get { return name; } set { name = value; } }
        public string Species { get { return species; } set { species = value; } }
        public int Age { get { return age; } set { age = value; } }
        #endregion
        #region Constructors
        public Animal()
        {
            name = string.Empty;
            species = string.Empty;
            age = 0;
        }
        public Animal(string name,string species, int age)
        {
            this.name = name;
            this.species = species;
            this.age = age;
        }
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        #endregion
        #region Methods
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} the {Species} is eating.");
        }
        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} the {Species} is sleeping.");
        }
        public override string ToString()
        {
            return $"{Name} {Species}";
        }
        public abstract void MakeSound();
        #endregion
    }
}
