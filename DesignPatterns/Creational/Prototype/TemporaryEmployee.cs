using System;
namespace Transflower.DesignPatterns.prototype
{
    
    public class TemporaryEmployee : Employee
    {
        public int FixedAmount { get; set; }
        public override Employee GetClone()
        {
            // MemberwiseClone Method Creates a shallow copy of the current System.Object
            return (TemporaryEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Temporary Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
        }
    }
}