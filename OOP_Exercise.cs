using Learning_CSharp.Zoo_Management;
using NAudio.CoreAudioApi.Interfaces;
using OfficeOpenXml.Packaging.Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Learning_CSharp
{
    public interface ISwim
    {
         void Swim();
    }
    public abstract class Animal
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public Animal(string name = "", int age = 0)
        {
            Name = name;
            Age = age;
        }
        public virtual void Make_Sound()
        {
            Console.WriteLine("An animal is making sound!!!");
        }
    }
    public class Lion : Animal, ISwim
    {
        private string maneColor;
        public string ManeColor { get { return maneColor; } set { maneColor = value; } }
        
        public Lion(string ManeColor = "", string Name = "", int Age = 0) : base(Name, Age)
        {
            this.ManeColor = ManeColor;
        }
        public override void Make_Sound()
        {
            Console.WriteLine($"My name is {Name}, I'm a lion");
        }
        public override string ToString()
        {
            return $"Name: {Name} | Age: {Age} | Mane Color: {ManeColor}";
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} a lion, is swimming");
        }
    }
    public class Dog : Animal, ISwim
    {
        private string color;
        public string Color { get { return color; } set { color = value; } }
        public Dog(string Color = "", string Name = "", int Age = 0) : base(Name, Age)
        {
            this.Color = Color;
        }
        public override void Make_Sound()
        {
            Console.WriteLine($"My name is {Name}, I'm a dog");
        }
        public override string ToString()
        {
            return $"Name: {Name} | Age: {Age} | Color: {Color}";
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} a dog, is swimming");
        }
    }

    public class Cat : Animal
    {
        private string furColor;
        public string FurColor { get { return furColor; } set { furColor = value; } }
        public Cat(string FurColor = "", string Name = "", int Age = 0) : base(Name, Age)
        {
            this.FurColor = FurColor;
        }
        public override void Make_Sound()
        {
            Console.WriteLine($"My name is {Name}, I'm a cat");
        }
        public override string ToString()
        {
            return $"Name: {Name} | Age: {Age} | Fur Color: {FurColor}";
        }
    }
    public class Zoo
    {
        private List<Animal> animals;
        public List<Animal> Animals { get { return animals; } set { animals = value; } }
        public Zoo()
        {
            Animals = new List<Animal>();
        }
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
        public void DisPlay()
        {
            if(Animals.Count <= 0) Console.WriteLine("There is no animals in the zoo");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
        public void Perform()
        {
            Console.WriteLine("Perform Making Sound: ");
            foreach (var animal in animals)
            {
                animal.Make_Sound();
            }
            Console.WriteLine("Perform Swimming: ");
            foreach (var animal in animals)
            {
                if (animal is ISwim swimmer)
                {
                    swimmer.Swim();
                }
            }
        }
    }
}
