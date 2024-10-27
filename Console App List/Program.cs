namespace Console_App_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            bool alt_menu = false;
            DbContext db = new DbContext();
            
            do
            {
                Console.WriteLine("1.Hotel yarat  2.Butun hotelleri gor  3.Hotel sec  0.Exit");

                string user_input=Console.ReadLine();

                switch (user_input)
                {
                    case "1":
                        Console.WriteLine("Otel adi daxil edin:");
                        string hotel_name=Console.ReadLine(); 
                        Hotel hotel = new Hotel(hotel_name);
                        db.AddHotel(hotel);
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Butun hoteller:");
                        db.ShowHotel();
                        break;
                    case "3":
                        Console.WriteLine("Hotel adi daxil et:");
                        string hotel_name_check=Console.ReadLine();
                        if (db.GetHotel(hotel_name_check) == true)
                        {
                            Console.Clear ();
                            Console.WriteLine("Hotele ugurla daxil oldunuz!");
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("1.Room yarat  2.Roomlari gor  3.Rezervasya et  4.Evvelki menuya qayit  0.Exit");

                                string user_input2 = Console.ReadLine();

                                switch (user_input2)
                                {
                                    case "1":
                                        Console.WriteLine("Otag adi daxil edin:");
                                        string room_name = Console.ReadLine();
                                        bool price_f = false;
                                        double price;
                                        do
                                        {
                                            Console.WriteLine("Qiymet daxil edin:");
                                            price_f = double.TryParse(Console.ReadLine(), out price);
                                            if (price > 0)
                                            {
                                                price_f = true;
                                            }
                                            else
                                            {
                                                price_f = false;
                                            }
                                        } while (!price_f);
                                        bool capacity_f = false;
                                        int capacity;
                                        do
                                        {
                                            Console.WriteLine("Otaq tutumu daxil edin:");
                                            capacity_f = int.TryParse(Console.ReadLine(), out capacity);
                                            if (capacity > 0)
                                            {
                                                capacity_f = true;
                                            }
                                            else
                                            {
                                                capacity_f = false;
                                            }
                                        } while (!capacity_f);
                                        Room room = new Room(room_name, price, capacity);
                                        db.AddRoom(room);
                                        Console.Clear();
                                        break;
                                    case "2":
                                        Console.WriteLine("Butun otaqlar:");
                                        db.ShowRoom();
                                        break;
                                    case "3":
                                        bool room_id_f=false;
                                        int room_id;
                                        do
                                        {
                                            Console.WriteLine("Room Id daxil edin:");
                                            room_id_f = int.TryParse(Console.ReadLine(), out room_id);
                                            if (room_id > 0)
                                            {
                                                room_id_f = true;
                                            }
                                            else
                                            {
                                                room_id_f = false;
                                            }
                                        } while (!room_id_f);
                                        bool room_capacity_f = false;
                                        int room_capacity;
                                        do
                                        {
                                            Console.WriteLine("Otaq tutumu daxil edin:");
                                            room_capacity_f= int.TryParse(Console.ReadLine(),out room_capacity);
                                            if(room_capacity > 0)
                                            {
                                                room_capacity_f= true;
                                            }
                                            else
                                            {
                                                room_capacity_f = false;
                                            }
                                        } while (!room_capacity_f);
                                        try
                                        {
                                            db.Rezervation(room_id, room_capacity);
                                            Console.WriteLine("Rezervasiya edildi");
                                        }
                                        catch (CustomException ex)
                                        {
                                            Console.WriteLine($"Xeta: {ex.Message}");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"Xeta: {ex.Message}");
                                        }                                                                              
                                        break;
                                    case "4":
                                        alt_menu = true;
                                        break;
                                    case "0":
                                        return;
                                        break;
                                    default:
                                        break;
                                }
                            } while (!alt_menu);                           
                        }
                        else
                        {
                            Console.WriteLine("Ugursuz giris!");
                        }
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }
            } while (!f);

            

            
        }
    }
}
