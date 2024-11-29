using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Task1_exception
{
    public class Room
    {
        private static int _count;
        private double _price;
        private byte _personCapasity;
        public int Id { get; }
        public string Name { get; set; }


        public double Price
        {
            get => _price;

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Price not true");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public byte PersonCapasity
        {
            get => _personCapasity;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Capasity not true");
                }
                else
                {
                    _personCapasity = value;
                }
            }
        }

        public bool IsAvailable { get; set; } = true;
        public Room(string name, double price, byte personCapasity)
        {
            Id = ++_count;
            Name = name;
            Price = price;
            PersonCapasity = personCapasity;

        }

        public string ShowInfo()
        {
            return $"Room id: {Id} , Room name:{Name} , Room price:{Price} , Room capasity:{PersonCapasity} , Room isaviabel{IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }


    }
}
