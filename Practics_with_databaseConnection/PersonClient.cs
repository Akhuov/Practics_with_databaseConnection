using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_with_databaseConnection
{
    public class PersonClient
    {
        public PersonClient() { }

        public PersonClient(int personid, string lastname, string firstname, string phonenumber, int qual, int amount, int paid, int unpaid, string status, string indate, string outdate)
        {
            PersonId = personid;
            LastName = lastname;
            FirstName = firstname;
            PhoneNumber = phonenumber;
            Quality = qual;
            Amount = amount;
            Paid = paid;
            UnPaid = unpaid;
            Status = status;
            InDate = indate;
            OutDate = outdate;
        }


        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public int Quality { get; set; }
        public int Amount { get; set; }
        public int Paid { get; set; }
        public int UnPaid { get; set; }
        public string Status { get; set; }
        public string InDate { get; set; }
        public string OutDate { get; set; }
    }
}
