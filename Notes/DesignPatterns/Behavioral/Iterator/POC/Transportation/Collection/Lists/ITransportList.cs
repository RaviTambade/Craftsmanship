namespace Transflower.DesignPatterns.Iterator;
public interface ITransportList
{
    void Add(Transport transport);
    IIterator<Transport> CreateIterator();
}
