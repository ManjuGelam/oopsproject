using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
     public class Employee                 //Indexers
    {
        int _Id;
        string _Name, _Job;
        double _Salary;
        bool _Status;
        public Employee(int Id)
        {
            _Id = Id;
            _Name = "Scott";
            _Job = "Manager";
            _Salary = 50000.00;
            _Status = true;
        }
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return _Id;
                else if (index == 2)
                    return _Name;
                else if (index == 3)
                    return _Job;
                else if (index == 4)
                    return _Salary;
                else if (index == 5)
                    return _Status;
                else
                    return null;
            }
            set
            {
                if (index == 2)
                    _Name = (string)value;
                else if (index == 3)
                    _Job = (string)value;
                else if (_Id == 4)
                    _Salary = (double)value;
                else if (index == 5)
                    _Status = (bool)value;
            }
        }
        public object this[string name]
        {
            get
            {
                if (name.ToLower() == "id")
                    return _Id;
                else if (name.ToLower() == "name")
                    return _Name;
                else if (name.ToLower() == "job")
                    return _Job;
                else if (name.ToLower() == "salary")
                    return _Salary;
                else if (name.ToLower() == "status")
                    return _Status;
                else
                    return null;
            }
            set
            {
                if (name.ToUpper() == "NAME")
                    _Name = (string)value;
                else if (name.ToUpper() == "JOB")
                    _Job = (string)value;
                else if (name.ToUpper() == "SALARY")
                    _Salary = (double)value;
                else if (name.ToUpper() == "STATUS")
                    _Status = (bool)value;
            }
        }
    }
    internal class TestEmployee
    {
        static void Main()
        {
            Employee Emp = new Employee(1111);
            Console.WriteLine("Employee ID: " + Emp[1]);
            Console.WriteLine("Employee Name: " + Emp[2]);
            Console.WriteLine("Employee Job: " + Emp[3]);
            Console.WriteLine("Employee Salary: " + Emp[4]);
            Console.WriteLine("Employee Status: " + Emp[5]);
            Console.WriteLine();

            Emp["Id"] = 1111; 
            Emp[3] = "Sr. Manager";
            Emp["Salary"] = 80000.00;

            Console.WriteLine("Employee ID: " + Emp["Id"]);
            Console.WriteLine("Employee Name: " + Emp["name"]);
            Console.WriteLine("Employee Job: " + Emp["JOB"]);
            Console.WriteLine("Employee Salary: " + Emp["SaLaRy"]);
            Console.WriteLine("Employee Status: " + Emp["Status"]);
            Console.ReadLine();
        }
    }
}






    

