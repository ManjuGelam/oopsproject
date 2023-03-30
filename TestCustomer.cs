using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class TestCustomer
    {
      
            static void Main()
            {
                Customer obj = new Customer(1001);
                Console.WriteLine("Custid: " + obj.custid + "\n");
                //obj.Custid = 1005;  //Invalid, because the property is defined read only

                if (obj.status)
                    Console.WriteLine("Customer Status: Active");
                else
                    Console.WriteLine("Customer Status: In-Active");
                Console.WriteLine("Customer Name: " + obj.name);
                obj.name += " Smith"; //Update fails because status is in-active
                Console.WriteLine("Name when update failed: " + obj.name);
                Console.WriteLine("Balance when status is in-active: " + obj.balance + "\n");

                obj.status = true; //Activating the status
                if (obj.status)
                    Console.WriteLine("Customer Status: Active");
                else
                    Console.WriteLine("Customer Status: In-Active");
                Console.WriteLine("Customer Name: " + obj.name);
                obj.name += " Smith"; //Update succeds because status is in-active
                Console.WriteLine("Name when update succeded: " + obj.name);
                Console.WriteLine("Balance when status is active: " + obj.balance + "\n");

                obj.balance -= 4600; //Transaction failed
                Console.WriteLine("Balance when transaction failed: " + obj.balance);
                obj.balance -= 4500; //Transaction succeds
                Console.WriteLine("Balance when transaction succeded: " + obj.balance + "\n");

                Console.WriteLine("Current City: " + obj.City);
                obj.City = Cities.hydearbad;
                Console.WriteLine("Modified City: " + obj.City);

                Console.WriteLine("Customer State: " + obj.State);
                //obj.State = "Telangana"; //Invalid because set accessor is accessible only to child classes

                Console.WriteLine("Customer Country: " + obj.country);
                Console.WriteLine("Customer Continent: " + obj.Continent);
                Console.ReadLine();
            }
        }


    }

