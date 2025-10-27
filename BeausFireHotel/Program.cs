namespace BeausFireHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel fartCity = new Hotel(4);



            fartCity.RequestRoom("guy");
            fartCity.RequestRoom("gal");
            fartCity.RequestRoom("xavier knutson");
            fartCity.RequestRoom("megatron pearson");
            fartCity.RequestRoom("megatron pearson 2.0");

            fartCity.Display();
            fartCity.cancelAndReassign(fartCity.rooms[1]);
            fartCity.Display();
        }
    }
}
