using System.Collections.Generic;
using System.Data;
 

namespace Transflower.DesignPatterns.Adapter.POC;

public class JSONDataSource:DataSource
{
    public  override List<User> GetSpecificData()
    {
        //Deserialize  data from json file
        //Get Collection of objects
        //return collection of object

        List<User> users = new List<User>();
        users.Add(new User{ Id=12, FirstName="jsonSameer", LastName="jsonVaidhya"});
        users.Add(new User{ Id=3, FirstName="jsonSameer", LastName="jsonVaidhya"});
        users.Add(new User{ Id=16, FirstName="jsonRajiv", LastName="jsonVarma"});
        return users;
    }
}