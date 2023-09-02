namespace Transflower.DesignPatterns.Iterator;
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
