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

namespace bsim
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnNextCycle = new System.Windows.Forms.Button();
			this.lblAR = new System.Windows.Forms.Label();
			this.lblPC = new System.Windows.Forms.Label();
			this.lblDR = new System.Windows.Forms.Label();
			this.lblIR = new System.Windows.Forms.Label();
			this.lblINPR = new System.Windows.Forms.Label();
			this.lblAC = new System.Windows.Forms.Label();
			this.lblTR = new System.Windows.Forms.Label();
			this.lblOUTR = new System.Windows.Forms.Label();
			this.btnLoadFile = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.lblMemFile = new System.Windows.Forms.Label();
			this.lblSC = new System.Windows.Forms.Label();
			this.btnNextInstruction = new System.Windows.Forms.Button();
			this.lblMicros = new System.Windows.Forms.Label();
			this.lblCurInstruction = new System.Windows.Forms.Label();
			this.lblI = new System.Windows.Forms.Label();
			this.lblS = new System.Windows.Forms.Label();
			this.lblE = new System.Windows.Forms.Label();
			this.lblR = new System.Windows.Forms.Label();
			this.lblIEN = new System.Windows.Forms.Label();
			this.lblFGI = new System.Windows.Forms.Label();
			this.lblFGO = new System.Windows.Forms.Label();
			this.grdMem = new System.Windows.Forms.DataGridView();
			this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCodeUshort = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCodeHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCodeBin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colInstruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdMem)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNextCycle
			// 
			this.btnNextCycle.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnNextCycle.Location = new System.Drawing.Point(98, 53);
			this.btnNextCycle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNextCycle.Name = "btnNextCycle";
			this.btnNextCycle.Size = new System.Drawing.Size(133, 28);
			this.btnNextCycle.TabIndex = 0;
			this.btnNextCycle.Text = "Next Cycle";
			this.btnNextCycle.UseCompatibleTextRendering = true;
			this.btnNextCycle.UseVisualStyleBackColor = true;
			this.btnNextCycle.Click += new System.EventHandler(this.btnNextCycle_Click);
			// 
			// lblAR
			// 
			this.lblAR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblAR.BackColor = System.Drawing.Color.LightBlue;
			this.lblAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAR.Location = new System.Drawing.Point(323, 68);
			this.lblAR.Name = "lblAR";
			this.lblAR.Size = new System.Drawing.Size(147, 50);
			this.lblAR.TabIndex = 1;
			this.lblAR.Text = "lblAR";
			this.lblAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAR.UseCompatibleTextRendering = true;
			// 
			// lblPC
			// 
			this.lblPC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPC.BackColor = System.Drawing.Color.LightBlue;
			this.lblPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPC.Location = new System.Drawing.Point(323, 118);
			this.lblPC.Name = "lblPC";
			this.lblPC.Size = new System.Drawing.Size(147, 50);
			this.lblPC.TabIndex = 2;
			this.lblPC.Text = "lblPC";
			this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblPC.UseCompatibleTextRendering = true;
			// 
			// lblDR
			// 
			this.lblDR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDR.BackColor = System.Drawing.Color.LightBlue;
			this.lblDR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDR.Location = new System.Drawing.Point(323, 168);
			this.lblDR.Name = "lblDR";
			this.lblDR.Size = new System.Drawing.Size(147, 50);
			this.lblDR.TabIndex = 3;
			this.lblDR.Text = "lblDR";
			this.lblDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDR.UseCompatibleTextRendering = true;
			// 
			// lblIR
			// 
			this.lblIR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblIR.BackColor = System.Drawing.Color.LightBlue;
			this.lblIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIR.Location = new System.Drawing.Point(323, 318);
			this.lblIR.Name = "lblIR";
			this.lblIR.Size = new System.Drawing.Size(147, 50);
			this.lblIR.TabIndex = 6;
			this.lblIR.Text = "lblIR";
			this.lblIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblIR.UseCompatibleTextRendering = true;
			// 
			// lblINPR
			// 
			this.lblINPR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblINPR.BackColor = System.Drawing.Color.LightBlue;
			this.lblINPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblINPR.Location = new System.Drawing.Point(323, 268);
			this.lblINPR.Name = "lblINPR";
			this.lblINPR.Size = new System.Drawing.Size(147, 50);
			this.lblINPR.TabIndex = 5;
			this.lblINPR.Text = "lblINPR";
			this.lblINPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblINPR.UseCompatibleTextRendering = true;
			// 
			// lblAC
			// 
			this.lblAC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblAC.BackColor = System.Drawing.Color.LightBlue;
			this.lblAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAC.Location = new System.Drawing.Point(323, 218);
			this.lblAC.Name = "lblAC";
			this.lblAC.Size = new System.Drawing.Size(147, 50);
			this.lblAC.TabIndex = 4;
			this.lblAC.Text = "lblAC";
			this.lblAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAC.UseCompatibleTextRendering = true;
			// 
			// lblTR
			// 
			this.lblTR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTR.BackColor = System.Drawing.Color.LightBlue;
			this.lblTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTR.Location = new System.Drawing.Point(323, 368);
			this.lblTR.Name = "lblTR";
			this.lblTR.Size = new System.Drawing.Size(147, 50);
			this.lblTR.TabIndex = 7;
			this.lblTR.Text = "lblTR";
			this.lblTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTR.UseCompatibleTextRendering = true;
			// 
			// lblOUTR
			// 
			this.lblOUTR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOUTR.BackColor = System.Drawing.Color.LightBlue;
			this.lblOUTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOUTR.Location = new System.Drawing.Point(323, 418);
			this.lblOUTR.Name = "lblOUTR";
			this.lblOUTR.Size = new System.Drawing.Size(147, 50);
			this.lblOUTR.TabIndex = 8;
			this.lblOUTR.Text = "lblOUTR";
			this.lblOUTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblOUTR.UseCompatibleTextRendering = true;
			// 
			// btnLoadFile
			// 
			this.btnLoadFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnLoadFile.Location = new System.Drawing.Point(98, 19);
			this.btnLoadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLoadFile.Name = "btnLoadFile";
			this.btnLoadFile.Size = new System.Drawing.Size(133, 28);
			this.btnLoadFile.TabIndex = 9;
			this.btnLoadFile.Text = "Load File";
			this.btnLoadFile.UseCompatibleTextRendering = true;
			this.btnLoadFile.UseVisualStyleBackColor = true;
			this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.AddExtension = false;
			this.openFileDialog.FileName = "test.obj";
			this.openFileDialog.Filter = "Object file or Intel HEX format|*.obj;*.hex";
			this.openFileDialog.Title = "Open Memory File";
			// 
			// lblMemFile
			// 
			this.lblMemFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMemFile.BackColor = System.Drawing.Color.Aqua;
			this.lblMemFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMemFile.Location = new System.Drawing.Point(19, 119);
			this.lblMemFile.Name = "lblMemFile";
			this.lblMemFile.Size = new System.Drawing.Size(290, 63);
			this.lblMemFile.TabIndex = 10;
			this.lblMemFile.Text = "lblMemFile";
			this.lblMemFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMemFile.UseCompatibleTextRendering = true;
			// 
			// lblSC
			// 
			this.lblSC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSC.BackColor = System.Drawing.Color.LightBlue;
			this.lblSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSC.Location = new System.Drawing.Point(323, 18);
			this.lblSC.Name = "lblSC";
			this.lblSC.Size = new System.Drawing.Size(147, 50);
			this.lblSC.TabIndex = 11;
			this.lblSC.Text = "lblSC";
			this.lblSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSC.UseCompatibleTextRendering = true;
			// 
			// btnNextInstruction
			// 
			this.btnNextInstruction.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnNextInstruction.Location = new System.Drawing.Point(98, 85);
			this.btnNextInstruction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNextInstruction.Name = "btnNextInstruction";
			this.btnNextInstruction.Size = new System.Drawing.Size(133, 28);
			this.btnNextInstruction.TabIndex = 12;
			this.btnNextInstruction.Text = "Next Instruction";
			this.btnNextInstruction.UseCompatibleTextRendering = true;
			this.btnNextInstruction.UseVisualStyleBackColor = true;
			this.btnNextInstruction.Click += new System.EventHandler(this.btnNextInstruction_Click);
			// 
			// lblMicros
			// 
			this.lblMicros.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMicros.BackColor = System.Drawing.Color.Aqua;
			this.lblMicros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMicros.Location = new System.Drawing.Point(19, 257);
			this.lblMicros.Name = "lblMicros";
			this.lblMicros.Size = new System.Drawing.Size(290, 100);
			this.lblMicros.TabIndex = 14;
			this.lblMicros.Text = "lblMicros";
			this.lblMicros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMicros.UseCompatibleTextRendering = true;
			// 
			// lblCurInstruction
			// 
			this.lblCurInstruction.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCurInstruction.BackColor = System.Drawing.Color.Aqua;
			this.lblCurInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCurInstruction.Location = new System.Drawing.Point(19, 188);
			this.lblCurInstruction.Name = "lblCurInstruction";
			this.lblCurInstruction.Size = new System.Drawing.Size(290, 63);
			this.lblCurInstruction.TabIndex = 15;
			this.lblCurInstruction.Text = "lblCurInstruction";
			this.lblCurInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCurInstruction.UseCompatibleTextRendering = true;
			// 
			// lblI
			// 
			this.lblI.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblI.BackColor = System.Drawing.Color.LightBlue;
			this.lblI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblI.Location = new System.Drawing.Point(34, 363);
			this.lblI.Name = "lblI";
			this.lblI.Size = new System.Drawing.Size(65, 50);
			this.lblI.TabIndex = 16;
			this.lblI.Text = "lblI";
			this.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblI.UseCompatibleTextRendering = true;
			// 
			// lblS
			// 
			this.lblS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblS.BackColor = System.Drawing.Color.LightBlue;
			this.lblS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblS.Location = new System.Drawing.Point(99, 363);
			this.lblS.Name = "lblS";
			this.lblS.Size = new System.Drawing.Size(65, 50);
			this.lblS.TabIndex = 17;
			this.lblS.Text = "lblS";
			this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblS.UseCompatibleTextRendering = true;
			// 
			// lblE
			// 
			this.lblE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblE.BackColor = System.Drawing.Color.LightBlue;
			this.lblE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblE.Location = new System.Drawing.Point(164, 363);
			this.lblE.Name = "lblE";
			this.lblE.Size = new System.Drawing.Size(65, 50);
			this.lblE.TabIndex = 18;
			this.lblE.Text = "lblE";
			this.lblE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblE.UseCompatibleTextRendering = true;
			// 
			// lblR
			// 
			this.lblR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblR.BackColor = System.Drawing.Color.LightBlue;
			this.lblR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblR.Location = new System.Drawing.Point(229, 363);
			this.lblR.Name = "lblR";
			this.lblR.Size = new System.Drawing.Size(65, 50);
			this.lblR.TabIndex = 19;
			this.lblR.Text = "lblR";
			this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblR.UseCompatibleTextRendering = true;
			// 
			// lblIEN
			// 
			this.lblIEN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblIEN.BackColor = System.Drawing.Color.LightBlue;
			this.lblIEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIEN.Location = new System.Drawing.Point(67, 413);
			this.lblIEN.Name = "lblIEN";
			this.lblIEN.Size = new System.Drawing.Size(65, 50);
			this.lblIEN.TabIndex = 20;
			this.lblIEN.Text = "lblIEN";
			this.lblIEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblIEN.UseCompatibleTextRendering = true;
			// 
			// lblFGI
			// 
			this.lblFGI.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFGI.BackColor = System.Drawing.Color.LightBlue;
			this.lblFGI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFGI.Location = new System.Drawing.Point(132, 413);
			this.lblFGI.Name = "lblFGI";
			this.lblFGI.Size = new System.Drawing.Size(65, 50);
			this.lblFGI.TabIndex = 21;
			this.lblFGI.Text = "lblFGI";
			this.lblFGI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFGI.UseCompatibleTextRendering = true;
			// 
			// lblFGO
			// 
			this.lblFGO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFGO.BackColor = System.Drawing.Color.LightBlue;
			this.lblFGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFGO.Location = new System.Drawing.Point(197, 413);
			this.lblFGO.Name = "lblFGO";
			this.lblFGO.Size = new System.Drawing.Size(65, 50);
			this.lblFGO.TabIndex = 22;
			this.lblFGO.Text = "lblFGO";
			this.lblFGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFGO.UseCompatibleTextRendering = true;
			// 
			// grdMem
			// 
			this.grdMem.AllowUserToAddRows = false;
			this.grdMem.AllowUserToDeleteRows = false;
			this.grdMem.AllowUserToResizeRows = false;
			this.grdMem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdMem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdMem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grdMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddress,
            this.colCodeUshort,
            this.colCodeHex,
            this.colCodeBin,
            this.colInstruction});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdMem.DefaultCellStyle = dataGridViewCellStyle2;
			this.grdMem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grdMem.Location = new System.Drawing.Point(481, 11);
			this.grdMem.MultiSelect = false;
			this.grdMem.Name = "grdMem";
			this.grdMem.RowHeadersWidth = 30;
			this.grdMem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.grdMem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdMem.Size = new System.Drawing.Size(560, 462);
			this.grdMem.TabIndex = 25;
			// 
			// colAddress
			// 
			this.colAddress.FillWeight = 70F;
			this.colAddress.HeaderText = "Address";
			this.colAddress.Name = "colAddress";
			this.colAddress.ReadOnly = true;
			this.colAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colCodeUshort
			// 
			this.colCodeUshort.FillWeight = 90F;
			this.colCodeUshort.HeaderText = "Code\n(unsigned)";
			this.colCodeUshort.Name = "colCodeUshort";
			this.colCodeUshort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colCodeHex
			// 
			this.colCodeHex.FillWeight = 80F;
			this.colCodeHex.HeaderText = "Code\n(hex)";
			this.colCodeHex.Name = "colCodeHex";
			this.colCodeHex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colCodeBin
			// 
			this.colCodeBin.FillWeight = 140F;
			this.colCodeBin.HeaderText = "Code\n(bin)";
			this.colCodeBin.Name = "colCodeBin";
			this.colCodeBin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colInstruction
			// 
			this.colInstruction.FillWeight = 90F;
			this.colInstruction.HeaderText = "Instruction";
			this.colInstruction.Name = "colInstruction";
			this.colInstruction.ReadOnly = true;
			this.colInstruction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1057, 487);
			this.Controls.Add(this.grdMem);
			this.Controls.Add(this.lblFGO);
			this.Controls.Add(this.lblFGI);
			this.Controls.Add(this.lblIEN);
			this.Controls.Add(this.lblR);
			this.Controls.Add(this.lblE);
			this.Controls.Add(this.lblS);
			this.Controls.Add(this.lblI);
			this.Controls.Add(this.lblCurInstruction);
			this.Controls.Add(this.lblMicros);
			this.Controls.Add(this.btnNextInstruction);
			this.Controls.Add(this.lblSC);
			this.Controls.Add(this.lblMemFile);
			this.Controls.Add(this.btnLoadFile);
			this.Controls.Add(this.lblOUTR);
			this.Controls.Add(this.lblTR);
			this.Controls.Add(this.lblIR);
			this.Controls.Add(this.lblINPR);
			this.Controls.Add(this.lblAC);
			this.Controls.Add(this.lblDR);
			this.Controls.Add(this.lblPC);
			this.Controls.Add(this.lblAR);
			this.Controls.Add(this.btnNextCycle);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "The Basic Computer Simulator";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdMem)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button btnNextCycle;
		private System.Windows.Forms.Label lblAR;
		private System.Windows.Forms.Label lblPC;
		private System.Windows.Forms.Label lblDR;
		private System.Windows.Forms.Label lblIR;
		private System.Windows.Forms.Label lblINPR;
		private System.Windows.Forms.Label lblAC;
		private System.Windows.Forms.Label lblTR;
		private System.Windows.Forms.Label lblOUTR;
		private System.Windows.Forms.Button btnLoadFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label lblMemFile;
		private System.Windows.Forms.Label lblSC;
		private System.Windows.Forms.Button btnNextInstruction;
		private System.Windows.Forms.Label lblMicros;
		private System.Windows.Forms.Label lblCurInstruction;
		private System.Windows.Forms.Label lblI;
		private System.Windows.Forms.Label lblS;
		private System.Windows.Forms.Label lblE;
		private System.Windows.Forms.Label lblR;
		private System.Windows.Forms.Label lblIEN;
		private System.Windows.Forms.Label lblFGI;
		private System.Windows.Forms.Label lblFGO;
		private System.Windows.Forms.DataGridView grdMem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodeUshort;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodeHex;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodeBin;
		private System.Windows.Forms.DataGridViewTextBoxColumn colInstruction;
    }
}

