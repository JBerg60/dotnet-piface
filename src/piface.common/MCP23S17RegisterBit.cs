namespace Piface.Common
{
    public class MCP23S17RegisterBit : MCP23S17RegisterBase
    {
        int bit_num;

        public MCP23S17RegisterBit(int bit_num, int address, MCP23S17 chip)
            : base(address, chip)
        {
            this.bit_num = bit_num;
        }

        public bool Value
        {
            get => chip.read_bit(bit_num, address);
            set => chip.write_bit(value, bit_num, address);
        }

        public void Toggle()
        {
            Value = !Value;
        }
    }
}