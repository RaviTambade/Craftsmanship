using System;
namespace Transflower.DesignPattern.Mediator{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Instance of Mediator i.e. Creating a Transflower Group
            ITransflowerGroupMediator transflowerMediator = new TransflowerGroupMediator();

            //Create instances of Colleague i.e. Creating users
            User Abhay = new Employee("Abhay : Employee 1 ");
            User Shubham = new Employee("Shubham  : Employee 2 ");
            User Akash = new Employee("Akash  : Employee 3 ");
            User Rishikesh = new Employee("Rishikesh : Employee 4 ");
            User Pragati = new Employee("Pragati : Employee 5 ");
            User Sahil = new Employee("Sahil : Employee 6 ");
            User Akshay = new Employee("Akshay : Employee 7 ");
            User Vedant = new Employee("Vedant : Employee 8 ");

            //Registering the users with the Mediator i.e. Transflower Group
            transflowerMediator.RegisterUser(Abhay);
            transflowerMediator.RegisterUser(Shubham);
            transflowerMediator.RegisterUser(Akash);
            transflowerMediator.RegisterUser(Rishikesh);
            transflowerMediator.RegisterUser(Pragati);
            transflowerMediator.RegisterUser(Sahil);
            transflowerMediator.RegisterUser(Akshay);
            transflowerMediator.RegisterUser(Vedant);

            //One of the users Sending one Message in the Transflower Group
            Abhay.Send("Ravi sir ask to join the meeting,");
            Console.WriteLine();

            Console.Read();
        }
    }
}