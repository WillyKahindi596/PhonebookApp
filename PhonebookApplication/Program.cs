using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApplication
{
    class Program

    {
        public static List<Person> People = new List<Person>();
        public static List<Address> Location = new List<Address>();
        static void Main(string[] args)


        {
            Person person = new Person();
            Address address = new Address();
           

          

            Console.WriteLine("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter Email Address: ");
            person.EmailAddress = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Street: ");
            address.Street = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            address.City = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            address.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode: ");
            address.Zipcode = Console.ReadLine();

            People.Add(person);
            Location.Add(address);

            foreach (Person info in People)
            {
                Console.WriteLine(info.FirstName);
                Console.WriteLine(info.LastName);
                Console.WriteLine(info.EmailAddress);
                Console.WriteLine(info.PhoneNumber);

                foreach (Address Info in Location)
                {
                    Console.WriteLine(Info.Street);
                    Console.WriteLine(Info.City);
                    Console.WriteLine(Info.State);
                    Console.WriteLine(Info.Zipcode);

                }
            }

            
        }

    }
        
}
