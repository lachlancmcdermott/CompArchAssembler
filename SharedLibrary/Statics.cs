using SharedLibrary.Layouts;
using SharedLibrary.MathInstructions;
using SharedLibrary.MemoryInstructions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary
{
    public class Statics
    {
        public static Instruction[] GetAllInstructions()
        {
            Instruction[] instructions = new Instruction[] { new ADD(), new SUB(), new SET(), new JMP()};
            return instructions;
        }
    }
}
