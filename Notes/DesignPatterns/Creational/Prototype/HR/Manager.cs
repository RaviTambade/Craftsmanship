using System;
namespace Transflower.DesignPatterns.Prototype
{ 
    public class Manager : Employee
    {
        public int Salary { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine("Manager");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, Salary: {this.Salary}\n");
        }
        
        public override Employee GetClone()
        {
            // shallow copy of the current System.Objectb (replica)
            return (Manager)this.MemberwiseClone();
        }

    }
}

//each class in C# is derived from Object class
//Important methods of Object 
// ToString()
// GetType()
// GetHashCode()
// Equals
// MemberwiseClone()
