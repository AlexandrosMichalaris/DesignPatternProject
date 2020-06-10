using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class WirelessEarpods : WirelessMusicDeviceInterface
    {
        private bool availability;

        public WirelessEarpods()
        {
            availability = true;
        }

        public bool isAvailable()
        {
            return availability;
        }

        public void pauseMusic()
        {
            Console.WriteLine("Music is Paused!");
        }

        public void playMusic()
        {
            Console.WriteLine("Playing Music from wireless earpods...");
        }
    }
}
