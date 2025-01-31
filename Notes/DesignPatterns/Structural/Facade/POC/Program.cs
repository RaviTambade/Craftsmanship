using Transfolwer.DesignPattern.Facade;

IOrderProcessor theOrder = new OrderProcessingSystem();
theOrder.PlaceOrder("Phone", 2, 800, "Ratnagiri");
Console.WriteLine();
