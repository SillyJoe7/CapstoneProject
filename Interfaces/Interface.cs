interface IPowerable
{
    public bool IsOn { get; set; }
    void PowerOn();
    void PowerOff();
}

interface IConnectable
{
    void Connect(string networkName);
    void Disconnect();
    public string Ssid { get; }
}

interface IRechargeable
{
    int BatteryLevel { get; }
    void Charge();
}
