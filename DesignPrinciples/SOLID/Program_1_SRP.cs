using System;

//Single Responsibility Principle (SRP)
/*
    A class should have one and only one reason to change, 
    meaning that a class should have only one job.
*/

namespace Messaging
{
    public class Message{

    }


    public class MessagingServerOld
    {
        public void DoGetMessage()
        {
            //Open the gate functinality
        }
    
        public void PerformService(Message Message)
        {
            //Check if garage is opened
            //finish the Message service
        }
    
        public void DoDispatch()
        {
            //Close the gate functinality
        }
    }
    
    public interface IMessageUtility
        {
            void GetMessage();
            void TranslateMessage();
            void Dispatch();
        }

   public class ServerUtility : IMessageUtility
    {
        public void GetMessage()
        {
            //Open the Garage for service
        }
    
        public void Dispatch()
        {
            //Close the Garage functionlity
        }

         public void TranslateMessage()
        {
            //Close the Garage functionlity
        }
    }

    public class Server
    {
        IMessageUtility utility;
    
        public Server(IMessageUtility msgUtil)
        {
            this.utility = msgUtil;
        }
        public void OpenForService()
        {
            utility.GetMessage();
        }
        public void DoService()
        {
            //Check if service station is opened and then
            //finish the Message service
        }
        public void DispatchMessage()
        {
        utility.Dispatch();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string fullName="Ravi Tambade";
            Console.WriteLine("FullName " + fullName);
            Console.WriteLine("Hello World!");
        }
    }
}
