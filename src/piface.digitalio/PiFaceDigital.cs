using Piface.Common;

namespace Piface.Digitalio
{
    public class PiFaceDigital : MCP23S17
    {
        // /dev/spidev<bus>.<chipselect>
        private const int DEFAULT_SPI_BUS = 0;
        private const int DEFAULT_SPI_CHIP_SELECT = 0;

        public PiFaceDigital(int hardware_addr = 0, int bus = DEFAULT_SPI_BUS,
            int chip_select= DEFAULT_SPI_CHIP_SELECT, bool init_board = true) 
            : base(hardware_addr, bus, chip_select)
        {
            for(int i=0; i<=7; i++)
            {
                Leds[i] = new MCP23S17RegisterBit(i, GPIOA, this);
            }
        }

        public MCP23S17RegisterBit[] Leds { get; } = new MCP23S17RegisterBit[8];
    }
}