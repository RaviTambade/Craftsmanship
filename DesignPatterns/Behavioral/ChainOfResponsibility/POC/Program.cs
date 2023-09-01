using Transflower.DesignPatterns.ChainOfResponsibility;

var incomeTax = new IncomeTaxHandler();
var professionalTax = new GoodsServiceTaxHandler();
var salesTax = new SalesTaxHandler();

incomeTax.SetNext(incomeTax).SetNext(salesTax);

// The client should be able to send a request to any handler, not
// just the first one in the chain.
Console.WriteLine("Chain: Salary > Laptop > Soap\n");
Client.ClientCode(incomeTax);
Console.WriteLine();

// Console.WriteLine("Subchain: Squirrel > Dog\n");
// Client.ClientCode(squirrel);

// Console.WriteLine("Dog");
// Client.ClientCode(dog);