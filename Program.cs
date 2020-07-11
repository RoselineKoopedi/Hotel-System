using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming281_Project
{
    class Program
    {
        public enum Main_Menu
        {
            Manage_Customer =1,
            Manage_Rooms,
            Manage_Bookings,
            Exit
        }
        public enum Manage_Customer
        {
            Add_Customer=5,
            Remove_Customer,
            Search_Customer,
            Back_to_Main_Menu
        }
        public enum Manage_Rooms
        {
            Add_Room = 10,
            Remove_Room,
            Check_Room_Status,
            Back_to_Main_Menu
        }
        public enum Manage_Bookings
        {
            Add_New_Bookings = 15,
            Check_in_Customer,
            Check_Out_Customer,
            Cancel_Booking,
            Back_to_Main_Menu
        }
        static void Main(string[] args)
        {
            Customer[] c = new Customer[100];
            Class_Room[] r = new Class_Room[100];
            Class_Booking[] b = new Class_Booking[100];
            Customer cu = new Customer();
            Class_Room cr = new Class_Room();
            Console.WriteLine("");
            Console.WriteLine((int)Main_Menu.Manage_Customer + " Manage_Customer");
            Console.WriteLine((int)Main_Menu.Manage_Rooms + " Manage_Rooms");
            Console.WriteLine((int)Main_Menu.Manage_Bookings + " Manage_Bookings");
            Console.WriteLine((int)Main_Menu.Exit + " Exit");
            int option = int.Parse(Console.ReadLine());
            while (option != 4)
            {
                switch (option)
                {
                    case (int)Main_Menu.Manage_Customer:
                        Console.WriteLine((int)Manage_Customer.Add_Customer + " Add Customer");
                        Console.WriteLine((int)Manage_Customer.Remove_Customer + " Remove_Customer");
                        Console.WriteLine((int)Manage_Customer.Search_Customer + " Search_Customer");
                        Console.WriteLine((int)Manage_Customer.Back_to_Main_Menu + " Back_to_Main_Menu");
                        break;
                        int o = int.Parse(Console.ReadLine());
                        switch (o)
                        {

                            case (int)Manage_Customer.Add_Customer:
                                Console.WriteLine("Enter ID number");
                                cu.Id = Console.ReadLine();
                                Console.WriteLine("Enter Firstname");
                                cu.FirstName = Console.ReadLine();
                                Console.WriteLine("Enter Last name");
                                cu.LastName = Console.ReadLine();
                                Console.WriteLine("Enter gender");
                                cu.Gender = Console.ReadLine();
                                Console.WriteLine("Enter Date Of Birth");
                                cu.Dob = DateTime.Parse(Console.ReadLine());
                                if (cu.Dob > DateTime.Now)
                                {
                                    Console.WriteLine("Date of birth cannot be creater than current date");
                                }
                                Console.WriteLine("Enter Nationality");
                                cu.Nationality = Console.ReadLine();
                                Console.WriteLine("Enter Phone number");
                                cu.PhoneNumber = Console.ReadLine();
                                Console.WriteLine("Enter credit rating");
                                cu.CreditRating = Console.ReadLine();
                                for (int i = 0; i < c.Length; i++)
                                {
                                    if (c[i] == null)
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine("Cannot add customer");
                                    }

                                }
                                break;
                            case (int)Manage_Customer.Remove_Customer:
                                Console.WriteLine("Enter customer id");
                                cu.Id = Console.ReadLine();
                                //if (cu.Id ==)
                                //{

                                //}
                                break;
                            case (int)Manage_Customer.Search_Customer:

                                break;
                            case (int)Manage_Customer.Back_to_Main_Menu:
                                break;
                        }
                    case (int)Main_Menu.Manage_Rooms:
                        Console.WriteLine((int)Manage_Rooms.Add_Room + " Add_Room");
                        Console.WriteLine((int)Manage_Rooms.Remove_Room + "Remove_Room");
                        Console.WriteLine((int)Manage_Rooms.Check_Room_Status + "Check_Room_Status ");
                        Console.WriteLine((int)Manage_Rooms.Back_to_Main_Menu + " Back_to_Main_Menu");
                        Console.WriteLine("Make an option");
                        int opt = int.Parse(Console.ReadLine());
                        switch (opt)
                        {
                            case (int)Manage_Rooms.Add_Room:
                                Console.WriteLine("Enter room number");
                                cr.RoomNo= Console.ReadLine();
                                Console.WriteLine("Enter room type");
                                cr.RoomType = Console.ReadLine();
                                Console.WriteLine("Enter room daily rates");
                                cr.DailyRate = Console.ReadLine();
                                Console.WriteLine("Enter room status");
                                cr.Status= Console.ReadLine();
                                break;
                            case (int)Manage_Rooms.Remove_Room:
                                break;
                            case (int)Manage_Rooms.Check_Room_Status:
                                break;
                            case (int)Manage_Rooms.Back_to_Main_Menu:
                                break;
                            default:
                                break;
                        }
                        break;
                     
                    default:
                        break;
                }
               
                option = int.Parse(Console.ReadLine());
            }
        }
    }
}
