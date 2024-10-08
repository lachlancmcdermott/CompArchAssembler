﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SharedLibrary.Layouts
{
    public class FlowLayout : ILayout
    {
        Dictionary<string, byte> StringToOpCode = new Dictionary<string, byte>
        {
            ["JMP"] = 0x30,
        };

        public byte[] Parse(Match match)
        {
            byte[] data = new byte[4];
            data[0] = StringToOpCode[match.Groups[1].Value];
            data[1] = byte.Parse(match.Groups[2].Value);

            return data;
        }
    }
}
