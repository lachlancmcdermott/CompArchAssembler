using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler
{
    [Opcode (0x10)]
    public class ADD : MathLayout
    {
        public string Pattern => @"(ADD) R([012][0-9]|3[01]|[0-9]) R([012][0-9]|3[01]|[0-9]) R([012][0-9]|3[01]|";

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