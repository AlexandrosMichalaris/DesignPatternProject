using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class OperatingSystem : ElectronicDeviceInterface, SoftwareInterface
    {
        private Guid mac;

        public OperatingSystem()
        {
            this.mac = setMACaddress();
        }

        public void createSoftware()
        {
            Console.WriteLine("Creating Software...");
            createKernel();
        }

        public void createKernel()
        {
            Console.WriteLine("Creating Kernel...");
        }

        public Guid setMACaddress()
        {
            return Guid.NewGuid();
        }
    }
}
