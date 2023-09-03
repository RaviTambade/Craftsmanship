using  Transflower.DesignPattern.Decorator.Car;
  
namespace Transflower.DesignPattern.Decorator.CarAccessories;
// Concrete Decorator   
//Here we successfully avoided the sub classing issue. 
//Whenever we need to add a new car category we only must add one class for it like the following.
public class BasicAccessories : CarAccessoriesDecorator   
{   
   public BasicAccessories(ICar aCar)   
   : base(aCar)   
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