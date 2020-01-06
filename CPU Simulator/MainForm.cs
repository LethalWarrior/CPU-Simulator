using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPU_Simulator.Class;
using System.Threading;
using System.Text.RegularExpressions;

namespace CPU_Simulator
{
    public partial class MainForm : Form
    {
        string latestAddress = "1";
        int currentAddressIndex = 0;
        Instruction currentInstruction;

        //Slots for two, or three byte instruction 
        string firstDataByte = "";
        string secondDataByte = "";

        bool carry = false;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnMin_MouseHover(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            button.BackColor = Color.FromArgb(168, 168, 14);
            button.FlatAppearance.BorderColor = Color.FromArgb(168, 168, 14);
            button.ForeColor = Color.FromArgb(16, 14, 14);
        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            button.BackColor = Color.FromArgb(168, 14, 14);
            button.FlatAppearance.BorderColor = Color.FromArgb(168, 14, 14);
        }

        private void BtnMin_MouseLeave(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            button.BackColor = Color.FromArgb(14, 14, 14);
            button.FlatAppearance.BorderColor = Color.White;
            button.ForeColor = Color.White;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            button.BackColor = Color.FromArgb(16, 14, 14);
            button.FlatAppearance.BorderColor = Color.White;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            for (int i = currentAddressIndex; i < DgvMemory.Rows.Count; i++)
            {
                DataGridViewRow row = DgvMemory.Rows[i];
                if (row.Cells[1].Value != null)
                {
                    if (row.Cells[0].Value == null)
                    {
                        Fetch(row.Cells[1].Value.ToString(), "");
                    }
                    else
                    {
                        Fetch(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString());
                        if (currentInstruction != null)
                        {
                            switch (currentInstruction.Type)
                            {
                                case InstructionType.OneByte:
                                    ChangeInstructionInfo(currentInstruction.InstructionName);
                                    switch (currentInstruction.InstructionName)
                                    {
                                        case "ADD R1, R2":
                                            ExecuteAdd(LblR1, LblR2);
                                            break;
                                        case "ADD R1, R3":
                                            ExecuteAdd(LblR1, LblR3);
                                            break;
                                        case "ADD R2, R1":
                                            ExecuteAdd(LblR2, LblR1);
                                            break;
                                        case "ADD R2, R3":
                                            ExecuteAdd(LblR2, LblR3);
                                            break;
                                        case "ADD R3, R1":
                                            ExecuteAdd(LblR3, LblR1);
                                            break;
                                        case "ADD R3, R2":
                                            ExecuteAdd(LblR3, LblR2);
                                            break;
                                        case "AND R1, R2":
                                            ExecuteAnd(LblR1, LblR2);
                                            break;
                                        case "AND R1, R3":
                                            ExecuteAnd(LblR1, LblR3);
                                            break;
                                        case "AND R2, R1":
                                            ExecuteAnd(LblR2, LblR1);
                                            break;
                                        case "AND R2, R3":
                                            ExecuteAnd(LblR2, LblR3);
                                            break;
                                        case "AND R3, R1":
                                            ExecuteAnd(LblR3, LblR1);
                                            break;
                                        case "AND R3, R2":
                                            ExecuteAnd(LblR3, LblR2);
                                            break;
                                        case "XOR R1, R2":
                                            ExecuteXor(LblR1, LblR2);
                                            break;
                                        case "XOR R1, R3":
                                            ExecuteXor(LblR1, LblR3);
                                            break;
                                        case "XOR R2, R1":
                                            ExecuteXor(LblR2, LblR1);
                                            break;
                                        case "XOR R2, R3":
                                            ExecuteXor(LblR2, LblR3);
                                            break;
                                        case "XOR R3, R1":
                                            ExecuteXor(LblR3, LblR1);
                                            break;
                                        case "XOR R3, R2":
                                            ExecuteXor(LblR3, LblR2);
                                            break;
                                    }
                                    break;
                                case InstructionType.TwoByte:
                                    if (firstDataByte == "")
                                    {
                                        ChangeInstructionInfo(currentInstruction.InstructionName);
                                        continue;
                                    }
                                    else
                                    {
                                        switch (currentInstruction.InstructionName)
                                        {
                                            case "LD R1, D8":
                                                ExecuteLoad(LblR1);
                                                break;
                                            case "LD R2, D8":
                                                ExecuteLoad(LblR2);
                                                break;
                                            case "LD R3, D8":
                                                ExecuteLoad(LblR3);
                                                break;
                                        }
                                        break;
                                    }
                                case InstructionType.ThreeByte:
                                    if (firstDataByte != "" && secondDataByte != "")
                                    {
                                        switch (currentInstruction.InstructionName)
                                        {
                                            case "JMP [XXXX]":
                                                LblIr.BackColor = Color.FromArgb(18, 18, 18);
                                                currentAddressIndex = Convert.ToInt32(secondDataByte + firstDataByte, 2) - 2;
                                                i = currentAddressIndex;

                                                firstDataByte = "";
                                                secondDataByte = "";
                                                currentInstruction = null;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        if (firstDataByte == "" && secondDataByte == "")
                                        {
                                            ChangeInstructionInfo(currentInstruction.InstructionName);
                                        }
                                        continue;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void DgvMemory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (DgvMemory.Rows[e.RowIndex].Cells[1].Value == null)
                {
                    DgvMemory.Rows[e.RowIndex].Cells[1].Value = Convert.ToString(Convert.ToInt32(latestAddress, 10), 2).PadLeft(16, '0');
                    latestAddress = (Convert.ToInt32(latestAddress, 10) + 1).ToString();
                }
            }
        }
        #endregion

        #region Subprocess

        public void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                System.Threading.Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }

        private List<Instruction> Instructions()
        {
            List<Instruction> instructions = new List<Instruction>() {
                (new Instruction("LD R1, D8", "01100111", InstructionType.TwoByte)),
                (new Instruction("LD R2, D8", "01101011", InstructionType.TwoByte)),
                (new Instruction("LD R3, D8", "01101111", InstructionType.TwoByte)),
                (new Instruction("ADD R1, R2", "00010110", InstructionType.OneByte)),
                (new Instruction("ADD R1, R3", "00010111", InstructionType.OneByte)),
                (new Instruction("ADD R2, R1", "00011001", InstructionType.OneByte)),
                (new Instruction("ADD R2, R3", "00011011", InstructionType.OneByte)),
                (new Instruction("ADD R3, R1", "00011101", InstructionType.OneByte)),
                (new Instruction("ADD R3, R2", "00011110", InstructionType.OneByte)),
                (new Instruction("AND R1, R2", "01000110", InstructionType.OneByte)),
                (new Instruction("AND R1, R3", "01000111", InstructionType.OneByte)),
                (new Instruction("AND R2, R1", "01001001", InstructionType.OneByte)),
                (new Instruction("AND R2, R3", "01001011", InstructionType.OneByte)),
                (new Instruction("AND R3, R1", "01001101", InstructionType.OneByte)),
                (new Instruction("AND R3, R2", "01001110", InstructionType.OneByte)),
                (new Instruction("JMP [XXXX]", "01111111", InstructionType.ThreeByte)),
                (new Instruction("XOR R1, R2", "00000001", InstructionType.OneByte)),
                (new Instruction("XOR R1, R3", "00000010", InstructionType.OneByte)),
                (new Instruction("XOR R2, R1", "00000011", InstructionType.OneByte)),
                (new Instruction("XOR R2, R3", "00000100", InstructionType.OneByte)),
                (new Instruction("XOR R3, R1", "00000101", InstructionType.OneByte)),
                (new Instruction("XOR R3, R2", "00000110", InstructionType.OneByte)),
            };
            return instructions;
        }

        private string BitWiseAnd(string byte1, string byte2)
        {
            string result = "";
            for (int i = 0; i < 8; i++)
            {
                result += ((byte1[i] == '0' ? 0 : 1) & (byte2[i] == '0' ? 0 : 1)).ToString();
            }
            return result;
        }

        private string BitWiseXor(string byte1, string byte2)
        {
            string result = "";
            for (int i = 0; i < 8; i++)
            {
                result += ((byte1[i] == '0' ? 0 : 1) ^ (byte2[i] == '0' ? 0 : 1)).ToString();
            }
            return result;
        }

        private string Addition(string byte1, string byte2)
        {
            string result = "";
            int carry = 0;

            //Loop through to add bit by bit
            for (int i = 7; i >= 0; i--)
            {
                var x = Convert.ToInt32(byte1[i].ToString()) + Convert.ToInt32(byte2[i].ToString()) + carry;
                switch (x)
                {
                    case 0:
                    case 1:
                        result += x.ToString();
                        carry = 0;
                        break;
                    case 2:
                        result += "0";
                        carry = 1;
                        break;
                    case 3:
                        result += "1";
                        carry = 1;
                        break;
                    default:
                        break;
                }
            }

            //Reverse bit order
            char[] arr = result.ToCharArray();
            Array.Reverse(arr);
            result = new string(arr);

            if (carry != 0)
            {
                this.carry = true;
            }
            return result;
        }

        private void ChangeInstructionInfo(string instructionName)
        {
            Wait(500);
            LblInstructionName.Text = instructionName;
            LblInstructionName.BackColor = Color.White;
            LblInstructionName.ForeColor = Color.FromArgb(18, 18, 18);
            Wait(500);
            LblInstructionName.BackColor = Color.FromArgb(18, 18, 18);
            LblInstructionName.ForeColor = Color.White;
            Wait(500);
        }

        private void Fetch(string address, string instruction)
        {
            Wait(500);
            currentAddressIndex++;
            LblPc.BackColor = Color.FromArgb(168, 18, 18);
            LblPc.Text = address;
            if (instruction != "")
            {
                Wait(500);
                LblPc.BackColor = Color.FromArgb(18, 18, 18);
                LblIr.BackColor = Color.FromArgb(168, 18, 18);
                LblIr.Text = instruction;
                Wait(500);
                LblIr.BackColor = Color.FromArgb(18, 18, 18);

                var query = Instructions().Find(x => x.InstructionInBit == instruction);
                if (query != null && currentInstruction == null)
                {
                    currentInstruction = query;
                }
                else
                {
                    if (firstDataByte == "") firstDataByte = instruction;
                    else secondDataByte = instruction;
                }
            }
        }

        private void ExecuteLoad(Label targetRegister)
        {
            targetRegister.BackColor = Color.FromArgb(168, 18, 18);
            targetRegister.Text = firstDataByte;
            Wait(500);
            targetRegister.BackColor = Color.FromArgb(18, 18, 18);
            LblIr.BackColor = Color.FromArgb(18, 18, 18);

            currentInstruction = null;
            firstDataByte = "";
        }

        private void ExecuteAnd(Label targetRegister, Label operandRegister)
        {
            operandRegister.BackColor = Color.FromArgb(168, 18, 18);
            Wait(500);
            operandRegister.BackColor = Color.FromArgb(18, 18, 18);
            targetRegister.BackColor = Color.FromArgb(168, 18, 18);
            targetRegister.Text = BitWiseAnd(targetRegister.Text, operandRegister.Text);
            Wait(500);
            targetRegister.BackColor = Color.FromArgb(18, 18, 18);
            currentInstruction = null;
        }

        private void ExecuteXor(Label targetRegister, Label operandRegister)
        {
            operandRegister.BackColor = Color.FromArgb(168, 18, 18);
            Wait(500);
            operandRegister.BackColor = Color.FromArgb(18, 18, 18);
            targetRegister.BackColor = Color.FromArgb(168, 18, 18);
            targetRegister.Text = BitWiseXor(targetRegister.Text, operandRegister.Text);
            Wait(500);
            targetRegister.BackColor = Color.FromArgb(18, 18, 18);
            currentInstruction = null;
        }

        private void ExecuteAdd(Label targetRegister, Label operandRegister)
        {
            operandRegister.BackColor = Color.FromArgb(168, 18, 18);
            Wait(500);
            operandRegister.BackColor = Color.FromArgb(18, 18, 18);
            targetRegister.BackColor = Color.FromArgb(168, 18, 18);

            targetRegister.Text = Addition(targetRegister.Text, operandRegister.Text);
            Wait(500);
            targetRegister.BackColor = Color.FromArgb(18, 18, 18);

            StringBuilder sb = new StringBuilder(LblFlag.Text);
            sb[7] = carry == true ? '1' : '0';
            LblFlag.BackColor = Color.FromArgb(168, 18, 18);
            LblFlag.Text = sb.ToString();

            Wait(500);
            LblFlag.BackColor = Color.FromArgb(18, 18, 18);
            currentInstruction = null;
        }

        #endregion

    }
}
