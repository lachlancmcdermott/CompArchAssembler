﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assembler.Layouts
{
    class Statics
    {
        public static Instruction[] GetAllInstructions()
        {
            Instruction[] instructions = new Instruction[] { new ADD(), new SUB(), new SET(), new JMP()};
            return instructions;
        }
    }
}
