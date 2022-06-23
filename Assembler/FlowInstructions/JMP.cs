using System;
using System.Collections.Generic;
using System.Text;

namespace Assembler.FlowInstructions
{
    [Opcode(0x30)]
    public class JMP : Instruction
    {
        //different regex pattern required, must fit parse in "flowlayout", see ISA
        public override string Pattern => @"(SET) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d)";

        private FlowLayout flowLayout = new FlowLayout();
        protected override ILayout layout => flowLayout;

        public SET(byte[] data) : base(data)
        {
        }

        public SET() : base()
        {
        }
    }
}
