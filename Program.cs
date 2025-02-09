using System.Collections.Concurrent;
using Youtube_Videos_Advanced_c_.Examples_Classes;

namespace Youtube_Videos_Advanced_c_
{
    internal class Program
    {
        #region Content
        //1 List
        //2 List Of Objects
        //3 Sort List OF Objects
        #endregion
        static void Main(string[] args)
        {
            #region Make List Of Employee
            List<Employee> employees = new List<Employee>();
            //Add Emplyee
             employees.Add(new Employee(1, "mohamed Hesham", Contract.FullTime, 10000, "Developer"));
             employees.Add(new Employee(2, "Amr ALi", Contract.PartTime, 6000, "Front End"));
             employees.Add(new Employee(3, "omar Ahmed", Contract.Freelance, 5000, "Mobile Developer"));


            Console.WriteLine("----------Befor Sorting List----------");
            foreach (Employee employee in employees) 
                Console.WriteLine(employee);

            employees.Sort();//Sorting List Of Employees

            Console.WriteLine("----------After Sorting List----------");
            foreach (Employee employee in employees)
                Console.WriteLine(employee);
            #endregion
        }
    }
}
