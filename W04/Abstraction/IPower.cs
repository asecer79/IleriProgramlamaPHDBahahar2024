using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Abstraction
{
    public interface IPower:IPowerUsage  //inheritance, supports multiple inheritance
    {
        void TurnOn();
        void TurnOff();
    }

    public interface IPowerUsage
    {
        void ShowConsumption();
    }

    public class Lamp:IPower    //implementation
    {
        public void TurnOn()
        {
            Console.WriteLine("Lamp turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lamp turned off.");
        }

        public void ShowConsumption()
        {
            throw new NotImplementedException();
        }
    }

    public class ElectronicDevice
    {
        
    }

    public class Computer : ElectronicDevice, IPower, IPowerUsage  //hybrid inh.
    {
        public void TurnOn()
        {
            Console.WriteLine("Computer booted up.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Computer shut down.");
        }

        public void ShowConsumption()
        {
           //...
        }
    }
}
