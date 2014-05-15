﻿/*************************************************************************
 *                                                                       *
 * This file is a part of the BSIM project: The Basic Computer Simulator *
 * Copyright (C) 2012-2014, Nima Alamatsaz, All rights reserved          *
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace bsim
{
	public class RegisterBoxDesigner : ControlDesigner
	{
		#region Overrided Methods
		protected override void PostFilterProperties(System.Collections.IDictionary properties)
		{
			//properties["TabStop"] = false;
			//properties["UseVisualStyleBackColor"] = false;
			//properties.Remove("BackColor");
			properties.Remove("BackgroundImage");
			properties.Remove("Font");
			properties.Remove("ForeColor");
			properties.Remove("Image");
			properties.Remove("ImageIndex");
			properties.Remove("ImageKey");
			properties.Remove("ImageList");
			properties.Remove("ImageAlign");
			properties.Remove("TabStop");
		}
		#endregion
	}
}