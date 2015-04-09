
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Data.OleDb;
using System.IO;


namespace MovieRental
{
    class customer

      {
          FileStream fs = new FileStream("CstomerInformation.txt", FileMode.Create, FileAccess.Write);
          StreamWriter textWriter = new StreamWriter();
          ArrayList accountNumbers = new ArrayList();


        public void setName(string first, string last)
         {
             textWriter.WriteLine("*"+ first + " ");
             textWriter.WriteLine(last + "*");
        
         }
        public void setAddress(string street, string city, string state, string zip)
        {                    
                    textWriter.WriteLine("/n $" + street + "\n");
                    textWriter.WriteLine(city + ", ");
                    textWriter.WriteLine(state + " ");
                    textWriter.WriteLine(zip + "$");
                    
          }

        public void setAccountNumber()
        {
            Random rand = new Random();
            bool same = true;   
            int acc;
            string accString;
            
             while (same)
             {
             acc = rand.Next(100000, 999999);
            accString = acc.ToString();

          for (int i = 0; i <accountNumbers.Count; i++)
          {
            if (accString.Equals(accountNumbers[i]))
            {
                same = true;
                  break;
                            
            }
            else
            {
                same = false;
                continue;
            }
          
          }
          textWriter.WriteLine("\n #" + acc + "#");
        }
        
        }



        public void setAccountNumber(string acc) 
        {
            textWriter.WriteLine("\n #"+ acc + "#");
        }
        public void setPhoneNumber(string phone)
        {
            textWriter.WriteLine("\n #" + phone + "#");
        }

      }


    }
