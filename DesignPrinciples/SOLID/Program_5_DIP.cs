using System;

namespace  DIP
{
    public interface IAutomobile
    {
        void Ignition();
        void Stop();
    }

    public class Jeep : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }
        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
    }
 
    public class SUV : IAutomobile
    {
        public void Ignition()
        {
        Console.WriteLine("SUV start");
        }
        public void Stop()
        {
        Console.WriteLine("SUV stopped.");
        }
    }

    public class AutomobileController
    {
        IAutomobile m_Automobile;
        public AutomobileController(IAutomobile automobile)
        {
            this.m_Automobile = automobile;
        } 
        public void Ignition()
        {
            m_Automobile.Ignition();
        }  
        public void Stop()
        {
            m_Automobile.Stop();
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            IAutomobile automobile = new Jeep();
            //IAutomobile automobile = new SUV();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobile.Ignition();
            automobile.Stop();
            Console.Read();
        }
    }
}