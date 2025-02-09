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
using System.Data.Common;
using Learning_CSharp.Learning_At_School;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Linq;
using OfficeOpenXml.LoadFunctions.Params;
using System.Runtime.CompilerServices;
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
            zoo.AddAnimal(new Lion("Yellow", "Simba", 5));
            zoo.AddAnimal(new Dog("Black", "Husky", 3));
            zoo.AddAnimal(new Lion("Red", "Mufasa", 10));
            zoo.AddAnimal(new Dog("White", "Akita", 2));
            zoo.AddAnimal(new Lion("Brown", "Scar", 7));
            zoo.AddAnimal(new Dog("Brown", "Pug", 1));
            zoo.AddAnimal(new Lion("Black", "Nala", 6));
            zoo.AddAnimal(new Dog("Yellow", "Golden Retriever", 4));
            zoo.AddAnimal(new Lion("White", "Sarabi", 8));
            zoo.AddAnimal(new Dog("Red", "Dalmatian", 5));
            zoo.AddAnimal(new Lion("Yellow", "Simba", 5));
            zoo.AddAnimal(new Dog("Black", "Husky", 3));
            zoo.DisPlay();
            zoo.Perform();
        }
    }
}