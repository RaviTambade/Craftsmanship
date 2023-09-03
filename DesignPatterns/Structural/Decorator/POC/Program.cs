using  Transflower.DesignPattern.Decorator.Car;
  
using Transflower.DesignPattern.Decorator.CarAccessories;


//But how to extend the functionality of an instance at run time? 
//The following code will explain that.

 //Create EcomomyCar instance.   
   ICar objCar = new EconomyCar(); 

    Console.Write("Car Detials: " + objCar.GetDescription()); 
   Console.Write("\nCar Price: " + objCar.GetCost()); 
   Console.WriteLine("\n\n");
   //Wrp EconomyCar instancw with BasicAccessories.   
   CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);   
   Console.Write("\nCar Detials for BasicAccessories : " + objAccessoriesDecorator.GetDescription()); 
   Console.Write("\nTotal Price for BasicAccessories : " + objAccessoriesDecorator.GetCost()); 
   Console.WriteLine("\n\n");  

   //Now , Wrap EconomyCar instance with AdvancedAccessories instance.   
   //objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);  

    //Console.Write("\nCar Detials for AdvancedAccessories : " + objAccessoriesDecorator.GetDescription());
    //Console.Write("\n Total Price Advanced : " + objAccessoriesDecorator.GetCost()); 

    /*When does a simple wrapper become the real decorator? The wrapper implements the same interface as the wrapped
     object. That’s why from the client’s perspective these objects are identical. 
     Make the wrapper’s reference field accept any object that follows that interface. 
    This will let you cover an object in multiple wrappers, adding the combined behavior of all the wrappers to it.*/