using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class Microchip : HardwareInterface
    {
        public void createCircuit()
        {
            Console.WriteLine("Creating Microchip circuit... ");
        }
    }
}
