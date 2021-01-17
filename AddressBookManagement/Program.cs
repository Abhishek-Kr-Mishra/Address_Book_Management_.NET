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
                Console.WriteLine("1: For add new Address to Dictionary");
                Console.WriteLine("2: To Print all From Address Dictionary");
                Console.WriteLine("3: To Update the existing address");
                Console.WriteLine("4: To Delete the existing address");
                Console.WriteLine("5: Search Address By City Name");
                Console.WriteLine("6: Search Persons name By City Name Or State Name");
                Console.WriteLine("7: Count Persons By City Name Or State Name");
                Console.WriteLine("8: Sort Persons First Name");
                Console.WriteLine("9: Sort Person's By Zip");
                Console.WriteLine("10: Write Data To Text File");
                Console.WriteLine("11: Read Data From Text File");
                Console.WriteLine("12: Write Data To CSV File");
                Console.WriteLine("13: Read Data From CSV File");
                Console.WriteLine("14: Terminate the Program");

                string textFilePath = @"E:\Fellowship_Projects\Address_Book_Management_.NET\AddressBookManagement\AddressBookFiles\AddressBookText.txt";
                string csvFilePath = @"E:\Fellowship_Projects\Address_Book_Management_.NET\AddressBookManagement\AddressBookFiles\AddressBookCSV.csv";
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookContactVariables = addressBookOperation.NewAddressBook();
                        if (addressBookOperation.IsContains(addressBookContactVariables.GetFname()))
                        {
                            Console.WriteLine("First Name Can't Be Duplicate....Enter Different Name");
                        }
                        else
                        {
                            addressBookOperation.Save(addressBookContactVariables.GetFname(), addressBookContactVariables);
                        }
                        break;

                    case 2:
                        addressBookOperation.PrintAllDetails();
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
                        Console.WriteLine("Enter city name to search Address");
                        string searchCity = Console.ReadLine();
                        addressBookOperation.SearchByCity(searchCity);
                        break;
                    case 6:
                        Console.WriteLine("Enter City or State name to search Address");
                        string searchCityState = Console.ReadLine();
                        addressBookOperation.ViewPersonByCityOrState(searchCityState);
                        break;
                    case 7:
                        Console.WriteLine("Enter city name to search Address");
                        string countByCityOrState = Console.ReadLine();
                        addressBookOperation.CountPersonByCityOrState(countByCityOrState);
                        break;
                    case 8:
                        addressBookOperation.SortPersonName();
                        break;
                    case 9:
                        addressBookOperation.SortPersonByZip();
                        break;
                    case 10:
                        addressBookOperation.WriteInTextFile(textFilePath);
                        break;
                    case 11:
                        addressBookOperation.ReadFromTextFile(textFilePath);
                        break;
                    case 12:
                        addressBookOperation.WriteToCsvFile(csvFilePath);
                        break;
                    case 13:
                        addressBookOperation.ReadFromCsvFile(csvFilePath);
                        break;
                    case 14:
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