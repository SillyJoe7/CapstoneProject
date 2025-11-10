using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Phone phone1 = new Phone();
        Phone phone2 = new Phone();
        SmartTV tv1 = new SmartTV();
        SmartTV tv2 = new SmartTV();
        WirelessMouse mouse1 = new WirelessMouse();
        WirelessMouse mouse2 = new WirelessMouse();

        List<IPowerable> deviceCanPower = new List<IPowerable> { phone1, phone2, tv1, tv2, mouse1, mouse2 };

        Console.WriteLine("Powering on all devices");
        foreach (var device in deviceCanPower)
        {
            device.PowerOn();
        }
        Console.WriteLine();

        List<IConnectable> deviceCanConnect = new List<IConnectable> { phone1, phone2, tv1, tv2 };

        Console.WriteLine("Connecting Wi-Fi devices to FrancisTuttleGuest");
        foreach (var device in deviceCanConnect)
        {
            device.Connect("FrancisTuttleGuest");
            Console.WriteLine($"Connected to SSID: {device.Ssid}");
        }
        Console.WriteLine();

        List<IRechargeable> deviceCanCharge = new List<IRechargeable> { phone1, phone2, mouse1, mouse2 };

        Console.WriteLine("Charging rechargeable devices...");
        foreach (var device in deviceCanCharge)
        {
            device.Charge();
        }

        Console.WriteLine("All operations completed successfully!");
    }
}
