namespace Ganymedes.Devices
{
    public class SpiDevice
    {
        private int bus;
        private int cs;

        public SpiDevice(int bus, int cs, int speed)
        {
            this.bus = bus;
            this.cs = cs;
        }
    }
}