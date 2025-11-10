public class Phone : IPowerable, IConnectable, IRechargeable
{
    public bool IsOn { get; set; }
    public string Ssid { get; private set; }
    public int BatteryLevel { get; set; }
    public Phone()
    {
        IsOn = false;
        Ssid = string.Empty;
        BatteryLevel = 100;
    }
    public void PowerOn()
    {
        IsOn = true;
    }

    public void PowerOff()
    {
        IsOn = false;
    }

    public void Connect(string networkName)
    {
        if (!IsOn)
        {
            Console.WriteLine("Cannot connect the phone is off");
            return;
        }

        Ssid = networkName;
        Console.WriteLine($"Smartphone connected to WiFi network: {Ssid}");
    }

    public void Disconnect()
    {
        Console.WriteLine($"Smartphone disconnected from WiFi network: {Ssid}");
        Ssid = string.Empty;
    }
    public void Charge()
    {
        BatteryLevel = 100;
        Console.WriteLine("Smartphone is fully charged.");
    }
}
