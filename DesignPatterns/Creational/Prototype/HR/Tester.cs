using System;
namespace Transflower.DesignPatterns.Prototype
{ 
    public class Tester : Employee
    {
        public int FixedAmount { get; set; }
        public override Employee GetClone()
        {
            // shallow copy of the current System.Objectb (replica)
            return (Tester)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Tester");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
        }
    }
}