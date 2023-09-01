namespace DesignPattern.Iterator;
public class ConcreteCollection : IAbstractCollection
{
    List<Employee> employees = new List<Employee>();
    public int Count
    {
        get { return employees.Count; }
    }
    public Iterator CreateIterator()
    {
        return new Iterator(this);
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public Employee GetEmployee(int IndexPosition)
    {
        return employees[IndexPosition];
    }
}