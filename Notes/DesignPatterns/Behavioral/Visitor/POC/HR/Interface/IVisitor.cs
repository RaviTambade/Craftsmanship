using System;
using System.Collections.Generic;

namespace Transflower.DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
