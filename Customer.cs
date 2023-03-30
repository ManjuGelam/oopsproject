using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
     public class Customer
    {
        int  _custid;
            bool _status ;
            string _name,_state;
        double _balance ;
            Cities _city;
        public Customer(int custid)
        {
            _custid = custid;
            _status = false;
            _name = "john";
            _balance = 6000.00;
            _city = 0;
            _state = "karnataka";
            country = "india";


        }
        public int custid       //read only 
        {
            get { return _custid; }
        }
        //read  write 
        public bool status
        {
            get { return _status; }
            set { _status = value; }
        }
        //read write
        public string name
        {
            get { return _name; }
            set
            {
                if(_status)
                {
                    _name = value;
                }

            }
        }
        //read write 
        public double balance
        {
            get
            {
                if(_status )
                {
                    return _balance;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if(_status)
                {
                    if (value >= 500)
                    {
                        _balance = value;
                    }
                }
            }
        }
        //Read-Write Property (Enumerated Property)
        public Cities City
        {
            get { return _city; }
            set
            {
                if (_status)
                {
                    _city = value;
                }
            }
        }
        //Read-Write Property 
        public string State
        {
            get { return _state; }
            protected set
            {
                if (_status)
                {
                    _state = value;
                }
            }
        }
        //Read-Write
        public string country
        {
            get;
            private set;
        }
        //Read-Write Property 
        public string Continent { get; } = "Asia";
    }

}
            

        
    

