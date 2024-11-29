using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_task2
{
    public class Car
    {
        private static int _count;
        public int Id {  get;  }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Type Type { get; set; }
        public Car()
        {
            Id=++_count;
        }

        public override string ToString()
        {
            return $"Id:{Id}, Brand:{Brand}, Model:{Model}, Type:{Type}";
        }
        
        
    }
}
