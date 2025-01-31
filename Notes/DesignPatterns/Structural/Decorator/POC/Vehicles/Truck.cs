
namespace Transflower.DesignPattern.Decorator.Transportation;
// Concrete Car   
 
public class Truck : ITransport   
{   
   public string GetDescription()   
   {   
      return "Goods Carrier Truck";   
   }   
  
   public double GetCost()   
   {   
      return 450000.0;   
   }   
}   