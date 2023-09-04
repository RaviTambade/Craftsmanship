namespace Transflower.DesignPatterns.ChainOfResponsibility
{
    // The Handler interface declares a method for building the chain of
    // handlers. It also declares a method for executing a request.
    public interface ITaxHandler
    {
        ITaxHandler SetNext(ITaxHandler handler);
        object Deduct(object request);
    }
}