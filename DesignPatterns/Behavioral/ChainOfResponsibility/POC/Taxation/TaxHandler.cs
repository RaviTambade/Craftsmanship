using Transflower.DesignPatterns.ChainOfResponsibility;

public abstract class TaxHandler : ITaxHandler
    {
        private ITaxHandler _nextHandler;
        public ITaxHandler SetNext(ITaxHandler taxHandler)
        {
            this._nextHandler = taxHandler;
            return taxHandler;
        }
        
        public virtual object Deduct(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Deduct(request);
            }
            else
            {
                return null;
            }
        }
    }
