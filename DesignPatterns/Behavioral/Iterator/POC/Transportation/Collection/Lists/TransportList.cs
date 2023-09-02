namespace Transflower.DesignPatterns.Iterator;
using System.Collections.Generic;
public class TransportList : ITransportList
{
    private List<Transport> transports = new List<Transport>();

    public void Add(Transport transport)
    {
        transports.Add(transport);
    }

    public IIterator<Transport> CreateIterator()
    {
        return new TransportIterator(transports);
    }
}
