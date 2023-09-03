using System;
using System.Collections.Generic;

namespace Transflower.DesignPatterns.Visitor{
    public class President : Employee
    {
        // Constructor
        public President()
            : base("vishal", 45000.0, 21)
        {
        }
    }
}