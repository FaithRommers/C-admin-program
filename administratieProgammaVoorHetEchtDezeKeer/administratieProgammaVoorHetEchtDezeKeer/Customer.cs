using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administratieProgammaVoorHetEchtDezeKeer
{
    internal class Customer
    {
        public string firstName;
        public string lastName;
        public string address;
        public string phoneNumber;
        public string id;

        //init variables
        public Customer(string _firstName, string _lastName, string _address, string _phoneNumber) 
        { 
           firstName = _firstName;
           lastName = _lastName;
           address = _address;
           phoneNumber = _phoneNumber;

            id = Guid.NewGuid().ToString();
        }

        // get full name
        public string GetName()
        {
            return $"{firstName} {lastName}"; 
        }
    }
}
