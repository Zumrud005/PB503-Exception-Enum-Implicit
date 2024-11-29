namespace PB503_Task1_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new("Chanel", 90.4, 25);
            Room room2 = new Room("Gucci", 120, 50);
            Hotel hotel = new Hotel("LuxHotel");
            room1.IsAvailable = true;
            room2.IsAvailable = false;
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

           

            try
            {
                hotel.MakeReservation(-5678);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eror"+ex.Message);
            }



        }
    }
}
