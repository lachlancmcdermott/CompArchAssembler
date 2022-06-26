using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler.Layouts
{
    [Opcode(0x40)]
    public class SET : Instruction
    {
        //different regex pattern required, must fit parse in "memoryLayout", see ISA
        public override string Pattern => @"(SET) R([012][\d]|3[01]|\d) (\d+) (\d+)";

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