using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Zoo_Management
{
    internal class Zoo
    {
        #region Fields
        private List<ZooEnclosure> zooEnclosures;
        #endregion
        #region Properties
        public List<ZooEnclosure> ZooEnclosures { get { return zooEnclosures; } set { zooEnclosures = value; } }
        #endregion
        #region Constructors
        public Zoo()
        {
            ZooEnclosures = new List<ZooEnclosure>();
        }
        public Zoo(List<ZooEnclosure> zooEnclosures)
        {
            ZooEnclosures = zooEnclosures;
        }

        #endregion
        #region Methods
        public void AddEnclosure(ZooEnclosure enclosure)
        {
            zooEnclosures.Add(enclosure);
        }
        public void AddAnimalToClosure(Animal animal, string name)
        {
            for (int i = 0; i < zooEnclosures.Count; i++)
            {
                if(name == zooEnclosures[i].Name)
                {
                    zooEnclosures[i].AddAnimal(animal);
                    return;
                }
            }
            Console.WriteLine($"Not Found {name} Closure");
        }
        public void FeedAnimals()
        {
            foreach (var closure in zooEnclosures)
            {
                Console.WriteLine($"Feeding animals in {closure.Name}...");
                foreach (var animal in closure.Animals)
                {
                    animal.Eat();
                }
            }
        }
        public void ShowDailyRoutine()
        {
            foreach (var closure in ZooEnclosures)
            {
                Console.WriteLine($"Daily routine in {closure.Name}:");
                foreach (var animal in closure.Animals)
                {
                    animal.Eat();
                    animal.Sleep();
                    animal.MakeSound();
                    if(animal is IHerbivore temp)
                    {
                      
                        temp.Graze();
                    }
                    if(animal is ICarnivor temp1)
                    {
                        
                        temp1.Hunt();
                    }
                }
            }
        }
        #endregion
    }
}
