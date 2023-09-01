namespace Transflower.DesignPatterns.Command
{
    //ConcreteCommand B 
    //It defines a binding between a Receiver Object i.e. Document and an Action i.e. Save
    class SaveCommand : ICommand
    {
        //Reference of Receiver Object
        private Document document;
        //Initializing the Receiver Object using the Constructor
        public SaveCommand(Document doc)
        {
            document = doc;
        }
        //Execute Method will internally call the Receiver Object Save Method
        public void Execute()
        {
            document.OnSave();
        }
    }
}