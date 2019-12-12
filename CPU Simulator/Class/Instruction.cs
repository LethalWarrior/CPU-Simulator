using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Simulator.Class
{
    class Instruction
    {
        public string InstructionName { get; set; }
        public string InstructionInBit { get; set; }
        public InstructionType Type { get; set; }

        public Instruction()
        {

        }

        public Instruction(string InstructionName, string InstructionInBit, InstructionType Type)
        {
            this.InstructionName = InstructionName;
            this.InstructionInBit = InstructionInBit;
            this.Type = Type;
        }

    }

    public enum InstructionType
    {
        OneByte,
        TwoByte,
        ThreeByte
    }
}
