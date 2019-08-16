using Ganymedes.Devices;
using System;

namespace Piface.Common
{
    public class MCP23S17 : SpiDevice
    {
        public const byte WRITE_CMD = 0;
        public const byte READ_CMD = 1;

        public const int GPIOA = 0x12;

        private int hardware_addr;
        private int bus;
        private int chip_select;

        public MCP23S17(int hardware_addr, int bus, int chip_select, int speed_hz = 100000)
            :base(bus, chip_select, speed_hz)
        {
            this.hardware_addr = hardware_addr;
            this.bus = bus;
            this.chip_select = chip_select;
        }

        public int read_bit(int bit_num, int address)
        {
            int value = read(address);
            //bit_mask = get_bit_mask(bit_num);
            return 1; // if value & bit_mask else 0
        }

        internal void write_bit(bool value, int bit_num, int address)
        {
            throw new NotImplementedException();
        }

        private byte read(int address)
        {
            byte ctrl_byte = _get_spi_control_byte(READ_CMD);
            op, addr, data = spisend(bytes((ctrl_byte, address, 0)));
            return data;
        }

        private byte _get_spi_control_byte(byte read_write_cmd)
        {
            // board_addr_pattern = (self.hardware_addr & 0b111) << 1
            byte board_addr_pattern = (hardware_addr << 1) & 0xE;
            byte rw_cmd_pattern = read_write_cmd & 1;  // make sure it's just 1 bit long
            return 0x40 | board_addr_pattern | rw_cmd_pattern;
        }
    }
}