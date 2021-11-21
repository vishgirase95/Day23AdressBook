using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {
       
        public class contact
        {
            public string FirstName { get; set; }
            public string LasttName { get; set; }
            public double Phone { get; set; }
            public int Pincode { get; set; }
        }

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
            if (AdressBook1.ContainsKey(ContactName))
            {
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
            else
            {
                Console.WriteLine("The given data is not in Adressbook");
            }
        }


        public static void Display()
        {
            foreach (var item in AdressBook1)
            {
                Console.WriteLine($"\nFirst Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");
            }
        }

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
        }

        public static void SearchPerson()
        {
            string searchName = Console.ReadLine();
            if (AdressBook1.ContainsKey(searchName))
            {
                List<KeyValuePair<string, contact>> AdressBookList = AdressBook1.ToList();
                List<KeyValuePair<string, contact>> filter = AdressBookList.FindAll(x => x.Value.FirstName == searchName).ToList();
                foreach (var item in filter)
                {
                    Console.WriteLine($"\nFirst Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");
                }
            }
            else { Console.WriteLine("Name is invalid");
            };
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Wellcome to Adress Book");
            Console.WriteLine("Want to Enter contact yes/no");
            string Repeate = Console.ReadLine().ToUpper();
            if (Repeate == "YES")
            {


                Console.WriteLine("\n\nEnter Your First Name, Last Name, Phone Number, Pincode\n");
                Addcontact1();
                Display();

                string condition;
                do
                {
                    Console.WriteLine("\n\n\nType 1 for ADD\nType 2 for Delete\nType 3 for Edit\nType 4 for Search Person");
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Enter Your First Name, Last Name, Phone Number, Pincode\n");
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
                        case 4:
                            SearchPerson();

                            break;

                        default:
                            Console.WriteLine("----------Please Enter Valid Option-----------");
                            break;

                    }
                    Console.WriteLine("\nPlease Enter if you want to continue Yes/NO?");
                    condition = Console.ReadLine();

                } while (condition == "yes");
            }
            else
            {
                Console.WriteLine("Please enter valid YES/NO");
            }
        }
    }
}
