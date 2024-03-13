using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administratieProgammaVoorHetEchtDezeKeer
{
    internal class Functions
    {
        //init dictionary
        public Dictionary<string, Customer> customers = new Dictionary<string, Customer>(); 


        public void AddCustomer() 
        {
            Console.WriteLine("\nAdd customer");

            // Get inputs
            Console.Write("Customer First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();


            //Add into dictionary
            Customer c = new Customer(firstName, lastName, address, phoneNumber);
            customers.Add(c.id, c);
        }

        public void ViewCustomer(string? id = null) 
        { 
            // if no specific person was given show all
            if (id == null) 
            {
                foreach (var c in customers.Values) 
                {
               
                    Console.WriteLine(
                    $" * {c.GetName()}\n" +
                    $"  Address: {c.address}\n" +
                    $"  PhoneNumber: {c.phoneNumber}\n"
                    );
                }
            } 
            // show specific person
            else
            {
                 Customer c = customers[id];
                 Console.WriteLine(
                    $" * {c.GetName()}\n" +
                    $"  Address: {c.address}\n" +
                    $"  PhoneNumber: {c.phoneNumber}\n"
                    );
            }
        }

        public void EditCustomer(string customerId)
        {
            Console.WriteLine("\nEdit customer");

            // Get inputs
            Console.Write("Customer First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();


            //edit dictionary entry
            Customer c = customers[customerId];
            c.firstName = firstName;
            c.lastName = lastName;
            c.address = address;
            c.phoneNumber = phoneNumber;
            customers[customerId] = c;
        }

        public void DeleteCustomer(string customerId) 
        {
            // make it all red and ask conformation
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Are you sure? (Y/N)");
            Console.ForegroundColor = ConsoleColor.White;
            string answer = Console.ReadLine().ToLower();
            
            // delete customer
            if (answer == "y")
            { 
             customers.Remove(customerId);
                return;
            }

            //cancled deletion
            Console.WriteLine("Cancled customer deletion");
           
        }

        public string FindCustomer(string fullName)
        {

            //check everything in dictionary and find first result
            foreach (var c in customers.Values)
            { 
            if (c.GetName () + " " == fullName) 
                {
                    return c.id;
                }
            }
            // nothing was found
            return $"{fullName}was not found";
        }
    }
}
