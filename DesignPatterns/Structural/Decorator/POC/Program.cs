using Transflower.DesignPattern.Decorator.Accessories;
using Transflower.DesignPattern.Decorator.Transportation;
 

//But how to extend the functionality of an instance at run time? 
//The following code will explain that.

//Create EcomomyTransport instance.   
ITransport theTransport = new Truck(); 

    Console.Write("Transport Detials: " + theTransport.GetDescription()); 
   Console.Write("\nTransport Price: " + theTransport.GetCost()); 
   Console.WriteLine("\n\n");
   //Wrp EconomyTransport instancw with BasicAccessories.   
   VehicleAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(theTransport);   
   Console.Write("\nTransport Detials for BasicAccessories : " + objAccessoriesDecorator.GetDescription()); 
   Console.Write("\nTotal Price for BasicAccessories : " + objAccessoriesDecorator.GetCost()); 
   Console.WriteLine("\n\n");  

   //Now , Wrap EconomyTransport instance with AdvancedAccessories instance.   
   //objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);  

    //Console.Write("\nTransport Detials for AdvancedAccessories : " + objAccessoriesDecorator.GetDescription());
    //Console.Write("\n Total Price Advanced : " + objAccessoriesDecorator.GetCost()); 

    /*When does a simple wrapper become the real decorator? The wrapper implements the same interface as the wrapped
     object. That’s why from the client’s perspective these objects are identical. 
     Make the wrapper’s reference field accept any object that follows that interface. 
    This will let you cover an object in multiple wrappers, adding the combined behavior of all the wrappers to it.*/