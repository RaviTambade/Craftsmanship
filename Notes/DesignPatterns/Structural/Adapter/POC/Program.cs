using System.Collections.Generic;
using System;

using Transflower.DesignPatterns.Adapter.POC;

    class Program
    {
        static void Main(string[] args)
        {
           // DataSource  ds= new  XMLDataSource();
            DataSource ds = new JSONDataSource();
            IConnector connector = new Connector(ds);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            List<User> receiveData=connector.GetData();
            foreach(User s in receiveData){
                Console.WriteLine(s.FirstName + "  "+ s.LastName);
            }
        }
    }

