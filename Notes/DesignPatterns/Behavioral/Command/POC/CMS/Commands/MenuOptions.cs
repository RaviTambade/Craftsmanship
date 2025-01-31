namespace Transflower.DesignPatterns.Command
{
    // Invoker  
    // The Invoker is associated with one or several commands. 
    // It sends a request to the command.
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;
        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickOpen()
        {
            openCommand.Execute();
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickSave()
        {
            saveCommand.Execute();
        }
        //The Invoker cannot handle the Request, so it internally calls the Execute Method
        //of the Command Object. 
        public void ClickClose()
        {
            closeCommand.Execute();
        }
    }
}