using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Zoo_Management
{
    internal class ZooEnclosure
    {
        #region Fields
        private string name;
        private List<Animal> animals;
        #endregion
        #region Properties
        public string Name {  get { return name; }set { name = value; } }
        public List<Animal> Animals { get { return animals; } set { animals = value; } }
        #endregion
        #region Constructors
        public ZooEnclosure()
        {
            name = string.Empty;
            animals = new List<Animal>();
        }
        public ZooEnclosure(string name)
        {
            this.name = name;
            animals = new List<Animal>();
        }
        public ZooEnclosure(string name, List<Animal> animals)
        {
            Name = name;
            this.animals = animals;
        }

        #endregion
        #region Methods
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void DisplayAnimals()
        {
            Console.WriteLine($"Enclosure: {Name}");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.MakeSound();
            }
        }
        #endregion
    }
}
