using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler.Layouts
{
    [Opcode(0x30)]
    public class JMP : Instruction
    {
        //different regex pattern required, must fit parse in "flowlayout", see ISA
        public override string Pattern => @"(JMP) ([012][\d]|3[01]|\d)";

        private FlowLayout flowLayout = new FlowLayout();
        protected override ILayout layout => flowLayout;

        public JMP(byte[] data) : base(data)
        {
        }

        public JMP() : base()
        {
        }
    }
}
