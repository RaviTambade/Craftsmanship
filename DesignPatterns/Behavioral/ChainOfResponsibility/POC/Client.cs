using Transflower.DesignPatterns.ChainOfResponsibility;

public class Client
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var item in new List<string> { "Salary", "Laptop", "Soap" })
            {
                Console.WriteLine($"Client: Who wants a {item}?");

                var result = handler.Handle(item);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {item} was left untouched.");
                }
            }
        }
    }