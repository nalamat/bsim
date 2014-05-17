/*************************************************************************
 *                                                                       *
 * This file is a part of the BSIM project: The Basic Computer Simulator *
 * Copyright (C) 2012-2014, Nima Alamatsaz, All rights reserved          *
 * Email: nnalamat@gmail.com                                             *
 * Web:   http://github.com/nalamat/bsim                                 *
 *                                                                       *
 * BSIM is free software: you can redistribute the software              *
 * and/or modify it under the terms of the GNU General Public License    *
 * version 3 as published by the Free Software Foundation.               *
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

namespace bsim
{
	class SimMicros
	{
		public const string AC_CLR = "AC(0) <= 0";
		public const string AC_INC = "AC <= AC + 1";
		public const string AC_PLUS_DR = "AC <= AC + DR";
		public const string AC_AND_DR = "AC <= AC && DR";
		public const string AC_NOT = "AC <= AC not";
		public const string AC_DR = "AC <= DR";
		public const string AC_SHL = "AC <= shift AC left";
		public const string AC_SHR = "AC <= shift AC right";
		public const string AC0_E = "AC(0) <= E";
		public const string AC_INPR = "AC(0-7) <= INPR";
		public const string AC15_E = "AC(15) <= E";
		public const string AR_CLR = "AR <= 0";
		public const string AR_INC = "AR <= AR + 1";
		public const string AR_IR = "AR <= IR(0-11)";
		public const string AR_MEM = "AR <= MEM[AR]";
		public const string AR_PC = "AR <= PC";
		public const string D_IR = "D0 ... D7 <= decode IR(12-14)";
		public const string DR_INC = "DR <= DR + 1";
		public const string DR_MEM = "DR <= MEM[AR]";
		public const string E_CLR = "E <= 0";
		public const string E_AC0 = "E <= AC(0)";
		public const string E_AC15 = "E <= AC(15)";
		public const string E_Cout = "E <= Cout";
		public const string E_NOT = "E <= E not";
		public const string FGI_CLR = "FGI <= 0";
		public const string FGO_CLR = "FGO <= 0";
		public const string I_IR15 = "I <= IR(15)";
		public const string IEN_CLR = "IEN <= 0";
		public const string IEN_SET = "IEN <= 1";
		public const string IR_MEM = "IR <= MEM[AR]";
		public const string MEM_AC = "MEM[AR] <= AC";
		public const string MEM_DR = "MEM[AR] <= DR";
		public const string MEM_PC = "MEM[AR] <= PC";
		public const string MEM_TR = "MEM[AR] <= TR";
		public const string OUTR_AC = "OUTR <= AC(0-7)";
		public const string PC_CLR = "PC <= 0";
		public const string PC_AR = "PC <= AR";
		public const string PC_INC = "PC <= PC + 1";
		public const string R_CLR = "R <= 0";
		public const string R_SET = "R <= 1";
		public const string S_CLR = "S <= 0";
		public const string SC_CLR = "SC <= 0";
		public const string TR_PC = "TR <= PC";
		public const string AC_IS_0_PC_INC = "if (AC = 0) then (PC <= PC + 1)";
		public const string AC15_IS_0_PC_INC = "if (AC(15) = 0) then (PC <= PC + 1)";
		public const string AC15_IS_1_PC_INC = "if (AC(15) = 1) then (PC <= PC + 1)";
		public const string DR_IS_0_PC_INC = "if (DR = 0) then (PC <= PC + 1)";
		public const string E_IS_0_PC_INC = "if (E = 0) then (PC <= PC + 1)";
		public const string FGI_IS_1_PC_INC = "if (FGI = 1) then (PC <= PC + 1)";
		public const string FGO_IS_1_PC_INC = "if (FGO = 1) then (PC <= PC + 1)";
	}
}
