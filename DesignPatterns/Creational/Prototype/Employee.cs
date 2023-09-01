namespace Transflower.DesignPatterns.prototype
{
    //The Prototype Abstract Class
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
        public abstract Employee GetClone();
        public abstract void ShowDetails();
    }
}