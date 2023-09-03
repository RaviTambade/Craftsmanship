namespace Transflower.DesignPattern.Decorator.Car;
// Concrete Car      
public class DeluxCar : ICar   
{   
   public string GetDescription()   
   {   
      return "Delux Car";   
   }   
  
   public double GetCost()   
   {   
      return 750000.0;   
   }   
} 