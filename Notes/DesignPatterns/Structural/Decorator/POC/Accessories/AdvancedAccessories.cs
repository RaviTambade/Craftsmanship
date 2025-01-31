using  Transflower.DesignPattern.Decorator.Transportation;
  
namespace Transflower.DesignPattern.Decorator.Accessories;

// Concrete Decorator    
public class AdvancedAccessories : VehicleAccessoriesDecorator   
{   
   public AdvancedAccessories(ITransport vehicle)   
   : base(vehicle)   
   {
  
   }   
  
   public override string GetDescription()   
   {   
      return base.GetDescription() + ",Advanced Accessories Package";   
   }   
  
   public override double GetCost()   
   {   
      return base.GetCost() + 10000.0;   
   }   
}   