using System;
namespace Transflower.DesignPatterns.Prototype
{   
    public class Developer : Employee
    {
        public int FixedAmount { get; set; }
        public override Employee GetClone()
        {
            // shallow copy of the current System.Objectb (replica)
            return (Developer)this.MemberwiseClone();
        }
        public override void ShowDetails()
        {   Console.WriteLine("Developer");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
        }
    }
}
