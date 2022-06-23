using System;
using System.Collections.Generic;
using System.Text;

namespace Assembler
{
    class Statics
    {

        public static Instruction[] GetAllInstructions()
        {
            Instruction[] instructions = new Instruction[] { new ADD(), new SUB()};
            return instructions;
        }
    }
}
