using System.Collections.Generic;
using System.Data;
using System.Xml.Serialization;

namespace Transflower.DesignPatterns.Adapter.POC;

public class XMLDataSource:DataSource
{
    public  override List<User> GetSpecificData()
    {
        //Deserialize  data from xml file
        //Get Collection of objects
        //return collection of object

        List<User> users = new List<User>();
        users.Add(new User{ Id=12, FirstName="xmlSameer", LastName="xmlVaidhya"});
        users.Add(new User{ Id=3, FirstName="xmlSameer", LastName="xmlVaidhya"});
        users.Add(new User{ Id=16, FirstName="xmlRajiv", LastName="xmlVarma"});
        return users;
    }
}