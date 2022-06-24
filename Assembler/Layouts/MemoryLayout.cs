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
            data[0] = StringToOpCode[match.Groups[1].Value];
            data[1] = byte.Parse(match.Groups[2].Value);
            data[2] = byte.Parse(match.Groups[3].Value);
            data[3] = byte.Parse(match.Groups[4].Value);

            return data;
        }
    }
}
