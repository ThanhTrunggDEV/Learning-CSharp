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
using Learning_CSharp.Student_Management_System;
using Learning_CSharp.Smart_Home_Management;
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
            
            SmartLight light = new SmartLight("L234","Supper Light");
            SmartSpeaker smartSpeaker = new SmartSpeaker("S543", "Smart Speaker");
            SmartThermostat smartThermostat = new SmartThermostat("T345", "Thermo");
            List<SmartDevice> devices = new List<SmartDevice>();
            devices.Add(smartSpeaker);
            devices.Add(smartThermostat);
            devices.Add(light);
            ManageDevices test = new ManageDevices(devices);
            Console.WriteLine("Default Status: ");
            test.DisplayStatusDevices();
            Console.WriteLine("Turned on: ");
            test.TurnOnDevices();
            test.DisplayStatusDevices();
            Console.WriteLine("Turned off: ");
            test.TurnOffDevices();
            test.DisplayStatusDevices();
            Console.WriteLine();
            test.FindAndControl("tre");
            test.FindAndControl("L234");
        }
    }
    
}