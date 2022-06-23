﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler.Layouts
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

            //modify parse to work with flow instructions

            return data;
        }
    }
}
