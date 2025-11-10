public class WirelessMouse : IPowerable, IRechargeable
{
    public bool IsOn { get; set; }
    public int BatteryLevel { get; set; }
    public WirelessMouse()
    {
        IsOn = false;
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
    public void Charge()
    {
        BatteryLevel = 100;
        Console.WriteLine("Mouse is fully charged.");
    }
}
