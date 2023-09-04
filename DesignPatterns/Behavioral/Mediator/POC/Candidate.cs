using  Transflower.DesignPattern.Mediator;

namespace Transflower.DesignPattern.Mediator
{
    
    // Colleague
    // This is going to be an abstract class that defines a property that holds a reference to a mediator.    
    public abstract class Candidate
    {
        //This Property holds the name of the candidate
        protected string Name;

        //This Property is going to set and get the Mediator Instance
        //This Property value is going to be set when we register a candidate with the Mediator
        public   IRecruiter CoOrdinator { get; set; }
        
        //Initializing the name using Constructor
        public Candidate(string name)
        {
            this.Name = name;
        }

        //The following Methods are going to be Implemented by the Concrete Colleague
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}