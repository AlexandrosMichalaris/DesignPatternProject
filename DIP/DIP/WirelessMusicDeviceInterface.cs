using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    interface WirelessMusicDeviceInterface
    {
        public void playMusic();
        public void pauseMusic();
        public bool isAvailable();
    }
}
