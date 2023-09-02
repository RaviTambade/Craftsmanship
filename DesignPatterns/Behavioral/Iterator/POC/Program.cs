using Transflower.DesignPatterns.Iterator;
        IVehicleList vehicleList = new VehicleList();
        vehicleList.AddVehicle(new Car("Toyota", "Innova", 2022, 4));
        vehicleList.AddVehicle(new Motorcycle("Hero", "Splendor", 2021, true));
        vehicleList.AddVehicle(new Car("Ford", "Figo", 2023, 4));

        IIterator<Vehicle> iterator = vehicleList.CreateIterator();

        Console.WriteLine("List of Vehicles:");
        IterateAndPrintVehicles(iterator);


    static void IterateAndPrintVehicles(IIterator<Vehicle> iterator)
    {
        while (iterator.HasNext())
        {
            Vehicle vehicle = iterator.Next();
            Console.WriteLine($"Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}");

            if (vehicle is Car car)
            {
                Console.WriteLine($"Type: Car, Number of Doors: {car.NumDoors}");
            }
            else if (vehicle is Motorcycle motorcycle)
            {
                Console.WriteLine($"Type: Motorcycle, Has Windshield: {motorcycle.HasWindshield}");
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