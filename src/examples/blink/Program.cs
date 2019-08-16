using Piface.Digitalio;
using System;
using System.Threading;

namespace Piface.Examples.Blink
{
    class Program
    {
        static int DELAY = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("PiFace Digital IO LED Blink");
            PiFaceDigital pifacedigital = new PiFaceDigital();
            while (true)
            {
                pifacedigital.Leds[7].Toggle();
                Thread.Sleep(DELAY);
            }
        }
    }
}
