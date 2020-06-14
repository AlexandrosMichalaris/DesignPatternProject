using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            SoftwareInterface os = factory.buildSoftware("OPERATING SYSTEM");
            os.createSoftware();

            SoftwareInterface drivers = factory.buildSoftware("DRIVERS");
            drivers.createSoftware();

            HardwareInterface motherboard = factory.buildHardware("MOTHERBOARD");
            motherboard.createCircuit();

            HardwareInterface microchip = factory.buildHardware("MICROCHIP");
            microchip.createCircuit();
        }
    }
}
