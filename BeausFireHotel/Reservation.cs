public class Reservation
{
    string name;
    int number;
    public Reservation(string guestName, int roomNumber)
    {
        name = guestName;
        number = roomNumber;

    }
    public int getRoomNumber()
    {
        return number;
    }
    
    public string getGuestName()
    {
        return name;
    }
    public override string ToString()
    {
        return ("Guest: " + name +", Room: " + number);
    }
}
