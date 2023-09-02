using System;

namespace Transflower.DesignPattern.Mediator{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Transflower Acceleration Program (TAP) \n \n \n ");
            //Create an Instance of Mediator i.e. Creating a Transflower Group
            IRecruiter  recruiter = new ITRecruiter();

            //Create instances of Colleague i.e. Creating users
            Candidate Abhay = new FreelanceDeveloper("Abhay : Transflower 1 ");
            Candidate Shubham = new FreelanceDeveloper("Shubham  : Transflower 2 ");
            Candidate Akash = new FreelanceDeveloper("Akash  : Transflower 3 ");
            Candidate Rishikesh = new FreelanceDeveloper("Rishikesh : Transflower 4 ");
            Candidate Pragati = new FreelanceDeveloper("Pragati : Transflower 5 ");
            Candidate Sahil = new FreelanceDeveloper("Sahil : Transflower 6 ");
            Candidate Akshay = new FreelanceDeveloper("Akshay : Transflower 7 ");
            Candidate Vedant = new FreelanceDeveloper("Vedant : Transflower 8 ");

            //Registering the users with the Mediator i.e. Transflower Group
            recruiter.RegisterUser(Abhay);
            recruiter.RegisterUser(Shubham);
            recruiter.RegisterUser(Akash);
            recruiter.RegisterUser(Rishikesh);
            recruiter.RegisterUser(Pragati);
            recruiter.RegisterUser(Sahil);
            recruiter.RegisterUser(Akshay);
            recruiter.RegisterUser(Vedant);

            //One of the users Sending one Message in the Transflower Group
            Abhay.Send("Ravi sir ask to appear for interview...");
            Console.WriteLine();
            Console.Read();
        }
    }
}