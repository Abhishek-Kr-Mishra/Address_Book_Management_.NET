using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookManagement
{
    class AddressBookContactVariables
    {
        private String fName;
        private String lName;
        private String Address;
        private String city;
        private String state;
        private String email;
        private int zip;
        private long phone;

        public String GetfName()
        {
            return fName;
        }

        public void SetfName(String fName)
        {
            this.fName = fName;
        }

        public String SetlName()
        {
            return lName;
        }

        public void SetlName(String lName)
        {
            this.lName = lName;
        }

        public String GetAddress()
        {
            return Address;
        }

        public void SetAddress(String address)
        {
            Address = address;
        }

        public String GetCity()
        {
            return city;
        }

        public void SetCity(String city)
        {
            this.city = city;
        }

        public String GetState()
        {
            return state;
        }

        public void SetState(String state)
        {
            this.state = state;
        }

        public String GetEmail()
        {
            return email;
        }

        public void SetEmail(String email)
        {
            this.email = email;
        }

        public int GetZip()
        {
            return zip;
        }

        public void SetZip(int zip)
        {
            this.zip = zip;
        }

        public long GetPhone()
        {
            return phone;
        }

        public void SetPhone(long phone)
        {
            this.phone = phone;
        }

        override
        public String ToString()
        {
            return "AddressBookContactVariables{" +
                    "fName='" + fName + '\'' +
                    ", lName='" + lName + '\'' +
                    ", Address='" + Address + '\'' +
                    ", city='" + city + '\'' +
                    ", state='" + state + '\'' +
                    ", email=" + email + '\'' +
                    ",zip=" + zip +
                    ", phone=" + phone +
                    '}';
        }
    }
}
