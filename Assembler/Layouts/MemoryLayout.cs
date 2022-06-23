using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler.Layouts
{
    public class MemoryLayout : ILayout
    {
        Dictionary<string, byte> StringToOpCode = new Dictionary<string, byte>
        {
            ["SET"] = 0x40,
        };

        public byte[] Parse(Match match)
        {
            byte[] data = new byte[4];

            //modify parse to work with memory instructions
            //SET Rlocation, Valnb, Vallb (0x40 01 BE EF)

            return data;
        }
    }
}
