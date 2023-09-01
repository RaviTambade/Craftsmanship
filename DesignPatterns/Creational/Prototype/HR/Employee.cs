namespace Transflower.DesignPatterns.Prototype
{
    //The Prototype Abstract Class
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
       
        public abstract void ShowDetails();
        public abstract Employee GetClone();
    }
}