namespace Transflower.DesignPattern.Mediator
{
    //Mediator Interface
    //This is going to be an Interface that defines operations 
    //which can be called by colleague objects for communication.
    public interface IRecruiter
    {
        //This Method is used to send the Message who are registered as candidate
        void SendMessage(string msg, Candidate candidate);
        //This method is used to register a candidate
        void RegisterCandidate(Candidate candidate);
    }
}