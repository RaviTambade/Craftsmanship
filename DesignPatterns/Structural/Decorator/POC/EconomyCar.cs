
namespace Transflower.DesignPattern.Decorator.Car;
// Concrete Car   
 
public class EconomyCar : ICar   
{   
   public string GetDescription()   
   {   
      return "Economy Car";   
   }   
  
   public double GetCost()   
   {   
      return 450000.0;   
   }   
}   