using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    class OperatingSystem : SoftwareInterface
    {
        public void createSoftware()
        {
            Console.WriteLine("Creating Operating System Software...");
            createKernel();
        }

        public void createKernel()
        {
            Console.WriteLine("Creating Kernel...");
        }
    }
}
