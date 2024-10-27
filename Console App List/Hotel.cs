using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_List
{
    public class Hotel
    {
        private static int _id=1;
        public int Id;
        public string Name;

        public Hotel(string name)
        {
            Name = name;
            Id = _id++;
        }
    }
}
