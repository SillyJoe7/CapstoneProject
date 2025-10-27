using System.Collections;
using System.ComponentModel.DataAnnotations;

public class Hotel
{
    public Reservation[] rooms;
    private List<string> waitList;

    public Hotel(int pooms)
    {
        rooms = new Reservation[pooms];
        waitList = new List<string>();
    }

    public void Display()
    {


        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] != null)
            {
                Console.WriteLine(rooms[i]);
            }
        }
        Console.Write("Waitlist: ");
        foreach (string n in waitList)
        {
            Console.Write(n + ", ");


        }
        Console.WriteLine();


    }



    public Reservation RequestRoom(string guestName)
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] == null)
            {
                rooms[i] = new Reservation(guestName, i);
                return rooms[i];
            }

        }
        waitList.Add(guestName);


        return null;
    }

    public Reservation cancelAndReassign(Reservation res) {
        int room = res.getRoomNumber();
        rooms[room] = null;

        if (waitList != null)
        {
            RequestRoom(waitList[0]);
            waitList[0] = null;
        }
        return rooms[room];

    
    
}


}