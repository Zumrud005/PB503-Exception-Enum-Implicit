using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Task1_exception
{
    public class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms;

        public Hotel(string name)
        {
            _rooms = Array.Empty<Room>();
            Name = name;
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[^1] = room;
        }

        public void  MakeReservation(int roomId)
        {
            if (roomId==0 || roomId < 0)
            {
                throw new NullReferenceException("Id is not true");
            }

            foreach (var room in _rooms)
            {
                if (room.Id == roomId)
                {

                    if (room.IsAvailable == false)
                    {
                        throw new NotAvailableException("This room is not empty");
                    }
                    else
                    {
                        room.IsAvailable = false;
                        Console.WriteLine("Reservation successful");
                    }

                }

            }

        }

    }
}
