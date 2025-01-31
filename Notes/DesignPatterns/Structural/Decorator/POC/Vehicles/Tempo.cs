namespace Transflower.DesignPattern.Decorator.Transportation;
// Concrete Car      
public class Tempo : ITransport   
{   
   public string GetDescription()   
   {   
      return "Tempo Traveller";   
   }   
  
   public double GetCost()   
   {   
      return 750000.0;   
   }   
} 