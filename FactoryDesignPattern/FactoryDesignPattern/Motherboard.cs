using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class Motherboard : HardwareInterface
    {
        public void createCircuit()
        {
            Console.WriteLine("Creating Motherbeards Circuit...");
        }
    }
}
