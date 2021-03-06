﻿/*************************************************************************
 *                                                                       *
 * This file is a part of the BSIM project: The Basic Computer Simulator *
 * Copyright (C) 2012-2014 Nima Alamatsaz, All rights reserved           *
 * Email: nialamat@gmail.com                                             *
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
using System.Windows.Forms;

namespace bsim
{
    public partial class MainForm : Form
    {
		SimCore sim = new SimCore();

        public MainForm()
        {
            InitializeComponent();
			SimInit();
			SimUpdate();
        }

		private void frmMain_Load(object sender, EventArgs e)
		{
			openFileDialog.InitialDirectory = Application.StartupPath;
		}

		private void btnNextCycle_Click(object sender, EventArgs e)
		{
			sim.NextCycle();
			SimUpdate();
		}

		private void btnNextInstruction_Click(object sender, EventArgs e)
		{
			sim.NextInstruction();
			SimUpdate();
		}

		private void btnLoadFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() != DialogResult.OK) return;
			if (!sim.LoadFile(openFileDialog.FileName))
			{
				MessageBox.Show("Cannot load memory file \"" + openFileDialog.FileName + "\"");
				return;
			}

			SimUpdate();
		}

		private void SimInit()
		{
			//lstMem.BeginUpdate();
			//lstMem.Items.Clear();
			//for (int i = 0; i < SimCore.mem_size; ++i)
			//    lstMem.Items.Add(i.ToString() + "\t " + Convert.ToString(sim.mem[i], 16) + "\t" + sim.mem[i].ToString());
			//lstMem.EndUpdate();

			for (int i = 0; i < SimCore.mem_size; ++i)
				grdMem.Rows.Add();
		}

		private void SimUpdate()
		{
			//lstMem.BeginUpdate();
			//for (int i = 0; i < SimCore.mem_size; ++i)
			//    lstMem.Items[i] = i.ToString() + "\t " + Convert.ToString(sim.mem[i], 16) + "\t" + sim.mem[i].ToString();
			//lstMem.EndUpdate();

			for (int i = 0; i < SimCore.mem_size; ++i)
			{
				string[] row = { i.ToString("d4"), sim.mem[i].ToString("d5"), "0x" + sim.mem[i].ToString("x4"), "0b" + Convert.ToInt64(Convert.ToString(sim.mem[i], 2)).ToString("d16"), sim.CodeToInstruction(sim.mem[i]) };
				grdMem.Rows[i].SetValues(row);
			}

			lblSC.Text = "SC: " + sim.cur.SC;
			lblAR.Text = "AR: " + sim.cur.AR;
			lblPC.Text = "PC: " + sim.cur.PC;
			lblDR.Text = "DR: " + sim.cur.DR;
			lblAC.Text = "AC: " + sim.cur.AC;
			lblINPR.Text = "INPR: " + sim.cur.INPR;
			lblIR.Text = "IR: " + sim.cur.IR;
			lblTR.Text = "TR: " + sim.cur.TR;
			lblOUTR.Text = "OUTR: " + sim.cur.OUTR;

			lblI.Text = "I: " + Convert.ToInt32(sim.cur.I);
			lblS.Text = "S: " + Convert.ToInt32(sim.cur.S);
			lblE.Text = "E: " + Convert.ToInt32(sim.cur.E);
			lblR.Text = "R: " + Convert.ToInt32(sim.cur.R);
			lblIEN.Text = "IEN: " + Convert.ToInt32(sim.cur.IEN);
			lblFGI.Text = "FGI: " + Convert.ToInt32(sim.cur.FGI);
			lblFGO.Text = "FGO: " + Convert.ToInt32(sim.cur.FGO);

			lblMemFile.Text = (sim.memFile == "" ? "No memory file loaded" : "Memory File:\n" + sim.memFile);
			lblCurInstruction.Text = "Current Instruction:\n" + sim.GetCurInstruction();
			var micros = sim.GetNextCycle();
			if (micros.Count == 0) micros.Add("None");
			lblMicros.Text = "Next Cycle Micro-Operation(s):\n" + string.Join("\n", micros);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
    }
}
