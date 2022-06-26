using SharedLibrary.Layouts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SharedLibrary.MathInstructions
{
    [Opcode(0x11)]
    public class SUB : Instruction
    {
        public override string Pattern => @"(SUB) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d)";

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
