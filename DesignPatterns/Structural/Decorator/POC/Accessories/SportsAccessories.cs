using  Transflower.DesignPattern.Decorator.Transportation;
  
namespace Transflower.DesignPattern.Decorator.Accessories;
 
/// Concrete Decorator   

public class SportsAccessories : VehicleAccessoriesDecorator   
{   
   public SportsAccessories(ITransport vehicle)   
   : base(vehicle)   
   {   
  
   }   
  
   public override string GetDescription()   
   {   
      return base.GetDescription() + ",Sports Accessories Package";   
   }   
  
   public override double GetCost()   
   {   
      return base.GetCost() + 15000.0;   
   }   
}   