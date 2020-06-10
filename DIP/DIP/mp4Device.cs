using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    class mp4Device
    {
        private WirelessMusicDeviceInterface device;
        private bool playingMusic;
        private bool bluetooth;

        public mp4Device(WirelessMusicDeviceInterface device)
        {
            this.device = device;
            this.playingMusic = false;
            this.bluetooth = true;
            connect();
        }

        public void playPauseMusic()
        {
            switch (playingMusic)
            {
                case true:
                    this.device.pauseMusic();
                    break;
                case false:
                    this.device.playMusic();
                    break;
            }
            playingMusic = !playingMusic;
        }

        public void switchSpeaker(WirelessMusicDeviceInterface device) /////////
        {
            if(device.GetType() != this.device.GetType()) 
            {
                playingMusic = false;
                this.device = device;
                Console.WriteLine("Device changed!");
                connect();
            }
        }

        public void connect()
        {
            if(this.bluetooth == true && this.device.isAvailable())
            {
                pair();
            }
        }

        public void pair()
        {
            Console.WriteLine("Paired with " + this.device.GetType().ToString());
        }
    }
}