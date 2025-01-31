namespace Transflower.DesignPatterns.Iterator;
using System.Collections.Generic;

public class TransportIterator : IIterator<Transport>
{
    private List<Transport> transports;
    private int currentIndex = 0;

    public TransportIterator(List<Transport> transports)
    {
        this.transports = transports;
    }

    public bool HasNext()
    {
        return currentIndex < transports.Count;
    }

    public Transport Next()
    {
        Transport transport = transports[currentIndex];
        currentIndex++;
        return transport;
    }


    public Transport Previous()
    {
         --currentIndex;
        Transport transport = transports[currentIndex];
        return transport;
    }


}
