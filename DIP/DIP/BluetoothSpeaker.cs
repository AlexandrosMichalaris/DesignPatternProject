using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class BluetoothSpeaker : WirelessMusicDeviceInterface
    {
        private bool availability;

        public BluetoothSpeaker()
        {
            availability = true;
        }

        public bool isAvailable()
        {
            return availability;
        }

        public void pauseMusic()
        {
            Console.WriteLine("Music is paused!");
        }

        public void playMusic()
        {
            Console.WriteLine("Playing Music from bluetooth speaker...");
        }
    }
}
