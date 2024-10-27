using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_List
{
    public class Room
    {
        private static int _id=1;
        public int Id;
        public string Name;
        public double Price;
        public int Capacity;
        public  bool IsAvialable;

        public Room(string name,double price,int capacity)
        {
            Id = _id++;
            Name = name;
            Price = price;
            Capacity = capacity;
            IsAvialable = true;
        }

    }
}
