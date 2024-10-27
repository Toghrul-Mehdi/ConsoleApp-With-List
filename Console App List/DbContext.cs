using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_List
{
    public class DbContext
    {
        public List<Room> rooms = new List<Room>();
        public List<Hotel> hotels = new List<Hotel>();

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void ShowRoom()
        {
            foreach (Room room in rooms)
            {
                Console.WriteLine();
                Console.WriteLine("Otaq Id:"+room.Id);
                Console.WriteLine("Otaq Adi:"+room.Name);
                Console.WriteLine("Otaq Qiymeti"+room.Price);
                Console.WriteLine("Otaq Tutumu"+room.Capacity);
                Console.WriteLine();
            }
        }
        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public void ShowHotel()
        {
            foreach(Hotel hotel in hotels)
            {
                Console.WriteLine();
                Console.WriteLine("Hotel adi:"+hotel.Name);
                Console.WriteLine();
            }
        }
        public bool  GetHotel(string name)
        {
            bool hotel_entry = false;
            foreach(Hotel hotel in hotels)
            {
                if (hotel.Name == name)
                {
                    hotel_entry=true;
                }                
            }
            return hotel_entry;
        }

        public  void Rezervation(int id,int capacity)
        {
            if (id == null)
            {
                throw new NullReferenceException("roomId bosh ola bilmez");
            }
            Room room = rooms.Find(x => x.Id == id);    
            if (room == null)
            {
                throw new CustomException("Otaq tapilmadi");
            }
            if (room.IsAvialable==false)
            {
                throw new CustomException("Otaq elcatan deyil");
            }            
            room.IsAvialable = false;
        }
    }
}
