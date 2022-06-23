using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Assembler
{
    class Program
    {
        //make InstructionsToArray, store the bits from the translated instructions back into a singular text file
        static byte[] InstructionsToArray(List<Instruction> assemblyInstructions)
        {
            
            //add byte array 0 and 1 together, make a temp array, then add temp and 2 together, then add temp and 3... so on
            return null;
        }

        static string[] LoadInstructions()
        {
            return System.IO.File.ReadAllLines("Assembly.asm");
        }

        static void Main(string[] args)
        {
            string[] instructionString = LoadInstructions();
            Instruction[] allInstructions = Statics.GetAllInstructions();

            for (int i = 0; i < instructionString.Length; i++)
            {
                foreach(Instruction ins in allInstructions)
                {
                    Match match = Regex.Match(input: instructionString[i], pattern: ins.Pattern);

                    if (match.Success)
                    {
                        ins.Parse(match);
                    }
                }
            }
        }
    }
}
