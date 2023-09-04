using  Transflower.DesignPattern.Decorator.Transportation;

// Abstract Decorator   
public abstract class VehicleAccessoriesDecorator : ITransport   
{   
  
   private ITransport _vehicle;   
  
   public VehicleAccessoriesDecorator(ITransport vehicle)   
   {   
      this._vehicle = vehicle;   
   }   
   public virtual string GetDescription()   
   {   
      return this._vehicle.GetDescription();   
   }   
  
   public virtual double GetCost()   
   {   
      return this._vehicle.GetCost();   
   }   
}   