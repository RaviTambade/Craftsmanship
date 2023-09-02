using Transflower.DesignPatterns.ChainOfResponsibility;

public class Government
    {
        // The Execute is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static void Execute(TaxHandler tax)
        {
            List<string> commerceItems= new List<string>();
          
            commerceItems.Add("Salary");
            commerceItems.Add("Laptop");
            commerceItems.Add("Soap");
            commerceItems.Add("PuneMetro");
            
            foreach (var item in commerceItems )
            {
                Console.WriteLine($"Citizen: Who wants a {item}?");
                var result = tax.Deduct(item);
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