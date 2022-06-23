using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler
{
    [Opcode(0x11)]
    public class SUB : Instruction
    {
        public override string Pattern => @"(SUB) R([012][0-9]|3[01]|[0-9]) R([012][0-9]|3[01]|[0-9]) R([012][0-9]|3[01]|";

        private MathLayout mathLayout = new MathLayout();
        protected override ILayout layout => mathLayout;

        public SUB(byte[] data) : base(data)
        {
        }

        public SUB() : base()
        {
        }
    }
}
