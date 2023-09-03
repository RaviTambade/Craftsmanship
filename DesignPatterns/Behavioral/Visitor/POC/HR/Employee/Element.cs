using System;
using System.Collections.Generic;

namespace Transflower.DesignPatterns.Visitor{
    public abstract class Element
    {
         public abstract void Accept(IVisitor visitor);
    }
}