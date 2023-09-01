using System;
namespace Transflower.DesignPatterns.Command
{
    // Receiver Object 
    // The Receiver contains the business logic. 
    // They know how to perform all kinds of operations
    // They Know how to handle the Request i.e. Performing the actual Operation
    public class Document
    {
        public void OnOpen()
        {
            Console.WriteLine("Document Opened");
        }
        public void OnSave()
        {
            Console.WriteLine("Document Saved");
        }
        public void OnClose()
        {
            Console.WriteLine("Document Closed");
        }
    }
}