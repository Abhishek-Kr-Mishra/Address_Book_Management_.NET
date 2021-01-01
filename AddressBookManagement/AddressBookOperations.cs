using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookManagement
{
    class AddressBookOperations
    {
        Dictionary<string, AddressBookContactVariables> addressBookContainer = new Dictionary<string, AddressBookContactVariables>();
        public Dictionary<string, AddressBookContactVariables> Save(string fname, AddressBookContactVariables addressBookVariables)
        {
            addressBookContainer.Add(fname, addressBookVariables);
            return addressBookContainer;
        }
        public AddressBookContactVariables NewAddressBook()
        {
            AddressBookContactVariables addressBookContactVariables = new AddressBookContactVariables();
            Console.WriteLine("Enter the First Name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter The Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the Email Id of Contact");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the zip Code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Phone number");
            long phone = Convert.ToInt64(Console.ReadLine());
            addressBookContactVariables.SetfName(fName);
            addressBookContactVariables.SetlName(lName);
            addressBookContactVariables.SetAddress(address);
            addressBookContactVariables.SetCity(city);
            addressBookContactVariables.SetState(state);
            addressBookContactVariables.SetEmail(email);
            addressBookContactVariables.SetZip(zip);
            addressBookContactVariables.SetPhone(phone);
            return addressBookContactVariables;
        }

        public void PrintAllDetails()
        {
            foreach (KeyValuePair<string, AddressBookContactVariables> keyValuePair in addressBookContainer)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                                  keyValuePair.Key, keyValuePair.Value);
            }
        }

        public bool IsContains(string key)
        {
            bool status=false;
            if (addressBookContainer.ContainsKey(key) == true)
                status = true;

            return status;
        }
        public Dictionary<string, AddressBookContactVariables> UpdateValue(string key, AddressBookContactVariables addressBookVariables)
        {
            if (addressBookContainer.ContainsKey(key) == false)
            {
                Console.WriteLine("Key Not Found");
            }
            else if (addressBookContainer.ContainsKey(key) == true)
            {
                addressBookContainer[key] = addressBookVariables;
                Console.WriteLine("Values Updated");
            }
            return addressBookContainer;
        }

        public void DeleteAddress(string key)
        {
                addressBookContainer.Remove(key);
                Console.WriteLine(key + " Deleted Successfully");
        }
    }
}
