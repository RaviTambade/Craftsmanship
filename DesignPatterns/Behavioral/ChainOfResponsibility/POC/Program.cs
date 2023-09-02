using Transflower.DesignPatterns.ChainOfResponsibility;

var incomeTax = new IncomeTaxHandler();
var professionalTax = new GoodsServiceTaxHandler();
var salesTax = new SalesTaxHandler();
var metroTax=new MetroTaxHandler();

//Build Chain
incomeTax.SetNext(professionalTax).SetNext(salesTax).SetNext(metroTax);

// The client should be able to send a request to any handler, not
// just the first one in the chain.
Console.WriteLine("Chain: Salary > Laptop > Soap> Mentro\n");
Government.Execute(incomeTax);
Console.WriteLine();