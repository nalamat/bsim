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
			this.btnNextCycle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnNextCycle.Location = new System.Drawing.Point(98, 51);
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
			this.lblAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblAR.BackColor = System.Drawing.Color.LightBlue;
			this.lblAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAR.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblAR.Location = new System.Drawing.Point(323, 80);
			this.lblAR.Name = "lblAR";
			this.lblAR.Size = new System.Drawing.Size(147, 50);
			this.lblAR.TabIndex = 1;
			this.lblAR.Text = "lblAR";
			this.lblAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAR.UseCompatibleTextRendering = true;
			// 
			// lblPC
			// 
			this.lblPC.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblPC.BackColor = System.Drawing.Color.LightBlue;
			this.lblPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPC.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblPC.Location = new System.Drawing.Point(323, 130);
			this.lblPC.Name = "lblPC";
			this.lblPC.Size = new System.Drawing.Size(147, 50);
			this.lblPC.TabIndex = 2;
			this.lblPC.Text = "lblPC";
			this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblPC.UseCompatibleTextRendering = true;
			// 
			// lblDR
			// 
			this.lblDR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblDR.BackColor = System.Drawing.Color.LightBlue;
			this.lblDR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDR.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblDR.Location = new System.Drawing.Point(323, 180);
			this.lblDR.Name = "lblDR";
			this.lblDR.Size = new System.Drawing.Size(147, 50);
			this.lblDR.TabIndex = 3;
			this.lblDR.Text = "lblDR";
			this.lblDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDR.UseCompatibleTextRendering = true;
			// 
			// lblIR
			// 
			this.lblIR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblIR.BackColor = System.Drawing.Color.LightBlue;
			this.lblIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIR.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblIR.Location = new System.Drawing.Point(323, 330);
			this.lblIR.Name = "lblIR";
			this.lblIR.Size = new System.Drawing.Size(147, 50);
			this.lblIR.TabIndex = 6;
			this.lblIR.Text = "lblIR";
			this.lblIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblIR.UseCompatibleTextRendering = true;
			// 
			// lblINPR
			// 
			this.lblINPR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblINPR.BackColor = System.Drawing.Color.LightBlue;
			this.lblINPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblINPR.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblINPR.Location = new System.Drawing.Point(323, 280);
			this.lblINPR.Name = "lblINPR";
			this.lblINPR.Size = new System.Drawing.Size(147, 50);
			this.lblINPR.TabIndex = 5;
			this.lblINPR.Text = "lblINPR";
			this.lblINPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblINPR.UseCompatibleTextRendering = true;
			// 
			// lblAC
			// 
			this.lblAC.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblAC.BackColor = System.Drawing.Color.LightBlue;
			this.lblAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAC.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblAC.Location = new System.Drawing.Point(323, 230);
			this.lblAC.Name = "lblAC";
			this.lblAC.Size = new System.Drawing.Size(147, 50);
			this.lblAC.TabIndex = 4;
			this.lblAC.Text = "lblAC";
			this.lblAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAC.UseCompatibleTextRendering = true;
			// 
			// lblTR
			// 
			this.lblTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTR.BackColor = System.Drawing.Color.LightBlue;
			this.lblTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTR.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblTR.Location = new System.Drawing.Point(323, 380);
			this.lblTR.Name = "lblTR";
			this.lblTR.Size = new System.Drawing.Size(147, 50);
			this.lblTR.TabIndex = 7;
			this.lblTR.Text = "lblTR";
			this.lblTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTR.UseCompatibleTextRendering = true;
			// 
			// lblOUTR
			// 
			this.lblOUTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblOUTR.BackColor = System.Drawing.Color.LightBlue;
			this.lblOUTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblOUTR.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblOUTR.Location = new System.Drawing.Point(323, 430);
			this.lblOUTR.Name = "lblOUTR";
			this.lblOUTR.Size = new System.Drawing.Size(147, 50);
			this.lblOUTR.TabIndex = 8;
			this.lblOUTR.Text = "lblOUTR";
			this.lblOUTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblOUTR.UseCompatibleTextRendering = true;
			// 
			// btnLoadFile
			// 
			this.btnLoadFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLoadFile.Location = new System.Drawing.Point(98, 17);
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
			this.openFileDialog.Filter = "Object file and Intel HEX format|*.obj;*.hex";
			this.openFileDialog.InitialDirectory = "D:\\prog\\cs\\bsim\\test\\";
			this.openFileDialog.Title = "Open Memory File";
			// 
			// lblMemFile
			// 
			this.lblMemFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblMemFile.BackColor = System.Drawing.Color.Aqua;
			this.lblMemFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMemFile.Location = new System.Drawing.Point(19, 117);
			this.lblMemFile.Name = "lblMemFile";
			this.lblMemFile.Size = new System.Drawing.Size(290, 63);
			this.lblMemFile.TabIndex = 10;
			this.lblMemFile.Text = "lblMemFile";
			this.lblMemFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMemFile.UseCompatibleTextRendering = true;
			// 
			// lblSC
			// 
			this.lblSC.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblSC.BackColor = System.Drawing.Color.LightBlue;
			this.lblSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSC.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblSC.Location = new System.Drawing.Point(323, 30);
			this.lblSC.Name = "lblSC";
			this.lblSC.Size = new System.Drawing.Size(147, 50);
			this.lblSC.TabIndex = 11;
			this.lblSC.Text = "lblSC";
			this.lblSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSC.UseCompatibleTextRendering = true;
			// 
			// btnNextInstruction
			// 
			this.btnNextInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnNextInstruction.Location = new System.Drawing.Point(98, 83);
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
			this.lblMicros.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblMicros.BackColor = System.Drawing.Color.Aqua;
			this.lblMicros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMicros.Location = new System.Drawing.Point(19, 255);
			this.lblMicros.Name = "lblMicros";
			this.lblMicros.Size = new System.Drawing.Size(290, 129);
			this.lblMicros.TabIndex = 14;
			this.lblMicros.Text = "lblMicros";
			this.lblMicros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblMicros.UseCompatibleTextRendering = true;
			// 
			// lblCurInstruction
			// 
			this.lblCurInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCurInstruction.BackColor = System.Drawing.Color.Aqua;
			this.lblCurInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCurInstruction.Location = new System.Drawing.Point(19, 186);
			this.lblCurInstruction.Name = "lblCurInstruction";
			this.lblCurInstruction.Size = new System.Drawing.Size(290, 63);
			this.lblCurInstruction.TabIndex = 15;
			this.lblCurInstruction.Text = "lblCurInstruction";
			this.lblCurInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCurInstruction.UseCompatibleTextRendering = true;
			// 
			// lblI
			// 
			this.lblI.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblI.BackColor = System.Drawing.Color.LightBlue;
			this.lblI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblI.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblI.Location = new System.Drawing.Point(34, 392);
			this.lblI.Name = "lblI";
			this.lblI.Size = new System.Drawing.Size(65, 50);
			this.lblI.TabIndex = 16;
			this.lblI.Text = "lblI";
			this.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblI.UseCompatibleTextRendering = true;
			// 
			// lblS
			// 
			this.lblS.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblS.BackColor = System.Drawing.Color.LightBlue;
			this.lblS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblS.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblS.Location = new System.Drawing.Point(99, 392);
			this.lblS.Name = "lblS";
			this.lblS.Size = new System.Drawing.Size(65, 50);
			this.lblS.TabIndex = 17;
			this.lblS.Text = "lblS";
			this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblS.UseCompatibleTextRendering = true;
			// 
			// lblE
			// 
			this.lblE.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblE.BackColor = System.Drawing.Color.LightBlue;
			this.lblE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblE.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblE.Location = new System.Drawing.Point(164, 392);
			this.lblE.Name = "lblE";
			this.lblE.Size = new System.Drawing.Size(65, 50);
			this.lblE.TabIndex = 18;
			this.lblE.Text = "lblE";
			this.lblE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblE.UseCompatibleTextRendering = true;
			// 
			// lblR
			// 
			this.lblR.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblR.BackColor = System.Drawing.Color.LightBlue;
			this.lblR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblR.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblR.Location = new System.Drawing.Point(229, 392);
			this.lblR.Name = "lblR";
			this.lblR.Size = new System.Drawing.Size(65, 50);
			this.lblR.TabIndex = 19;
			this.lblR.Text = "lblR";
			this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblR.UseCompatibleTextRendering = true;
			// 
			// lblIEN
			// 
			this.lblIEN.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblIEN.BackColor = System.Drawing.Color.LightBlue;
			this.lblIEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIEN.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblIEN.Location = new System.Drawing.Point(67, 442);
			this.lblIEN.Name = "lblIEN";
			this.lblIEN.Size = new System.Drawing.Size(65, 50);
			this.lblIEN.TabIndex = 20;
			this.lblIEN.Text = "lblIEN";
			this.lblIEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblIEN.UseCompatibleTextRendering = true;
			// 
			// lblFGI
			// 
			this.lblFGI.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblFGI.BackColor = System.Drawing.Color.LightBlue;
			this.lblFGI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFGI.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblFGI.Location = new System.Drawing.Point(132, 442);
			this.lblFGI.Name = "lblFGI";
			this.lblFGI.Size = new System.Drawing.Size(65, 50);
			this.lblFGI.TabIndex = 21;
			this.lblFGI.Text = "lblFGI";
			this.lblFGI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFGI.UseCompatibleTextRendering = true;
			// 
			// lblFGO
			// 
			this.lblFGO.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblFGO.BackColor = System.Drawing.Color.LightBlue;
			this.lblFGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFGO.Font = new System.Drawing.Font("Comic Sans MS", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblFGO.Location = new System.Drawing.Point(197, 442);
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
			this.grdMem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.grdMem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
			this.grdMem.Size = new System.Drawing.Size(560, 493);
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
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1057, 518);
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
			this.Font = new System.Drawing.Font("Comic Sans MS", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Basic Computer Simulator";
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

