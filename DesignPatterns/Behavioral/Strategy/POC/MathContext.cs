namespace Transflower.DesignPattern.Strategy;

public class MathContext
{
    private readonly IStrategy _istrategy;
    public MathContext(IStrategy istrategy)
    {
        _istrategy = istrategy;
    }
     public int ExecuteStrategy(int a, int b){
         return _istrategy.Execute(a, b);
     }
}