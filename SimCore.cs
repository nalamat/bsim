/*************************************************************************
 *                                                                       *
 * This file is a part of the BSIM project: The Basic Computer Simulator *
 * Copyright (C) 2014, Nima Alamatsaz, All rights reserved               *
 * Email: nnalamat@gmail.com                                             *
 * Web:   http://github.com/nalamat/bsim                                 *
 *                                                                       *
 * BSIM is free software: you can redistribute it and/or modify          *
 * it under the terms of the GNU General Public License as published by  *
 * the Free Software Foundation, either version 3 of the License, or     *
 * any later version.                                                    *
 *                                                                       *
 * BSIM is distributed in the hope that it will be useful,               *
 * but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the          *
 * GNU General Public License for more details.                          *
 *                                                                       *
 * You should have received a copy of the GNU General Public License     *
 * along with BSIM. If not, see <http://www.gnu.org/licenses/>.          *
 *                                                                       *
 *************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace bsim
{
	class SimCore
	{
		public SimState cur = new SimState();
		public string memFile = "";
		public const int mem_size = 4 * 1024;
		public ushort[] mem = new ushort[mem_size];      // 4KB of memory
		public Dictionary<ushort, string> instructionTable = new Dictionary<ushort,string>();

		public SimCore()
		{
			instructionTable[0x0000] = "AND";
			instructionTable[0x1000] = "ADD";
			instructionTable[0x2000] = "LDA";
			instructionTable[0x3000] = "STA";
			instructionTable[0x4000] = "BUN";
			instructionTable[0x5000] = "BSA";
			instructionTable[0x6000] = "ISZ";

			instructionTable[0x8000] = "AND";
			instructionTable[0x9000] = "ADD";
			instructionTable[0xA000] = "LDA";
			instructionTable[0xB000] = "STA";
			instructionTable[0xC000] = "BUN";
			instructionTable[0xD000] = "BSA";
			instructionTable[0xE000] = "ISZ";

			instructionTable[0x7800] = "CLA";
			instructionTable[0x7400] = "CLE";
			instructionTable[0x7200] = "CMA";
			instructionTable[0x7100] = "CME";
			instructionTable[0x7080] = "CIR";
			instructionTable[0x7040] = "CIL";
			instructionTable[0x7020] = "INC";
			instructionTable[0x7010] = "SPA";
			instructionTable[0x7008] = "SNA";
			instructionTable[0x7004] = "SZA";
			instructionTable[0x7002] = "SZE";
			instructionTable[0x7001] = "HLT";
			instructionTable[0xF800] = "INP";
			instructionTable[0xF400] = "OUT";
			instructionTable[0xF200] = "SKI";
			instructionTable[0xF100] = "SKO";
			instructionTable[0xF080] = "ION";
			instructionTable[0xF040] = "IOF";
		}

		public bool LoadFile(string file)
		{
			ushort[] keepMem = (ushort[])mem.Clone();

			if (LoadFileHEX(file) || LoadFileLST(file) || LoadFileOBJ(file))
			{
				cur = new SimState();
				memFile = file;
				return true;
			}
			else
			{
				mem = keepMem;
				return false;
			}
		}

		private bool LoadFileOBJ(string file)
		{
			int i = 0;

			try
			{
				FileStream stream = File.OpenRead(file);

				for (i = 0; i < mem_size; ++i)
					mem[i] = (ushort)((byte)stream.ReadByte() | (byte)stream.ReadByte() << 8);
			}
			finally { }

			return i == mem_size;
		}

		private bool LoadFileHEX(string file)
		{
			return false;
		}

		private bool LoadFileLST(string file)
		{
			return false;
		}

		public List<string> NextCycle()
		{
			List<string> micros = new List<string>();

			if (!cur.S)
			{
				micros.Add("Computer is in halt (S = 0)");
				return micros;
			}

			SimState next = cur.Clone();
			next.SC = (ushort)(cur.SC + 1);

			// fetch
			if (!cur.R && cur.T[0])
			{
				next.AR = cur.PC;
				micros.Add(SimMicros.AR_PC);
			}
			else if (!cur.R && cur.T[1])
			{
				next.IR = mem[cur.AR];
				next.PC = (ushort)(cur.PC + 1);
				micros.Add(SimMicros.IR_MEM);
				micros.Add(SimMicros.PC_INC);
			}
			// decode
			else if (!cur.R && cur.T[2])
			{
				for (int i = 0; i < next.D.Length; ++i) next.D[i] = false;
				next.D[(cur.IR >> 12) & 7] = true;
				next.AR = (ushort)(cur.IR & ((1 << 11) - 1));
				next.I = (cur.IR >> 15) > 0;
				micros.Add(SimMicros.D_IR);
				micros.Add(SimMicros.AR_IR);
				micros.Add(SimMicros.I_IR15);
			}
			// indirect
			else if (!cur.D[7] && cur.I && cur.T[3])
			{
				next.AR = mem[cur.AR];
				micros.Add(SimMicros.AR_MEM);
			}
			// interrupt
			else if (!cur.T[0] && !cur.T[1] && !cur.T[2] && cur.IEN && (cur.FGI || cur.FGO))
			{
				next.R = true;
				micros.Add(SimMicros.R_SET);
			}
			else if (cur.R && cur.T[0])
			{
				next.AR = 0;
				next.TR = cur.PC;
				micros.Add(SimMicros.AR_CLR);
				micros.Add(SimMicros.TR_PC);
			}
			else if (cur.R && cur.T[1])
			{
				mem[cur.AR] = cur.TR;
				next.PC = 0;
				micros.Add(SimMicros.MEM_TR);
				micros.Add(SimMicros.PC_CLR);
			}
			else if (cur.R && cur.T[2])
			{
				next.PC = (ushort)(cur.PC + 1);
				next.IEN = false;
				next.R = false;
				next.SC = 0;
				micros.Add(SimMicros.PC_INC);
				micros.Add(SimMicros.IEN_CLR);
				micros.Add(SimMicros.R_CLR);
				micros.Add(SimMicros.SC_CLR);
			}
			// mri
			// and
			else if (cur.D[0] && cur.T[4])
			{
				next.DR = mem[cur.AR];
				micros.Add(SimMicros.DR_MEM);
			}
			else if (cur.D[0] && cur.T[5])
			{
				next.AC = (ushort)(cur.AC & cur.DR);
				next.SC = 0;
				micros.Add(SimMicros.AC_AND_DR);
				micros.Add(SimMicros.SC_CLR);
			}
			// add
			else if (cur.D[1] && cur.T[4])
			{
				next.DR = mem[cur.AR];
				micros.Add(SimMicros.DR_MEM);
			}
			else if (cur.D[1] && cur.T[5])
			{
				next.AC = (ushort)(cur.AC + cur.DR);
				next.E = ((cur.AC + cur.DR) & (1 << 16)) > 0;      // carry
				next.SC = 0;
				micros.Add(SimMicros.AC_PLUS_DR);
				micros.Add(SimMicros.E_Cout);
				micros.Add(SimMicros.SC_CLR);
			}
			// lda
			else if (cur.D[2] && cur.T[4])
			{
				next.DR = mem[cur.AR];
				micros.Add(SimMicros.DR_MEM);
			}
			else if (cur.D[2] && cur.T[5])
			{
				next.AC = cur.DR;
				next.SC = 0;
				micros.Add(SimMicros.AC_DR);
				micros.Add(SimMicros.SC_CLR);
			}
			// sta
			else if (cur.D[3] && cur.T[4])
			{
				mem[cur.AR] = cur.AC;
				next.SC = 0;
				micros.Add(SimMicros.MEM_AC);
				micros.Add(SimMicros.SC_CLR);
			}
			// bun
			else if (cur.D[4] && cur.T[4])
			{
				next.PC = cur.AR;
				next.SC = 0;
				micros.Add(SimMicros.PC_AR);
				micros.Add(SimMicros.SC_CLR);
			}
			// bsa
			else if (cur.D[5] && cur.T[4])
			{
				mem[cur.AR] = cur.PC;
				next.AR = (ushort)(cur.AR + 1);
				micros.Add(SimMicros.MEM_PC);
				micros.Add(SimMicros.AR_INC);
			}
			else if (cur.D[5] && cur.T[5])
			{
				next.PC = cur.AR;
				next.SC = 0;
				micros.Add(SimMicros.PC_AR);
				micros.Add(SimMicros.SC_CLR);
			}
			// isz
			else if (cur.D[6] && cur.T[4])
			{
				next.DR = mem[cur.AR];
				micros.Add(SimMicros.DR_MEM);
			}
			else if (cur.D[6] && cur.T[5])
			{
				next.DR = (ushort)(cur.DR + 1);
				micros.Add(SimMicros.DR_INC);
			}
			else if (cur.D[6] && cur.T[6])
			{
				mem[cur.AR] = cur.DR;
				if (cur.DR == 0) next.PC = (ushort)(cur.PC + 1);
				next.SC = 0;
				micros.Add(SimMicros.MEM_DR);
				micros.Add(SimMicros.DR_IS_0_PC_INC);
				micros.Add(SimMicros.SC_CLR);
			}
			// non mri
			// cla
			else if (cur.r && cur.B[11])
			{
				next.AC = 0;
				micros.Add(SimMicros.AC_CLR);
			}
			// cle
			else if (cur.r && cur.B[10])
			{
				next.E = false;
				micros.Add(SimMicros.E_CLR);
			}
			// cma
			else if (cur.r && cur.B[9])
			{
				next.AC = (ushort)((~cur.AC) & ((1 << 16) - 1));
				micros.Add(SimMicros.AC_NOT);
			}
			// cme
			else if (cur.r && cur.B[8])
			{
				next.E = !cur.E;
				micros.Add(SimMicros.E_NOT);
			}
			// cir
			else if (cur.r && cur.B[7])
			{
				next.AC = (ushort)(cur.AC >> 1);
				if (cur.E) next.AC = (ushort)(next.AC | (1 << 15));
				next.E = (cur.AC & 1) > 0;
				micros.Add(SimMicros.AC_SHR);
				micros.Add(SimMicros.AC15_E);
				micros.Add(SimMicros.E_AC0);
			}
			// cil
			else if (cur.r && cur.B[6])
			{
				next.AC = (ushort)(cur.AC << 1);
				next.AC = (ushort)(next.AC & ((1 << 16) - 1));
				if (cur.E) next.AC |= 1;
				next.E = (cur.AC & (1 << 15)) > 0;
				micros.Add(SimMicros.AC_SHL);
				micros.Add(SimMicros.AC0_E);
				micros.Add(SimMicros.E_AC15);
			}
			// inc
			else if (cur.r && cur.B[5])
			{
				next.AC = (ushort)(cur.AC + 1);
				micros.Add(SimMicros.AC_INC);
			}
			// spa
			else if (cur.r && cur.B[4])
			{
				if ((cur.AC & (1 << 15)) == 0) next.PC = (ushort)(cur.PC + 1);
				micros.Add(SimMicros.AC15_IS_0_PC_INC);
			}
			// sna
			else if (cur.r && cur.B[3])
			{
				if ((cur.AC & (1 << 15)) > 0) next.PC = (ushort)(cur.PC + 1);
				micros.Add(SimMicros.AC15_IS_1_PC_INC);
			}
			// sza
			else if (cur.r && cur.B[2])
			{
				if (cur.AC == 0) next.PC = (ushort)(cur.PC + 1);
				micros.Add(SimMicros.AC_IS_0_PC_INC);
			}
			// sze
			else if (cur.r && cur.B[1])
			{
				if (cur.E == false) next.PC = (ushort)(cur.PC + 1);
				micros.Add(SimMicros.E_IS_0_PC_INC);
			}
			// hlt
			else if (cur.r && cur.B[0])
			{
				next.S = false;
				micros.Add(SimMicros.S_CLR);
			}
			// io
			// inp
			else if (cur.p && cur.B[11])
			{
				next.AC = cur.INPR;
				next.FGI = false;
				next.SC = 0;
				micros.Add(SimMicros.AC_INPR);
				micros.Add(SimMicros.FGI_CLR);
			}
			// out
			else if (cur.p && cur.B[10])
			{
				next.OUTR = (ushort)(cur.AC & ((1 << 8) - 1));
				next.FGO = false;
				next.SC = 0;
				micros.Add(SimMicros.OUTR_AC);
				micros.Add(SimMicros.FGO_CLR);
			}
			// ski
			else if (cur.p && cur.B[9])
			{
				if (cur.FGI) next.PC = (ushort)(cur.PC + 1);
				next.SC = 0;
				micros.Add(SimMicros.FGI_IS_1_PC_INC);
			}
			// sko
			else if (cur.p && cur.B[8])
			{
				if (cur.FGO) next.PC = (ushort)(cur.PC + 1);
				next.SC = 0;
				micros.Add(SimMicros.FGO_IS_1_PC_INC);
			}
			// ion
			else if (cur.p && cur.B[7])
			{
				next.IEN = true;
				next.SC = 0;
				micros.Add(SimMicros.IEN_SET);
			}
			// iof
			else if (cur.p && cur.B[6])
			{
				next.IEN = false;
				next.SC = 0;
				micros.Add(SimMicros.IEN_CLR);
			}

			for (int i = 0; i < 12; ++i)
				next.B[i] = (next.IR & (1 << i)) > 0;

			next.T[cur.SC] = false;
			next.T[next.SC] = true;

			next.r = next.D[7] && !next.I && next.T[3];
			next.p = next.D[7] && next.I && next.T[3];

			cur = next;
			return micros;
		}

		// first method of getting next cycle micro-operations,
		// based on cloning simulation state and memory
		public List<string> GetNextCycle()
		{
			SimState keepState = cur.Clone();
			ushort[] keepMem = (ushort[])mem.Clone();
			List<string> micros = this.NextCycle();
			cur = keepState;
			mem = keepMem;
			return micros;
		}

		// second method of getting next cycle micro-operations,
		// much faster than the first one but harder to manage the code
		public List<string> GetNextCycle2()
		{
			List<string> micros = new List<string>();

			if (!cur.S)
			{
				micros.Add("Computer is in halt (S = 0)");
			}
			// fetch
			else if (!cur.R && cur.T[0])
			{
				micros.Add(SimMicros.AR_PC);
			}
			else if (!cur.R && cur.T[1])
			{
				micros.Add(SimMicros.IR_MEM);
				micros.Add(SimMicros.PC_INC);
			}
			// decode
			else if (!cur.R && cur.T[2])
			{
				micros.Add(SimMicros.D_IR);
				micros.Add(SimMicros.AR_IR);
				micros.Add(SimMicros.I_IR15);
			}
			// indirect
			else if (!cur.D[7] && cur.I && cur.T[3])
			{
				micros.Add(SimMicros.AR_MEM);
			}
			// interrupt
			else if (!cur.T[0] && !cur.T[1] && !cur.T[2] && cur.IEN && (cur.FGI || cur.FGO))
			{
				micros.Add(SimMicros.R_SET);
			}
			else if (cur.R && cur.T[0])
			{
				micros.Add(SimMicros.AR_CLR);
				micros.Add(SimMicros.TR_PC);
			}
			else if (cur.R && cur.T[1])
			{
				micros.Add(SimMicros.MEM_TR);
				micros.Add(SimMicros.PC_CLR);
			}
			else if (cur.R && cur.T[2])
			{
				micros.Add(SimMicros.PC_INC);
				micros.Add(SimMicros.IEN_CLR);
				micros.Add(SimMicros.R_CLR);
				micros.Add(SimMicros.SC_CLR);
			}
			// mri
			// and
			else if (cur.D[0] && cur.T[4])
			{
				micros.Add(SimMicros.DR_MEM);
			}
			else if (cur.D[0] && cur.T[5])
			{
				micros.Add(SimMicros.AC_AND_DR);
				micros.Add(SimMicros.SC_CLR);
			}
			// add
			else if (cur.D[1] && cur.T[4])
			{
				micros.Add(SimMicros.DR_MEM);
			}
			else if (cur.D[1] && cur.T[5])
			{
				micros.Add(SimMicros.AC_PLUS_DR);
				micros.Add(SimMicros.E_Cout);
				micros.Add(SimMicros.SC_CLR);
			}
			// lda
			else if (cur.D[2] && cur.T[4])
			{
				micros.Add(SimMicros.DR_MEM);
			}
			else if (cur.D[2] && cur.T[5])
			{
				micros.Add(SimMicros.AC_DR);
				micros.Add(SimMicros.SC_CLR);
			}
			// sta
			else if (cur.D[3] && cur.T[4])
			{
				micros.Add(SimMicros.MEM_AC);
				micros.Add(SimMicros.SC_CLR);
			}
			// bun
			else if (cur.D[4] && cur.T[4])
			{
				micros.Add(SimMicros.PC_AR);
				micros.Add(SimMicros.SC_CLR);
			}
			// bsa
			else if (cur.D[5] && cur.T[4])
			{
				micros.Add(SimMicros.MEM_PC);
				micros.Add(SimMicros.AR_INC);
			}
			else if (cur.D[5] && cur.T[5])
			{
				micros.Add(SimMicros.PC_AR);
				micros.Add(SimMicros.SC_CLR);
			}
			// isz
			else if (cur.D[6] && cur.T[4])
			{
				micros.Add(SimMicros.DR_MEM);
			}
			else if (cur.D[6] && cur.T[5])
			{
				micros.Add(SimMicros.DR_INC);
			}
			else if (cur.D[6] && cur.T[6])
			{
				micros.Add(SimMicros.MEM_DR);
				micros.Add(SimMicros.DR_IS_0_PC_INC);
				micros.Add(SimMicros.SC_CLR);
			}
			// non mri
			// cla
			else if (cur.r && cur.B[11])
			{
				micros.Add(SimMicros.AC_CLR);
			}
			// cle
			else if (cur.r && cur.B[10])
			{
				micros.Add(SimMicros.E_CLR);
			}
			// cma
			else if (cur.r && cur.B[9])
			{
				micros.Add(SimMicros.AC_NOT);
			}
			// cme
			else if (cur.r && cur.B[8])
			{
				micros.Add(SimMicros.E_NOT);
			}
			// cir
			else if (cur.r && cur.B[7])
			{
				micros.Add(SimMicros.AC_SHR);
				micros.Add(SimMicros.AC15_E);
				micros.Add(SimMicros.E_AC0);
			}
			// cil
			else if (cur.r && cur.B[6])
			{
				micros.Add(SimMicros.AC_SHL);
				micros.Add(SimMicros.AC0_E);
				micros.Add(SimMicros.E_AC15);
			}
			// inc
			else if (cur.r && cur.B[5])
			{
				micros.Add(SimMicros.AC_INC);
			}
			// spa
			else if (cur.r && cur.B[4])
			{
				micros.Add(SimMicros.AC15_IS_0_PC_INC);
			}
			// sna
			else if (cur.r && cur.B[3])
			{
				micros.Add(SimMicros.AC15_IS_1_PC_INC);
			}
			// sza
			else if (cur.r && cur.B[2])
			{
				micros.Add(SimMicros.AC_IS_0_PC_INC);
			}
			// sze
			else if (cur.r && cur.B[1])
			{
				micros.Add(SimMicros.E_IS_0_PC_INC);
			}
			// hlt
			else if (cur.r && cur.B[0])
			{
				micros.Add(SimMicros.S_CLR);
			}
			// io
			// inp
			else if (cur.p && cur.B[11])
			{
				micros.Add(SimMicros.AC_INPR);
				micros.Add(SimMicros.FGI_CLR);
			}
			// out
			else if (cur.p && cur.B[10])
			{
				micros.Add(SimMicros.OUTR_AC);
				micros.Add(SimMicros.FGO_CLR);
			}
			// ski
			else if (cur.p && cur.B[9])
			{
				micros.Add(SimMicros.FGI_IS_1_PC_INC);
			}
			// sko
			else if (cur.p && cur.B[8])
			{
				micros.Add(SimMicros.FGO_IS_1_PC_INC);
			}
			// ion
			else if (cur.p && cur.B[7])
			{
				micros.Add(SimMicros.IEN_SET);
			}
			// iof
			else if (cur.p && cur.B[6])
			{
				micros.Add(SimMicros.IEN_CLR);
			}

			return micros;
		}

		public void NextInstruction()
		{
			do
			{
				this.NextCycle();
			}
			while (cur.SC != 0 && cur.S);
		}

		public string GetCurInstruction()
		{
			if (!cur.S)
				return "Computer is in halt (S = 0)";
			else if (cur.R)
				return "Handling interrupt (R = 1)";
			else if (!cur.R && (cur.T[0] || cur.T[1]))
				return CodeToInstruction(mem[cur.PC]) + "    0x" + mem[cur.PC].ToString("x4").ToUpper();
			else
				return CodeToInstruction(cur.IR) + "    0x" + cur.IR.ToString("x4").ToUpper();
		}

		public string CodeToInstruction(ushort code)
		{
			try
			{
				// mri
				if (((code >> 12) & 7) < 7)
					return instructionTable[(ushort)(code & (7 << 12))] + " " + (code & ((1 << 12) - 1)) + ((code & (1 << 15)) > 0 ? " I" : "");
				// non-mri or io
				else
					return instructionTable[code];
			}
			catch
			{
				return "NOP";
			}
		}
	}
}
