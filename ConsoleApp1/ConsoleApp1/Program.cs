using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class contact
    {
        public string FirstName;
        public string LasttName;
        public double Phone;
        public int Pincode;
    }
    class Program
    {
        public static List<contact> AdressBook = new List<contact>();

        public static void addcontact()
        {
            contact contact1 = new contact
            {
                FirstName = Console.ReadLine(),
                LasttName = Console.ReadLine(),
                Phone = Convert.ToInt64(Console.ReadLine()),
                Pincode = Convert.ToInt32(Console.ReadLine())
            };
            AdressBook.Add(contact1);

        }
        public static void ConvertToDic()
        {

        }
        public static void Display()
        {
            foreach (var item in AdressBook)
            {
                Console.WriteLine($"First Name : {item.FirstName}\nLast Name ={item.LasttName}\nNumber ={item.Phone}\nPincode={item.Pincode}");
            }
        }
        //public static void DicDisplay()
        //{
        //    foreach (var item in DicAdressBook)
        //    {
        //        Console.WriteLine($"Key:{item.Key}");
        //        Console.WriteLine($"First Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");

        //    }
        //}
        public static void RemoveDicAdressBook()
        {
            Console.WriteLine("Enter The contact Name to be remove");
            string ContactName = Console.ReadLine();
            //DicAdressBook.Remove(ContactName);
            //Console.WriteLine("Enter Your First Name, Last Name, Phone Number, Pincode");

            //contact contact1 = new contact
            //{
            //    FirstName = Console.ReadLine(),
            //    LasttName = Console.ReadLine(),
            //    Phone = Convert.ToInt64(Console.ReadLine()),
            //    Pincode = Convert.ToInt32(Console.ReadLine())
            //};
            //DicAdressBook.Add(ContactName,);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Adress Book");
            Console.WriteLine("Want to Add more contact yes/no");
            string Repeate = Console.ReadLine().ToUpper();
            if (Repeate == "YES")
            {
                while (Repeate == "YES")
                {
                    Console.WriteLine("Enter Your First Name, Last Name, Phone Number, Pincode");

                    addcontact();

                    Console.WriteLine("Want to Add more contact yes/no");
                    Repeate = Console.ReadLine().ToUpper();

                }
            
                Console.WriteLine("....................Processing for edit.....0.......");
                    Dictionary<string, contact> DicAdressBook = AdressBook.ToDictionary(x => x.FirstName);

                foreach (var item in DicAdressBook)
                {
                    Console.WriteLine($"Key:{item.Key}");
                    Console.WriteLine($"First Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");

                }

                Console.WriteLine("Do You want to Edit data?");
                string DataRemoved = Console.ReadLine().ToUpper();
                if (DataRemoved == "YES")
                {
                    Console.WriteLine("Enter the Name to be edited");
                    string NameTobeRemoved = Console.ReadLine();
                    DicAdressBook.Remove(NameTobeRemoved);
     
                    Console.WriteLine("Enter the New First name, last name,phone,pincode");
                    string FirstName = Console.ReadLine();
                    contact contact1 = new contact
                    {
                        FirstName = FirstName,
                        LasttName = Console.ReadLine(),
                        Phone = Convert.ToInt64(Console.ReadLine()),
                        Pincode = Convert.ToInt32(Console.ReadLine())
                    };
                    DicAdressBook.Add(FirstName, contact1);
                    foreach (var item in DicAdressBook)
                    {
                        Console.WriteLine($"Key:{item.Key}");
                        Console.WriteLine($"First Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");

                    }

                    Console.WriteLine("Do You want again Edit data?");
                    DataRemoved = Console.ReadLine().ToUpper();

                }
               
            }
            else
            {
                Console.WriteLine("please enter valid yes or no");
            }
        }
    }
}
