using Transflower.DesignPatterns.Iterator;
  
   
        ITransportList transports = new TransportList();

        transports.Add(new Truck("MH14-5634","Tata Motors", "Yoddha", 2020,2));
        transports.Add(new Truck("MH14-9874","Hinduja Motors", "Ashok Leylond", 2018,1));
        transports.Add(new Truck("MH14-2544","Hinduja Motors", "Ashok Leylond", 2018,2));
        transports.Add(new Traveller("MH14-5764","Force Motors", "Tempo Traveller", 2018,12));
        transports.Add(new Traveller("MH14-5645","Force Motors", "Tempo Trax", 2018,6));
         
        IIterator<Transport> iterator = transports.CreateIterator();
        Console.WriteLine("Our Transports:");
        IterateAndShowTransports(iterator);


    static void IterateAndShowTransports(IIterator<Transport> iterator)
    {
        while (iterator.HasNext())
        {
            Transport currentTransport = iterator.Next();
            Console.WriteLine($"Make: {currentTransport.Make}, Model: {currentTransport.Model}, Year: {currentTransport.Year}");

            if (currentTransport is Truck truck)
            {
                Console.WriteLine($"Type: Truck, Number of Axel: {truck.Axel}");
            }
            else if (currentTransport is Traveller traveller)
            {
                Console.WriteLine($"Type: Travelller, Has Seat: {traveller.Seats}");
            }

            Console.WriteLine();
        }
    }

/*Encapsulating iteration is the core idea behind the iterator pattern. 
To encapsulate a behaviour means to place the code that implements the behaviour
 into a type and hide the implementation details away from consumers of the type*/

/*The Iterator Pattern is a behavioral design pattern used in software engineering to 
provide a way to access the elements of a collection (such as an array, list, or other
 data structure) sequentially without exposing the underlying representation of the 
 collection. It separates the iteration logic from the collection, making the code more
  modular and flexible.*/