using  Transflower.Composite.OrderProcessing;

Order order1=new Order();
order1.Add(new Item{ TheProduct=new Product{ Id=1,Title="Gerbera",UnitPrice=8, SalesTax=0.05,Subsidy=4},Quantity=50});
order1.Add(new Item{ TheProduct=new Product{ Id=1,Title="Rose",UnitPrice=15, SalesTax=0.20,Subsidy=1},Quantity=10});
order1.Add(new Item{ TheProduct= new Product{ Id=1,Title="Lotus",UnitPrice=25, SalesTax=0.20,Subsidy=15},Quantity=5});

double totalAmount=order1.GetTotalAmount();
Console.WriteLine("Order Amount to be paid={0}", totalAmount);