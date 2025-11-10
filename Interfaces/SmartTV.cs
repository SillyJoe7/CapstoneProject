public class SmartTV : IPowerable, IConnectable
{
    public bool IsOn { get; set; }
    public string Ssid { get; private set; }
    public SmartTV()
    {
        IsOn = false;
        Ssid = string.Empty;
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
            Console.WriteLine("Cannot connect the TV is off");
            return;
        }

        Ssid = networkName;
        Console.WriteLine($"TV connected to WiFi network: {Ssid}");
    }

    public void Disconnect()
    {
        Console.WriteLine($"TV disconnected from WiFi network: {Ssid}");
        Ssid = string.Empty;
    }
}
