using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler.Layouts
{
    public class FlowLayout : ILayout
    {
        Dictionary<string, byte> StringToOpCode = new Dictionary<string, byte>
        {
            ["SET"] = 0x40,
        };

        public byte[] Parse(Match match)
        {
            byte[] data = new byte[4];

            //modify parse to work with flow instructions

            return data;
        }
    }
}
