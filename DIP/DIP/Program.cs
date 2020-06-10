using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            WirelessMusicDeviceInterface earpods = new WirelessEarpods();
            WirelessMusicDeviceInterface speaker = new BluetoothSpeaker();
            mp4Device phone = new mp4Device(earpods);
            phone.playPauseMusic();
            phone.playPauseMusic();
            phone.switchSpeaker(speaker);
            phone.playPauseMusic();
            phone.playPauseMusic();
        }
    }
}
