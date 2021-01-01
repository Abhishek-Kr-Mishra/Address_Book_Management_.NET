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

            string key;
            Boolean terminate = false;
            while (terminate != true)
            {
                Console.WriteLine("1: For add new Address");
                Console.WriteLine("2: To Print all From Address Dictionary");
                Console.WriteLine("3: To Update the existing address");
                Console.WriteLine("4: To Delete the existing address");
                Console.WriteLine("5: Terminate the Program");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookContactVariables = addressBookOperation.NewAddressBook();
                        addressBookOperation.Save(addressBookContactVariables.GetEmail(), addressBookContactVariables);
                        break;

                    case 2:
                        addressBookOperation.printAllDetails();
                        break;

                   case 3:
                        Console.WriteLine("Enter the email of contact which you want to update");
                        key = Console.ReadLine();

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

                    case 4:
                        Console.WriteLine("Enter the email of contact which you want to Delete");
                        key = Console.ReadLine();
                        if (addressBookOperation.IsContains(key))
                        {
                            addressBookOperation.DeleteAddress(key);
                        }
                        else
                        {
                            Console.WriteLine("Given Key Not Found");
                        }
                        break;

                    case 5:
                        terminate = true;
                        break;

                    default:
                        Console.WriteLine("Please select valid option");
                        break;
                }
            }
        }
    }
}
