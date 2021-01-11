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

        //public void SetfName(string fName)
        //{
        //    this.fName = fName;
        //}

        //public string SetlName()
        //{
        //    return lName;
        //}

        //public void SetlName(string lName)
        //{
        //    this.lName = lName;
        //}

        //public string GetAddress()
        //{
        //    return Address;
        //}

        //public void SetAddress(string address)
        //{
        //    Address = address;
        //}

        public string GetCity()
        {
            return city;
        }

        //public void SetCity(string city)
        //{
        //    this.city = city;
        //}

        //public string GetState()
        //{
        //    return state;
        //}

        //public void SetState(string state)
        //{
        //    this.state = state;
        //}

        //public string GetEmail()
        //{
        //    return email;
        //}

        //public void SetEmail(string email)
        //{
        //    this.email = email;
        //}

        //public int GetZip()
        //{
        //    return zip;
        //}

        //public void SetZip(int zip)
        //{
        //    this.zip = zip;
        //}

        //public long GetPhone()
        //{
        //    return phone;
        //}

        //public void SetPhone(long phone)
        //{
        //    this.phone = phone;
        //}

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
