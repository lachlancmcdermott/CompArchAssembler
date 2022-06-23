using System;
using System.Collections.Generic;
using System.Text;

namespace Assembler.FlowInstructions
{
    [Opcode(0x40)]
    public class SET : Instruction
    {
        public override string Pattern => @"(SET) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d) R([012][\d]|3[01]|\d)";

        //different regex pattern

        private FlowLayout flowLayout = new FlowLayout();
        protected override ILayout layout => flowLayout;

        public SET(byte[] data) : base(data)
        {
        }

        public SET() : base()
        {
        }
    }
