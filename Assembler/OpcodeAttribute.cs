﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assembler
{
    public class OpcodeAttribute : Attribute
    {
        public byte OpCode { get; }
        public OpcodeAttribute(byte opCode)
        {
            OpCode = opCode;
        }
    }
}
