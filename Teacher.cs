using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    public  class Teacher                    //deconstructor
    {
        
    int Id;
        string Name, Subject, Designation;
        double Salary;
        public Teacher(int Id, string Name, string Subject, string Designation, Double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Subject = Subject;
            this.Designation = Designation;
            this.Salary = Salary;
        }
        public void Deconstruct(out int Id, out string Name, out string Subject, out string Designation, out double Salary)
        {
            Id = this.Id;
            Name = this.Name;
            Subject = this.Subject;
            Designation = this.Designation;
            Salary = this.Salary;
        }
    }
    class TestTeacher
    {
        static void Main()
        {
            Teacher obj = new Teacher(1005, "manju", "English", "Lecturer", 30000.00);
            (int Id1, string Name1, string Subject1, string Designation1, double Salary1) = obj;
            Console.WriteLine("Teacher Id: " + Id1);
            Console.WriteLine("Teacher Name: " + Name1);
            Console.WriteLine("Teacher Subject: " + Subject1);
            Console.WriteLine("Teacher Designation: " + Designation1);
            Console.WriteLine("Teacher Salary: " + Salary1 + "\n");
            Console.ReadLine();
        }
    }
}

    

