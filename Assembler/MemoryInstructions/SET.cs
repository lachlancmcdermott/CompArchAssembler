﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assembler.Layouts
}
    [Opcode(0x40)]
    public class SET : Instruction
    {
        //different regex pattern required, must fit parse in "flowlayout", see ISA
        public override string Pattern => @"(SET) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d)";

        private MemoryLayout memoryLayout = new MemoryLayout();
        protected override ILayout layout => memoryLayout;

        public SET(byte[] data) : base(data)
        {
        }

        public SET() : base()
        {
        }
    }
}