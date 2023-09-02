using System;
namespace Transflower.DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an Instance of Permanent Employee Class
            Employee emp1 = new Manager()
            {
                Name = "Anurag",
                Department = "IT",
                Type = "Permanent",
                Salary = 100000
            };

            //Creating a Clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();

            // Changing the Name and Department Property Value of emp2 instance, 
            // will not change the Name and Department Property Value of the emp1 instance
            emp2.Name = "Pranaya";
            emp2.Department = "HR";


            emp1.ShowDetails();
            emp2.ShowDetails();


            // Creating an Instance of Temporary Employee Class
            Employee emp3 = new Developer()
            {
                Name = "Preety",
                Department = "HR",
                Type = "Temporary",
                FixedAmount = 200000
            };

            //Creating a Clone of the above Temporary Employee
            Employee emp4 = emp3.GetClone();

            // Changing the Name and Department Property Value of emp4 instance, 
            // will not change the Name and Department Property Value of the emp3 instance
            emp4.Name = "Priyanka";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();
            
            // Console.Read();



            // Creating an Instance of Temporary Employee Class
            Employee emp5 = new Tester()
            {
                Name = "Pragati",
                Department = "Testing",
                Type = "Temporary",
                FixedAmount = 250000
            };

            //Creating a Clone of the above Temporary Employee
            Employee emp6 = emp5.GetClone();

            // Changing the Name and Department Property Value of emp4 instance, 
            // will not change the Name and Department Property Value of the emp3 instance
            emp6.Name = "Samruddhi";
            emp6.Department = "Testing";
            emp5.ShowDetails();
            emp5.ShowDetails();
            
            Console.Read();
        }
    }
}