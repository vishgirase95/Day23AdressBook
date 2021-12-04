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
            public string City { get; set; }

            public double Phone { get; set; }
            public int Pincode { get; set; }
        }

        public static Dictionary<string, contact> AdressBook1 = new Dictionary<string, contact>();
        public static Dictionary<string, contact> AdressBook2 = new Dictionary<string, contact>();

        public List<KeyValuePair<string, contact>> ListAdress2 = AdressBook1.ToList();

        public static void Addcontact1()
        {


            contact contact1 = new contact
            {
                FirstName = Console.ReadLine(),
                LasttName = Console.ReadLine(),
                City = Console.ReadLine(),
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
                    City = Console.ReadLine(),
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
                Console.WriteLine($"\nFirst Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nCity ={item.Value.City}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");
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
            Console.WriteLine("Enter Person Name to search");

            string name = Console.ReadLine();
            var SearchName = AdressBook1.Where(x => x.Key == name).FirstOrDefault();
            Console.WriteLine($"\nFirst Name : {SearchName.Value.FirstName}\nLast Name ={SearchName.Value.LasttName}\nCity :{SearchName.Value.City}\nNumber ={SearchName.Value.Phone}\nPincode={SearchName.Value.Pincode}");

            //string searchName = Console.ReadLine();
            //if (AdressBook1.ContainsKey(searchName))
            //{
            //    List<KeyValuePair<string, contact>> AdressBookList = AdressBook1.ToList();
            //    List<KeyValuePair<string, contact>> filter = AdressBookList.FindAll(x => x.Value.FirstName == searchName).ToList();
            //    foreach (var item in filter)
            //    {
            //        Console.WriteLine($"\nFirst Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nCity :{item.Value.City}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Name is invalid");
            //};
        }
        public static void CountByCity()
        {
            Console.WriteLine("Enter The city to be search");
            string CityName = Console.ReadLine();
            var CityCount = AdressBook1.Count(x => x.Value.City == CityName);

            Console.WriteLine($"The is number of {CityName} is {CityCount} ");
        }
        public static void SearcCity()
        {
            Console.WriteLine("Enter The city to be search");
            string City = Console.ReadLine();
            var SearchCity = AdressBook1.Where(x => x.Value.City == City).FirstOrDefault();

            Console.WriteLine($"\nFirst Name : {SearchCity.Value.FirstName}\nLast Name ={SearchCity.Value.LasttName}\nCity :{SearchCity.Value.City}\nNumber ={SearchCity.Value.Phone}\nPincode={SearchCity.Value.Pincode}");

            //if (AdressBook1.ContainsValue=City) 
            //{
            //List<KeyValuePair<string, contact>> AdressBookList = AdressBook1.ToList();
            //List<KeyValuePair<string, contact>> filter = AdressBookList.FindAll(x => x.Value.City == City).ToList();
            //foreach (var item in filter)
            //{
            //    Console.WriteLine($"\nFirst Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nCity :{item.Value.City}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");
            //}
            //}
            //else
            //{
            //    Console.WriteLine("City is invalid");
            //};
        }
        public static void SortingByName()
        {
            Console.WriteLine("This is sortig");

            foreach (var item in AdressBook1.OrderBy(key => key.Key)) 
            {
                Console.WriteLine($"\nFirst Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nCity ={item.Value.City}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");
            }

        }

        static void Main(string[] args)
        {





            Console.WriteLine("Wellcome to Adress Book");
            Console.WriteLine("Want to Enter contact yes/no");
            string Repeate = Console.ReadLine().ToUpper();
            if (Repeate == "YES")
            {


                Console.WriteLine("\n\nEnter Your First Name, Last Name,City Name, Phone Number, Pincode\n");
                Addcontact1();
                Display();

                string condition;
                do
                {
                    Console.WriteLine("\n\n\nType 1 for ADD\nType 2 for Delete\nType 3 for Edit\nType 4 for Search Person\nType 5 for search by city name\n Type 6 for Count City");
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Enter Your First Name, Last Name,City Name, Phone Number, Pincode\n");
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
                            //foreach (var item in ListAdress2)
                            //{
                            //    Console.WriteLine($"\nFirst Name : {item.Value.FirstName}\nLast Name ={item.Value.LasttName}\nCity :{item.Value.City}\nNumber ={item.Value.Phone}\nPincode={item.Value.Pincode}");

                            //}
                            break;
                        case 5:
                            SearcCity();
                            break;
                        case 6:
                            CountByCity();
                            break;
                        case 7:
                            SortingByName();
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
