using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_Videos_Advanced_c_.Examples_Classes
{
    internal class Employee:IComparable<Employee>
    {
        public  int ID { get; set; }
        public string FullName { get; set; }
        public Contract Contract { get; set; }
        public decimal StartingSalary { get; set; }
        public string DescriptionJob { get; set; }

        //Constractor 
        public Employee(int id,string name,Contract _contract,decimal Salary,string desc )
        {
            ID = id;
            FullName = name;
            Contract = _contract;
            StartingSalary = Salary;
            DescriptionJob = desc;
        }

        public override string ToString()
        {
            return $"ID : {ID}, FullName : {FullName} , Contract: {Contract},StartSalary {StartingSalary} ,Jop :{DescriptionJob}";
        }

        public int CompareTo(Employee? other)
        {
            return this.StartingSalary.CompareTo(other?.StartingSalary);
        }
    }

    enum Contract
    {
        FullTime,
        PartTime,
        Causal,
        Freelance
    }
}
