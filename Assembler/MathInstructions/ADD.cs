using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler.Layouts
{
    [Opcode (0x10)]
    public class ADD : Instruction
    {
        public override string Pattern => @"(ADD) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d)";

        private MathLayout mathLayout = new MathLayout();
        protected override ILayout layout => mathLayout;

        public ADD(byte[] data) : base(data)
        {
        }

        public ADD() : base()
        {
        }
    }
}