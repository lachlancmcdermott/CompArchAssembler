using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler
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
            return this;
        }

        public void Emit()
        {
            
        }

    }
}