using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Up.Bank.BusinessLogic.DomainModel
{
    public class Account
    {

        public Account()
        {
            accountID = 0000000000;
            firstName = "";
            lastName = "";
            address = "";
        }

        public Account(int ID, string fname, string lname, string address)
        {
            if (ID < 0 || ID > 9999999999 )
                throw new Exception("Account ID invalid");

            accountID = ID;
            firstName = "";
            lastName = "";
            address = "";
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public decimal accountID { get; set; }
    }
}
