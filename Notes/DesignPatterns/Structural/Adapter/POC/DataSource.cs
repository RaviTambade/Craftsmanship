using System.Collections.Generic;
namespace Transflower.DesignPatterns.Adapter.POC;

    public abstract  class DataSource
    {
        public abstract  List<User> GetSpecificData();
        
    }