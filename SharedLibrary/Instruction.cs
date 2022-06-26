using SharedLibrary.Layouts;
using SharedLibrary.MathInstructions;
using SharedLibrary.MemoryInstructions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SharedLibrary
{
    public abstract class Instruction
    {
        public byte[] Data;
        public byte OpCode { get; set; }
        public virtual string Pattern { get; }
        protected  virtual ILayout layout { get; }

        public Instruction(byte[] data)
        {
            Data = data;
        }
        public Instruction()
        {

        }

        public Instruction Parse(Match match)
        {
            this.Data = layout.Parse(match);
            OpCode = Data[0];

            switch (OpCode)
            {
                case 0x40:
                    return new SET(layout.Parse(match));
                case 0x10:
                    return new ADD(layout.Parse(match));
                case 0x11:
                    return new SUB(layout.Parse(match));
                case 0x30:
                    return new JMP(layout.Parse(match));
            }

            throw new Exception("Instruction not implemented yet!");
        }

        public void Emit()
        {
            
        }

    }
}