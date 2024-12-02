using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Smart_Home_Management
{
    public interface IRemotelyControllable
    {
        void ConnectToWifi(string ssid);
    }
    public abstract class SmartDevice
    {
        private string deviceID;
        private string deviceName;
        private bool isOn;
        public string DeviceID { get { return deviceID; } }
        public string DeviceName { get { return deviceName; } private set { deviceName = value; } }
        public bool IsOn { get { return isOn; } protected set { isOn = value; } }
        public SmartDevice()
        {
            deviceID = string.Empty;
            deviceName = string.Empty;
            isOn = false;
        }
        public SmartDevice(string DeviceName, string DeviceID)
        {
            this.deviceID = DeviceID;
            this.DeviceName = DeviceName;
            IsOn = false;
        }
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void DisplayStatus();
    }
    public class SmartLight : SmartDevice, IRemotelyControllable
    {
        public int Brightness { get; set; }
        public SmartLight() : base()
        {
            Brightness = 0;
        }
        public SmartLight(string DeviceID, string DeviceName) : base(DeviceName, DeviceID)
        {
            Brightness = 0;
        }

        public override void DisplayStatus()
        {
            if (IsOn == false)
                Console.WriteLine($"Brightness: {Brightness} Status: Off");
            else
                Console.WriteLine($"Brightness: {Brightness} Status: On");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Brightness = 0;
        }
        public void ModifyBrightness(int brightness)
        {
            if (brightness >= 0 && brightness <= 100)
                Brightness += brightness;
            else
                Console.WriteLine("Error");
        }
        public override void TurnOn()
        {
            IsOn = true;
            Brightness = 50;
        }

        public void ConnectToWifi(string ssid)
        {
            Console.WriteLine($"Successfully Connected To Wifi {ssid}");
        }
    }
    public class SmartThermostat : SmartDevice, IRemotelyControllable
    {
        public double Temperature { get; set; }
        public SmartThermostat() : base()
        {
            Temperature = 0;
        }
        public SmartThermostat(string DeviceID, string DeviceName) : base(DeviceName, DeviceID)
        {
            Temperature = 22;
        }
        public override void DisplayStatus()
        {
            if (IsOn)
                Console.WriteLine($"Temperature: {Temperature} Status: On");
            else
                Console.WriteLine($"Temperature: {Temperature} Status: Off");
        }

        public override void TurnOff()
        {
            Temperature = 0;
            IsOn = false;
        }

        public override void TurnOn()
        {
            Temperature = 22;
            IsOn = true;
        }

        public void ConnectToWifi(string ssid)
        {
            Console.WriteLine($"Successfully Connected To Wifi {ssid}");
        }
    }
    public class SmartSpeaker : SmartDevice, IRemotelyControllable
    {
        public string CurrentTrack { get; set; }
        private string DefaultTrack = "Fake Love";
        public SmartSpeaker() : base()
        {
            CurrentTrack = string.Empty;
        }
        public SmartSpeaker(string DeviceID, string DeviceName) : base(DeviceName, DeviceID)
        {
            CurrentTrack = string.Empty;
        }
        public override void DisplayStatus()
        {
            if (IsOn)
                Console.WriteLine($"Current Track: {CurrentTrack} Status: On");
            else
                Console.WriteLine($"Current Track: {CurrentTrack} Status: Off");
        }

        public override void TurnOff()
        {
            CurrentTrack = string.Empty;
            IsOn = false;
        }

        public override void TurnOn()
        {
            IsOn = true;
            CurrentTrack = DefaultTrack;
        }

        public void ConnectToWifi(string ssid)
        {
            Console.WriteLine($"Successfully Connected To Wifi {ssid}");
        }
    }
    public class ManageDevices
    {
        public List<SmartDevice> Devices { get; set; }
        public ManageDevices()
        {
            Devices = new List<SmartDevice>();
        }
        public ManageDevices(List<SmartDevice> devices)
        {
            Devices = devices;
        }
        public void TurnOnDevices()
        {
            var OffDevices = from device in Devices where device.IsOn == false select device;
            foreach (var device in OffDevices)
            {
                device.TurnOn();
            }
            Console.WriteLine("SuccessFully Turn On All Devices");
        }
        public void TurnOffDevices()
        {
            var OnDevices = from device in Devices where device.IsOn == true select device;
            foreach (var device in OnDevices)
            {
                device.TurnOff();
            }
            Console.WriteLine("SuccessFully Turn Off All Devices");
        }
        public void DisplayStatusDevices()
        {
            foreach (var device in Devices)
            {
                device.DisplayStatus();
            }
        }
        public void FindAndControl(string deviceID)
        {
            var Device = Devices.FirstOrDefault(d => d.DeviceID == deviceID);
            if (Device != null)
            {

                
                Console.WriteLine("Choose Action: ");
                Console.WriteLine("1: Turn On");
                Console.WriteLine("2: Turn Off");
                Console.WriteLine("3: Display Status");
                Console.WriteLine("4: Cancel");
                int command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Device.TurnOn();
                        break;
                    case 2:
                        Device.TurnOff();
                        break;
                    case 3:
                        Device.DisplayStatus();
                        break;
                    case 4:
                        return;
                }
            }
            else
            {
                Console.WriteLine($"Device ID {deviceID} Not Found");
            }

        }
    }
}
