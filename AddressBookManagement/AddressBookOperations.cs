using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookManagement
{
    class AddressBookOperations
    {
        AddressBookContactVariables addressBookContactVariables;
        public static Dictionary<string, AddressBookContactVariables> addressBookContainer = new Dictionary<string, AddressBookContactVariables>();
        public Dictionary<string, AddressBookContactVariables> Save(string fname, AddressBookContactVariables addressBookVariables)
        {
            addressBookContainer.Add(fname, addressBookVariables);
            return addressBookContainer;
        }
        public void HowManyAddressBoo()
        {
            Console.WriteLine("How Many Address Book you want to add ?");
            int numberOfAddressBook = Convert.ToInt32(Console.ReadLine());
        }
        public AddressBookContactVariables NewAddressBook()
        {
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
            addressBookContactVariables = new AddressBookContactVariables(fName, lName, address, city, state, email, zip, phone);

            return addressBookContactVariables;
        }

        public void PrintAllDetails()
        {
            foreach (KeyValuePair<string, AddressBookContactVariables> keyValuePair in addressBookContainer)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                                  keyValuePair.Key, keyValuePair.Value.ToString());
            }
        }

        public bool IsContains(string key)
        {
            bool status = false;
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
        public static List<AddressBookContactVariables> ReturnListOfValues()
        {
            List<AddressBookContactVariables> values = addressBookContainer.Values.ToList();
            return values;
        }
        public void SearchByCity(string cityName)
        {
            List<AddressBookContactVariables> values = ReturnListOfValues();
            foreach (AddressBookContactVariables addressBookContactVariables in values.FindAll(e => (e.GetCity().Equals(cityName))))
            {
                Console.WriteLine(addressBookContactVariables.ToString());
            }
        }
        public void ViewPersonByCityOrState(string cityState)
        {
            List<AddressBookContactVariables> listValues = ReturnListOfValues();
            foreach (AddressBookContactVariables addressBookContactVariables in listValues.FindAll(e => (e.GetCity().Equals(cityState) || e.GetState().Equals(cityState))))
            {
                Console.WriteLine("Name: "+ addressBookContactVariables.GetFname() + " City: "+addressBookContactVariables.GetCity()+" State: "+addressBookContactVariables.GetState());
            }
        }
        public void CountPersonByCityOrState(string cityState)
        {
            int count = 0;
            List<AddressBookContactVariables> listValues = ReturnListOfValues();
            foreach (AddressBookContactVariables addressBookContactVariables in listValues.FindAll(e => (e.GetCity().Equals(cityState) || e.GetState().Equals(cityState))))
            {
                count++;
            }
            Console.WriteLine("There are " + count + " Persons on given City Or State");
        }
    }
}
