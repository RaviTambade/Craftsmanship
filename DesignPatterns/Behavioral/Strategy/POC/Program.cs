using Transflower.DesignPattern.Strategy;

IStrategy strategy1 = new AdditionStrategy();
IStrategy strategy2 = new SubtractionStrategy();
IStrategy strategy3 = new MultiplicationStrategy();
MathContext context = new MathContext(strategy3);

int ans = context.ExecuteStrategy(10,5);
Console.WriteLine("Ans is : "+ans);
