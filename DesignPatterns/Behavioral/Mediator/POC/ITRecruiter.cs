using System.Collections.Generic;
namespace Transflower.DesignPattern.Mediator
{

    // Concrete Mediator
    // This is going to be a class implementing the communication operations of the Mediator Interface.
    public class ITRecruiter : IRecruiter
    {
        //The following variable is going to hold the list of objects to whom we want to communicate
        private List<Candidate> UsersList = new List<Candidate>();

        //The following method simply registers the user with Mediator
        public void RegisterUser(Candidate candidate)
        {
            //Adding the user
            UsersList.Add(candidate);
            //Registering the user with Mediator
            candidate.CoOrdinator = this;
        }

        //The following method is going to send the message in the group i.e. to the group users
        public void SendMessage(string message, Candidate user)
        {
            foreach (Candidate u in UsersList)
            {
                //Message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}