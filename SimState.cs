/*************************************************************************
 *                                                                       *
 * This file is a part of the BSIM project: The Basic Computer Simulator *
 * Copyright (C) 2012-2014, Nima Alamatsaz, All rights reserved          *
 * Email: nnalamat@gmail.com                                             *
 * Web:   http://github.com/nalamat/bsim                                 *
 *                                                                       *
 * BSIM is free software: you can redistribute it and/or modify it       *
 * under the terms of the GNU General Public License version 3 as        *
 * published by the Free Software Foundation.                            *
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
using System.Runtime.Serialization;

namespace bsim
{
	// to copy objects using ObjectCopier helper class, class must be serializable
	[Serializable()]
	class SimState : ICloneable
	{
		public int CycleCounter;
		public ushort SC, AR, PC, DR, AC, INPR, IR, TR, OUTR;
		public bool I, S, E, R, IEN, FGI, FGO;
		public bool MEM_RD, MEM_WR, MEM_EN;
		public bool AR_LD, AR_CLR, AR_INC, AR_EN;
		public bool PC_LD, PC_CLR, PC_INC, PC_EN;
		public bool DR_LD, DR_CLR, DR_INC, DR_EN;
		public bool AC_LD, AC_CLR, AC_INC, AC_EN;
		public bool IR_LD, IR_CLR, IR_INC, IR_EN;
		public bool TR_LD, TR_CLR, TR_INC, TR_EN;
		public bool OUTR_LD, r, p;
		public bool[] T = new bool[16], D = new bool[8], B = new bool[12];

		public SimState()
		{
			// initialize everything but T[0] to zero
			CycleCounter = 0;
			SC = AR = PC = DR = AC = INPR = IR = TR = OUTR = 0;
			S = true;
			I = E = R = IEN = FGI = FGO = false;
			MEM_RD = MEM_WR = MEM_EN = false;
			AR_LD = AR_CLR = AR_INC = AR_EN = false;
			PC_LD = PC_CLR = PC_INC = PC_EN = false;
			DR_LD = DR_CLR = DR_INC = DR_EN = false;
			AC_LD = AC_CLR = AC_INC = AC_EN = false;
			IR_LD = IR_CLR = IR_INC = IR_EN = false;
			TR_LD = TR_CLR = TR_INC = TR_EN = false;
			OUTR_LD = r = p = false;
			T[0] = true;
			for (int i = 1; i < T.Length; ++i) T[i] = false;
			for (int i = 0; i < D.Length; ++i) D[i] = false;
		}

		// implement the useless ICloneable.Clone() function to suppress errors
		object ICloneable.Clone()
		{
			return this.Clone();
		}

		// deep copy using ObjectCopier.Clone()
		public SimState Clone()
		{
			return ObjectCopier.Clone(this);
		}

		// shallow copy
		public SimState ShallowCopy()
		{
			return (SimState)this.MemberwiseClone();
		}
	}
}
