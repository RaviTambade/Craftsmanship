using  Transflower.DesignPattern.Decorator.Transportation;
  
namespace Transflower.DesignPattern.Decorator.Accessories;
// Concrete Decorator   
//Here we successfully avoided the sub classing issue. 
//Whenever we need to add a new car category we only must add one class for it like the following.
public class BasicAccessories : VehicleAccessoriesDecorator   
{   
   public BasicAccessories(ITransport vehicle)   
   : base(vehicle)   
   {   
  
   }   
  
   public override string GetDescription()   
   {   
      return base.GetDescription() + ",Basic Accessories Package";   
  
   }   
  
   public override double GetCost()   
   {   
      return base.GetCost() + 2000.0;   
   }   
}   