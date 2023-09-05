using System;
//Open Closed Principle (OCP)

namespace Test
{
   
 public class Shape
 {
    public virtual string GetShape()
    {
        return "Shape";
    }

 }
 
 public class Circle: Shape
 {
    public override string GetShape()
    {
        return "Circle";
    }
 }

    class Program_3
    {
        static void Main(string[] args)
        {
            Shape triangle = new Circle();
            Console.WriteLine(triangle.GetShape());
  
        }
    }
}