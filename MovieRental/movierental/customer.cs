
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
    //      FileStream fs = new FileStream("CustomerInformation.txt", FileMode.Create, FileAccess.Write);
            StreamWriter textWriter = new StreamWriter("CustomerInformation.txt", true);
    //       StreamReader textReader = new StreamReader("CustomerInformation.txt");
            


      


          ArrayList accountNumbers = new ArrayList();


        public void setName(string first, string last)
         {



             textWriter.Write("*" + first + " ");
             textWriter.Write(last + "*");
        
         }
        public void setAddress(string street, string city, string state, string zip)
        {
                       
            
                    textWriter.Write(street + "$");
                    textWriter.Write(city + ", ");
                    textWriter.Write(state + " ");
                    textWriter.Write(zip + "$");
                    
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
          textWriter.Write("/n #" + acc + "#");
        }
        
        }



        public void setAccountNumber(string acc) 
        {
          
            textWriter.Write("/n #"+ acc + "#");
        }
        public void setPhoneNumber(string phone)
        {

            textWriter.Write("#" + phone + "#");
        }

       public string getAddress() 
        {
        StreamReader textReader = new StreamReader("CustomerInformation.txt");


            string dog = "o";
            return dog;
           
            

       }

        public void close()
        {
            
            textWriter.Close();

        }
    
    }

 }

