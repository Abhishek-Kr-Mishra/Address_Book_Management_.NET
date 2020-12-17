using System;

namespace AddressBookManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Management");
            AddressBookContactVariables addressBookContactVariables = new AddressBookContactVariables();
            AddressBookOperations addressBookOperation = new AddressBookOperations();

            Boolean terminate = false;
            while (terminate != true)
            {
                Console.WriteLine("1: For add new Address");
                Console.WriteLine("2: To Print all From Address Dictionary");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookContactVariables = addressBookOperation.NewAddressBook();
                        Console.WriteLine(addressBookOperation.Save(addressBookContactVariables.GetEmail(), addressBookContactVariables));
                        break;

                    case 2:
                        addressBookOperation.printAllDetails();
                        break;

                    default:
                        Console.WriteLine("Please select valid option");
                        break;
                }
            }
        }
    }
}
