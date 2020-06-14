using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class Factory
    {
        public SoftwareInterface buildSoftware(String product)
        {
            switch(product.ToUpper())
            {
                case "DRIVERS":
                    return new Drivers();

                case "OPERATING SYSTEM":
                    return new OperatingSystem();

                default:
                    Console.WriteLine("product is unknown");
                    throw new ArgumentException();
            }
        }

        public HardwareInterface buildHardware(String product)
        {
            switch(product.ToUpper())
            {
                case "MOTHERBOARD":
                    return new Motherboard();
                case "MICROCHIP":
                    return new Microchip();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
