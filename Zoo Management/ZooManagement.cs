using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Learning_CSharp.Zoo_Management
{

    public class ZooManagement
    {
        private static Zoo zoo;
        public static void Init()
        {
            zoo = new Zoo();
        }
        private static ZooEnclosure Infor()
        {
            Console.WriteLine("Enter Name of the closure:");
            string name = Console.ReadLine();
           ZooEnclosure enclosure = new ZooEnclosure(name);
            return enclosure;

        }
        private static void Notification()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
        private static void AddAnimal()
        {
            Console.WriteLine("Enter Closure Name: ");
            string closureName = Console.ReadLine();
            Console.WriteLine("Enter Animal Name: ");
            string animalName = Console.ReadLine();
            Console.WriteLine("Enter Animal Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Type of animal:");
            Console.WriteLine("1. Parrot\n2. Herbivore\n3. Carnivor");
            int command = int.Parse(Console.ReadLine());
            Animal temp = new Lion("",0);
            switch (command)
            {
                case 1:
                    temp = new Parrot(animalName,age);
                    break;
                case 2:
                    temp = new Elephant(animalName,age);
                    break;
                    case 3:
                    temp = new Lion(animalName,age);
                    break;
            }
            zoo.AddAnimalToClosure(temp, closureName);
        }
        private static void Menu()
        {
            Console.WriteLine("1. Add Closure");
            Console.WriteLine("2. Add Animal");
            Console.WriteLine("3. Feed Animal");
            Console.WriteLine("4. Show Daily Routine In The Zoo");
            int command = int.Parse(Console.ReadLine());
            switch(command)
            {
                case 1:
                    var temp = Infor();
                    zoo.AddEnclosure(temp);
                    Notification();
                    break;
                    case 2:
                    AddAnimal();
                    Notification();
                    break;
                    case 3:
                    zoo.FeedAnimals();
                    Notification();
                    break;
                    case 4:
                    zoo.ShowDailyRoutine();
                    Notification();
                    break;
            }
        }
        public static void Start()
        {
            try
            {
                while (true)
                {
                    Menu();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
