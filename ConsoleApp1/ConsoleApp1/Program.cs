using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {
        public class contact
        {
            public string FirstName;
            public string LasttName;
            public double Phone;
            public int Pincode;
        }
        public static List<contact> AdressBook = new List<contact>();
        public static Dictionary<string, contact> AdressBook1 = new Dictionary<string, contact>();
     
        public static void Addcontact1()
        {

            contact contact1 = new contact
            {
                FirstName = Console.ReadLine(),
                LasttName = Console.ReadLine(),
                Phone = Convert.ToInt64(Console.ReadLine()),
                Pincode = Convert.ToInt32(Console.ReadLine())
            };
            AdressBook1.Add(contact1.FirstName, contact1);

        }
        public static void EditContact1()
        {
            Console.WriteLine("Enter The contact Name to be Edit");
            string ContactName = Console.ReadLine();
            AdressBook1.Remove(ContactName);
            Console.WriteLine("Enter Your First Name, Last Name, Phone Number, Pincode");

            contact contact1 = new contact
            {
                FirstName = Console.ReadLine(),
                LasttName = Console.ReadLine(),
                Phone = Convert.ToInt64(Console.ReadLine()),
                Pincode = Convert.ToInt32(Console.ReadLine())
            };
            AdressBook1.Add(contact1.FirstName, contact1);
        }
        public static void Display()
        {
            foreach (var item in AdressBook1)
            {
                Console.WriteLine($"First Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");

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
        public static void DeleteContact()
        {
            
            Console.WriteLine("Enter The contact Name to be remove");
            string ContactName = Console.ReadLine();
            if (AdressBook1.ContainsKey(ContactName))
            {

                AdressBook1.Remove(ContactName);
            }
            else
            {
                Console.WriteLine("Enter Name is not present in AdressBook");

            }

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
                    Addcontact1();
                    Console.WriteLine("Want to Add more contact yes/no");
                    Repeate = Console.ReadLine().ToUpper();

                }
                Display();
                string condition;

                do
                { 
                Console.WriteLine("Type 1 for ADD\nType 2 for Delete\nType 3 for Edit");
                int i =Convert.ToInt32(Console.ReadLine());
                
               
                    switch (i)
                    {
                        case 1:
                            Addcontact1();
                            Display();
                            break;
                        case 2:
                            DeleteContact();
                            Display();
                            break;
                        case 3:
                            EditContact1();
                            Display();
                            break;


                        default:
                            Console.WriteLine("Please Enter Valid Option");
                            break;

                    }
                    Console.WriteLine("Please Enter if you want to continue Yes/NO?");
                    condition = Console.ReadLine().ToUpper();

                } while (condition=="YES");
            }
            else
            {
                Console.WriteLine("Please enter valid YES/NO");
            }
        }
    }
}
