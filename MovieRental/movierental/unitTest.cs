using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    class unitTest
    {
        string  acc = "8486545842";
        string phone="2156546544";
        string street = "229 cambridge pl";
        string city="philadelphia";
        string state="PA";
        string zip="18914";
        string first = "Mark";
        string last="Rossmair";

     
        
        
        public void writingTest ()
         {
            customer cust = new customer();
            cust.setAccountNumber(acc);
            cust.setAddress(street,city,state, zip);
            cust.setName(first, last);
            cust.setPhoneNumber(phone);
            cust.close();

         }


    }
}
