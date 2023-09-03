using  Transflower.DesignPattern.Decorator.Car;
  
namespace Transflower.DesignPattern.Decorator.CarAccessories;

// Concrete Decorator    
public class AdvancedAccessories : CarAccessoriesDecorator   
{   
   public AdvancedAccessories(ICar aCar)   
   : base(aCar)   
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