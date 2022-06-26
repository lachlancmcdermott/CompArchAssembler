using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using SharedLibrary;

namespace Assembler
{
    class Program
    {
        static byte[] InstructionsToArray(List<Instruction> assemblyInstructions)
        {
            byte[] output = new byte[assemblyInstructions.Count * 4];
            int index = 0;
            for (int i = 0; i < assemblyInstructions.Count; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    output[index] = assemblyInstructions[i].Data[k];
                    index++;
                }
            }
            return output;
        }

        static void WriteInstructions(List<Instruction> assemblyInstructions)
        {
            byte[] input = InstructionsToArray(assemblyInstructions);

            System.IO.File.WriteAllBytes("Instructions.bin", input);
        }


        static string[] LoadInstructions()
        {
            return System.IO.File.ReadAllLines("Program.asm");
        }

        static void Main(string[] args)
        {
            string[] instructionStrings = LoadInstructions();
            Instruction[] allInstructions = Statics.GetAllInstructions();
            List<Instruction> assemblyIns = new List<Instruction>();

            for (int i = 0; i < instructionStrings.Length; i++)
            {
                foreach(Instruction ins in allInstructions)
                {
                    Match match = Regex.Match(input: instructionStrings[i], pattern: ins.Pattern);

                    if (match.Success)
                    {
                        assemblyIns.Add(ins.Parse(match));
                    }
                }
            }
            WriteInstructions(assemblyIns);
        }
    }
}
