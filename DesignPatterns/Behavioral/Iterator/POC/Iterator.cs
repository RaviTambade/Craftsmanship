namespace DesignPattern.Iterator;
public class Iterator : IAbstractIterator
{
    private ConcreteCollection _concreteCollection;
    private int Current=0;
    private readonly int Step = 1;

    public Iterator(ConcreteCollection concreteCollection){
_concreteCollection=concreteCollection;
    }
    public Employee First()
    {
         Current=0;
        return _concreteCollection.GetEmployee(Current);
    }

   public Employee Next()
        {
            Current += Step;
            if (!IsCompleted)
            {
                return _concreteCollection.GetEmployee(Current);
            }
            else
            {
                return null;
            }
        }

      public bool IsCompleted
        {
            get { return Current >=_concreteCollection.Count; }
        }

}