using System;

namespace Variant16
{
    public class Customer
    {
        public string familyname;
        public string name;
        public string surname;
        public string address;
        public long phonenumber;
        public long cardnumber;
        public int bankaccountnumber;

        public Customer()
        {
            familyname = "unknown";
            name = "unknown";
            surname = "unknown";
            address = "unknown";
            phonenumber = 0;
            cardnumber = 0;
            bankaccountnumber = 0;
        }
        public Customer(string familyname, string name, string surname, string address, long phonenumber, long cardnumber, int bankaccountnumber)
        {
            this.familyname = familyname;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phonenumber = phonenumber;
            this.cardnumber = cardnumber;
            this.bankaccountnumber = bankaccountnumber;
        }
        public override string ToString()
        {
            return familyname + ", " + name + ", " + surname + ", " + address + ", " + phonenumber + ", " + cardnumber + ", " +bankaccountnumber;
        }
        public override string Intertval()
        {
            int resault = bankaccountnumber;
            if (resault > 0000000232146000 && resault < 6800950078003400)
            {
                resault = bankaccountnumber;
            }
            return familyname + ", " + name + ", " + surname + ", " + address + ", " + phonenumber + ", " + cardnumber + ", " + bankaccountnumber;
        }
    }
}

