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
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("DT54", "Kia Morning", 10, 4));
            vehicles.Add(new Motorbike("DT34", "Honda", 5, true));
            vehicles.Add(new Car("DT55", "BWM", 100, 6));
            vehicles.Add(new Motorbike("DT35", "Vision", 10, false));
            vehicles.Add(new Car("DT56", "Mazda", 10, 6));
            vehicles.Add(new Motorbike("DT36", "Wave", 2, false));
            vehicles.Add(new Car("DT57", "Lamborgini", 1000, 2));
            vehicles.Add(new Motorbike("DT37", "Dream", 1, true));
            VehicalRentalSystem rentalSystem = new VehicalRentalSystem(vehicles);
            
            
            rentalSystem.DisplayVehicles();
            Console.WriteLine();
            rentalSystem.Rent("DT57");
            rentalSystem.Rent("DT56");
            rentalSystem.Return("DT56");
            rentalSystem.Rent("DT57");
            rentalSystem.ListRentedVehicles();
        }
    }
}