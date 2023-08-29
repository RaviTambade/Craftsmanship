using System.Collections.Generic;
namespace Transflower.DesignPatterns.Adapter.POC;

    public class DbDataSource:DataSource
    {
         public override List<User> GetSpecificData()
        {
            //In Database  Data
           List<User> users = new List<User>();

           //database connection logic to fetch list of users from remote database

           users.Add(new User{ Id=12, FirstName="dbSameer", LastName="dbVaidhya"});
           users.Add(new User{ Id=3, FirstName="dbSameer", LastName="dbVaidhya"});
           users.Add(new User{ Id=16, FirstName="dbRajiv", LastName="dbVarma"});
          
            return users;
        }
    }