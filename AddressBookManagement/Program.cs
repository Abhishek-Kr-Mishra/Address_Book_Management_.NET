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
                Console.WriteLine("3: To Update the existing address");

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

                    case 3:
                        Console.WriteLine("Enter the email of contact which you want to update");
                        string key = Console.ReadLine();
                        if (addressBookOperation.IsContains(key))
                        {
                            addressBookContactVariables = addressBookOperation.NewAddressBook();
                            addressBookOperation.UpdateValue(key, addressBookContactVariables);
                        }
                        else
                        {
                            Console.WriteLine("Given Key Not Found");
                        }
                        break;

                    default:
                        Console.WriteLine("Please select valid option");
                        break;
                }
            }
        }
    }
}
