using System;
using System.Collections.Generic;

namespace Transflower.DesignPatterns.Visitor{
    public class Director : Employee
    {
        // Constructor
        public Director()
            : base("Rohit", 35000.0, 16)
        {
        }
    }
}