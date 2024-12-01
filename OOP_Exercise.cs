using Learning_CSharp.Zoo_Management;
using NAudio.CoreAudioApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
     public interface IRentable
    {
         void Rent();
        void Return();
    }

    public class Vehicle : IRentable
    {
        public string VehicleID {  get; set; }
        public string Brand {  get; set; }  
        public double RentalRatePerDay {  get; set; }
        public bool IsAvailable { get; set; } = true;
        public Vehicle()
        {
            VehicleID = string.Empty;
            Brand = string.Empty;
            RentalRatePerDay = 0;
        }
        public Vehicle(string vehicleID, string brand, double rentalRatePerDay)
        {
            VehicleID = vehicleID;
            Brand = brand;
            RentalRatePerDay = rentalRatePerDay;
        }

        public void Rent()
        {
            if (IsAvailable == false)
            {
                Console.WriteLine("Unavailable");
                return;
            }
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }
    }
    public class Car : Vehicle
    {
        public int NumberOfSeats {  get; set; }
        public Car() : base()
        {
            NumberOfSeats = 0;
        }
        public Car(string id, string brand, double rentalRate, int numberOfSeats) : base(id, brand, rentalRate)
        {
            NumberOfSeats = numberOfSeats;
        }
        public override string ToString()
        {
            return $"Vehicle ID: {VehicleID} | Brand: {Brand} | Number of seats: {NumberOfSeats} | Rental Rate: {RentalRatePerDay} | Rental State: {IsAvailable}";
        }
    }
    public class Motorbike : Vehicle
    {
        public bool HasSidecar { get; set; }
        public Motorbike() : base()
        {
            HasSidecar = false;
        }
        public Motorbike(string id, string brand, double rentalRate, bool hasSidecar) : base (id, brand, rentalRate)
        {
            HasSidecar = hasSidecar;
        }
        public override string ToString()
        {
            return $"Vehicle ID: {VehicleID} | Brand: {Brand} | Has Sidecar: {HasSidecar} | Rental Rate: {RentalRatePerDay} | Rental State: {IsAvailable}";
        }
    }
    public class VehicalRentalSystem
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public List<Vehicle> Vehicals { get { return vehicles; } set { vehicles = value; } }
        public VehicalRentalSystem(List<Vehicle> list)
        {
            this.vehicles = list;
        }
        public void DisplayVehicles()
        {
            if(vehicles.Count == 0)
            {
                Console.WriteLine("There's no vehical");
                return;
            }
            foreach (Vehicle v in this.vehicles)
            {
                Console.WriteLine(v);
            }
        }
        public void Rent(string ID)
        {
            foreach (Vehicle v in this.vehicles)
            {
                if(v.VehicleID == ID)
                {
                    v.Rent();
                    return;
                }
            }
            Console.WriteLine("Not found");
        }
        public void Return(string ID)
        {
            foreach (Vehicle v in this.vehicles)
            {
                if (v.VehicleID == ID)
                {
                    v.Return();
                    return;
                }
            }
            Console.WriteLine("Not found");
        }
        public void ListRentedVehicles()
        {
            foreach(var item in vehicles)
            {
                if(item.IsAvailable == false)
                    Console.WriteLine(item);
            }
        }

    }
}
