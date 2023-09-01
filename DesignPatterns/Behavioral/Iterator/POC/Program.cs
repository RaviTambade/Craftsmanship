using DesignPattern.Iterator;

ConcreteCollection collection = new ConcreteCollection();
collection.AddEmployee(new Employee(1, "Abhay"));
collection.AddEmployee(new Employee(2, "Sahil"));
collection.AddEmployee(new Employee(3, "Shubham"));
collection.AddEmployee(new Employee(4, "Akshay"));
collection.AddEmployee(new Employee(5, "Akash"));
collection.AddEmployee(new Employee(6, "Pragati"));
Iterator iterator = collection.CreateIterator();

Console.WriteLine("Iterating over collection:");

for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
  Console.WriteLine($"ID : {emp.Id} & Name : {emp.Name}");
}
/*Encapsulating iteration is the core idea behind the iterator pattern. 
To encapsulate a behaviour means to place the code that implements the behaviour
 into a type and hide the implementation details away from consumers of the type*/

/*The Iterator Pattern is a behavioral design pattern used in software engineering to 
provide a way to access the elements of a collection (such as an array, list, or other
 data structure) sequentially without exposing the underlying representation of the 
 collection. It separates the iteration logic from the collection, making the code more
  modular and flexible.*/