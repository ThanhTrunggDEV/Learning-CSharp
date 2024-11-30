using Learning_CSharp.Zoo_Management;
using NAudio.CoreAudioApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    public class Animal
    {
        private string name;
        private int age;
        private string species;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Species { get { return species; } set { species = value; } }
        public Animal()
        {
            name = string.Empty;
            age = 0;
            species = string.Empty;
        }
        public Animal(string Name, int Age, string Species)
        {
            this.Name = Name;
            this.Age = Age;
            this.Species = Species;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound!!");
        }
    }
    public class Lion : Animal
    {
        public bool IsAlpha { get; set; }
        public Lion(): base()
        {
            IsAlpha = false;
        }
        public Lion(string Name, int Age, string Species, bool IsAlpha) : base(Name, Age, Species)
        {
            this.IsAlpha = IsAlpha;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} a lion is speaking");
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Species: {Species}\n" +
                   $"Age: {Age}\n" +
                   $"Alphal: {IsAlpha}\n";
        }
    }
    public class Parrot : Animal
    {
        public void RepeatWord(string word)
        {
            Console.WriteLine(word);
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} a parrot is speaking");
        }
        public Parrot() : base() { }
        public Parrot(string Name, int Age, string Species) : base(Name, Age, Species) { }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Species: {Species}\n" +
                   $"Age: {Age}\n";
        }
    }
    public class Dolphin : Animal
    {
        public void DoFlip()
        {
            Console.WriteLine($"{Name} a dolphin does a flip");
        }
        public Dolphin() : base() { }
        public Dolphin(string Name, int Age, string Species) : base(Name, Age, Species) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} a Dolphine is speaking");
        }
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Species: {Species}\n" +
                   $"Age: {Age}\n";
        }
    }
    public class Zoo
    {
        private List<Animal> animalList;
        public List<Animal> AnimalList { get { return animalList; } set { animalList = value; } }
        public Zoo()
        {
            animalList = new List<Animal>();
        }
        public Zoo(List<Animal> animalList)
        {
            AnimalList = animalList;
        }
        public void AddAnimal(Animal animal)
        {
            animalList.Add(animal);
        }
        public void DisplayAllAnimals()
        {
            foreach(Animal animal in AnimalList)
            {
                Console.WriteLine(animal);
            }
        }
        public void HearAnimalSounds()
        {
            foreach (Animal animal in AnimalList)
            {
                animal.MakeSound();
            }
        }
        public void AnimalAction()
        {
            foreach (var item in animalList)
            {
                if (item is Lion lion)
                    continue;
                if (item is Parrot parrot)
                    parrot.RepeatWord("Hello");
                if (item is Dolphin dolphin)
                    dolphin.DoFlip();
            }
        }
    }
}
