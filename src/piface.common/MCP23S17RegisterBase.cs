namespace Piface.Common
{
    public class MCP23S17RegisterBase
    {
        protected int address;
        protected MCP23S17 chip;

        public MCP23S17RegisterBase(int address, MCP23S17 chip)
        {
            this.address = address;
            this.chip = chip;
        }
    }
}