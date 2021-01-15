using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookManagement
{
    class AddressBookContactVariables
    {
        private string fName;
        private string lName;
        private string address;
        private string city;
        private string state;
        private string email;
        private int zip;
        private long phone;
        public AddressBookContactVariables(string fname, string lname, string address, string city, string state, string email, int zip, long phone)
        {
            this.fName = fname;
            this.lName = lname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.email = email;
            this.zip = zip;
            this.phone = phone;
        }
        public AddressBookContactVariables()
        { }

        public string GetFname()
        {
            return fName;
        }

        public string GetCity()
        {
            return city;
        }
        public string GetState()
        {
            return state;
        }
        override
        public string ToString()
        {
            return "AddressBookContactVariables{" +
                    "fName='" + fName + '\'' +
                    ", lName='" + lName + '\'' +
                    ", Address='" + address + '\'' +
                    ", city='" + city + '\'' +
                    ", state='" + state + '\'' +
                    ", email=" + email + '\'' +
                    ",zip=" + zip +
                    ", phone=" + phone +
                    '}';
        }
    }
}
