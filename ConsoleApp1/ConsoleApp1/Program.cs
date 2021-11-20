using System;
using System.Collections.Generic;

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

        public static void addcontact() {
         

            contact contact1 = new contact
            {
                FirstName = Console.ReadLine(),
                LasttName = Console.ReadLine(),
                Phone = Convert.ToInt64(Console.ReadLine()),
                Pincode = Convert.ToInt32(Console.ReadLine())
            };
            
            
            AdressBook.Add(contact1);

        }
      

        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Adress Book");
            Console.WriteLine("Enter Your First Name, Last Name, Phone Number, Pincode");
            addcontact();

            string ans = "YES";
            Console.WriteLine("Want to Add more contact yes/no");
            string Repeate = Console.ReadLine().ToUpper();
            while (Repeate=="YES")
            {
              addcontact();
              Repeate = Console.ReadLine();
            }

            foreach (var item in AdressBook)
            {
                Console.WriteLine($"First Name : {item.FirstName}\nLast Name ={item.LasttName}\nNumber ={item.Phone}\nPincode={item.Pincode}");
            }
     
        }
    }
}
