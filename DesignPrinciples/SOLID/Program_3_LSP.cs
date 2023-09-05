using System;

//Liskov Substitution Principle (LSP)

namespace Demo
{
 
   public abstract class Shape
   {
      public abstract string Draw();
   }
   
   public class Triangle: Shape
   {
      public override string Draw()
      {
         return "Drawing Triangle";
      }
   }
   
   public class Circle: Triangle
   {
      public override string Draw()
      {
         return " Drawing Circle";
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         Shape shape = new Circle();
         Console.WriteLine(shape.Draw());
         
         shape = new Triangle ();
         Console.WriteLine(shape.Draw());
      }
   }
}