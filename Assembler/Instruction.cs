using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assembler
{
    public abstract class Instruction
    {
        public byte[] Data;
        public byte OpCode { get; }
        public virtual string Pattern { get; }
        public  virtual ILayout layout { get; }

        public static Instruction Parse(string instructionStr)
        {
            Match match = Regex.Match(input: instructionStr, pattern: "ADD R([012][0-9]|3[01]|[0-9]) R([012][0-9]|3[01]|[0-9]) R([012][0-9]|3[01]|) | SUB R([012][0-9]|3[01]|[0-9]) R([012][0-9]|3[01]|[0-9]) R([012][0-9]|3[01]|) |");



            if (instructionStr.Substring(0,3) == "ADD")
            {
                return new ADD().Parse(match);
            }
            else if(instructionStr.Substring(0, 3) == "SUB")
            {
                return new SUB().Parse(match);
            }
            return null;
        }


    }
}