using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.Threading;
using static System.Math;
using static System.Threading.Thread;
using static ThanhTrung.Advanced;
using System.Globalization;
namespace Learning_CSharp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            Zoo zoo = new Zoo();
            Animal parrot = new Parrot("Jack",20, "Bird");
            Animal lion = new Lion("Simba", 10, "Carnivores", false);
            Animal dolphin = new Dolphin("Leo", 30, "Fish");
            zoo.AddAnimal(parrot);
            zoo.AddAnimal(lion);
            zoo.AddAnimal(dolphin);
            zoo.DisplayAllAnimals();
            zoo.HearAnimalSounds();
            zoo.AnimalAction();
        }
    }
}