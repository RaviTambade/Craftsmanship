using  Transflower.DesignPattern.Decorator.Car;

// Abstract Decorator   
namespace Transflower.DesignPattern.Decorator.CarAccessories;
public abstract class CarAccessoriesDecorator : ICar   
{   
  
   private ICar _car;   
  
   public CarAccessoriesDecorator(ICar aCar)   
   {   
      this._car = aCar;   
   }   
   public virtual string GetDescription()   
   {   
      return this._car.GetDescription();   
   }   
  
   public virtual double GetCost()   
   {   
      return this._car.GetCost();   
   }   
}   