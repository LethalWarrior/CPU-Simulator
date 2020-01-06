namespace CPU_Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.LblPc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblInstructionName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblR1 = new System.Windows.Forms.Label();
            this.LblR3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblR2 = new System.Windows.Forms.Label();
            this.LblFlag = new System.Windows.Forms.Label();
            this.LblIr = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvMemory = new System.Windows.Forms.DataGridView();
            this.PnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PnlHeader.Controls.Add(this.label1);
            this.PnlHeader.Controls.Add(this.BtnClose);
            this.PnlHeader.Controls.Add(this.BtnMin);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1200, 63);
            this.PnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU Simulator";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1119, 15);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(63, 30);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            this.BtnClose.MouseHover += new System.EventHandler(this.BtnClose_MouseHover);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BtnMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMin.Location = new System.Drawing.Point(1048, 15);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(63, 30);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.TabStop = false;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            this.BtnMin.MouseLeave += new System.EventHandler(this.BtnMin_MouseLeave);
            this.BtnMin.MouseHover += new System.EventHandler(this.BtnMin_MouseHover);
            // 
            // LblPc
            // 
            this.LblPc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LblPc.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPc.ForeColor = System.Drawing.Color.White;
            this.LblPc.Location = new System.Drawing.Point(15, 59);
            this.LblPc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPc.Name = "LblPc";
            this.LblPc.Padding = new System.Windows.Forms.Padding(18);
            this.LblPc.Size = new System.Drawing.Size(575, 82);
            this.LblPc.TabIndex = 10;
            this.LblPc.Text = "0000000000000000";
            this.LblPc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(670, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Current Instruction :";
            // 
            // LblInstructionName
            // 
            this.LblInstructionName.ForeColor = System.Drawing.Color.White;
            this.LblInstructionName.Location = new System.Drawing.Point(873, 22);
            this.LblInstructionName.Name = "LblInstructionName";
            this.LblInstructionName.Size = new System.Drawing.Size(315, 17);
            this.LblInstructionName.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.BtnRun);
            this.panel1.Controls.Add(this.LblInstructionName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 707);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 129);
            this.panel1.TabIndex = 2;
            // 
            // BtnRun
            // 
            this.BtnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(168)))), ((int)(((byte)(14)))));
            this.BtnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BtnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRun.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRun.ForeColor = System.Drawing.Color.White;
            this.BtnRun.Image = ((System.Drawing.Image)(resources.GetObject("BtnRun.Image")));
            this.BtnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRun.Location = new System.Drawing.Point(19, 22);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(333, 82);
            this.BtnRun.TabIndex = 19;
            this.BtnRun.Text = "PROCESS";
            this.BtnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRun.UseVisualStyleBackColor = false;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblPc);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 504);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 162);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LblR1);
            this.groupBox1.Controls.Add(this.LblR3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblR2);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 392);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label6.Location = new System.Drawing.Point(64, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "R3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblR1
            // 
            this.LblR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LblR1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR1.ForeColor = System.Drawing.Color.White;
            this.LblR1.Location = new System.Drawing.Point(64, 72);
            this.LblR1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblR1.Name = "LblR1";
            this.LblR1.Padding = new System.Windows.Forms.Padding(18);
            this.LblR1.Size = new System.Drawing.Size(202, 56);
            this.LblR1.TabIndex = 18;
            this.LblR1.Text = "00000000";
            this.LblR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblR3
            // 
            this.LblR3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LblR3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR3.ForeColor = System.Drawing.Color.White;
            this.LblR3.Location = new System.Drawing.Point(64, 260);
            this.LblR3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblR3.Name = "LblR3";
            this.LblR3.Padding = new System.Windows.Forms.Padding(18);
            this.LblR3.Size = new System.Drawing.Size(202, 56);
            this.LblR3.TabIndex = 22;
            this.LblR3.Text = "00000000";
            this.LblR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label3.Location = new System.Drawing.Point(64, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "R1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label4.Location = new System.Drawing.Point(64, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "R2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblR2
            // 
            this.LblR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LblR2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR2.ForeColor = System.Drawing.Color.White;
            this.LblR2.Location = new System.Drawing.Point(64, 164);
            this.LblR2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblR2.Name = "LblR2";
            this.LblR2.Padding = new System.Windows.Forms.Padding(18);
            this.LblR2.Size = new System.Drawing.Size(202, 56);
            this.LblR2.TabIndex = 20;
            this.LblR2.Text = "00000000";
            this.LblR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFlag
            // 
            this.LblFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LblFlag.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFlag.ForeColor = System.Drawing.Color.White;
            this.LblFlag.Location = new System.Drawing.Point(37, 67);
            this.LblFlag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFlag.Name = "LblFlag";
            this.LblFlag.Padding = new System.Windows.Forms.Padding(18);
            this.LblFlag.Size = new System.Drawing.Size(202, 56);
            this.LblFlag.TabIndex = 28;
            this.LblFlag.Text = "00000000";
            this.LblFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblIr
            // 
            this.LblIr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LblIr.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIr.ForeColor = System.Drawing.Color.White;
            this.LblIr.Location = new System.Drawing.Point(37, 70);
            this.LblIr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIr.Name = "LblIr";
            this.LblIr.Padding = new System.Windows.Forms.Padding(18);
            this.LblIr.Size = new System.Drawing.Size(202, 56);
            this.LblIr.TabIndex = 26;
            this.LblIr.Text = "00000000";
            this.LblIr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblIr);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(358, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 162);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IR";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LblFlag);
            this.groupBox4.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(358, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 162);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flags";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(663, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(18);
            this.label2.Size = new System.Drawing.Size(519, 569);
            this.label2.TabIndex = 2;
            this.label2.Text = "Memory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.MaxInputLength = 16;
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // ValueColumn
            // 
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.MaxInputLength = 8;
            this.ValueColumn.Name = "ValueColumn";
            // 
            // DgvMemory
            // 
            this.DgvMemory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMemory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.DgvMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMemory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValueColumn,
            this.AddressColumn});
            this.DgvMemory.Location = new System.Drawing.Point(663, 151);
            this.DgvMemory.Margin = new System.Windows.Forms.Padding(4);
            this.DgvMemory.Name = "DgvMemory";
            this.DgvMemory.Size = new System.Drawing.Size(519, 515);
            this.DgvMemory.TabIndex = 3;
            this.DgvMemory.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMemory_CellEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 836);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvMemory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PnlHeader);
            this.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMemory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblInstructionName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblR1;
        private System.Windows.Forms.Label LblR3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblR2;
        private System.Windows.Forms.Label LblFlag;
        private System.Windows.Forms.Label LblIr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridView DgvMemory;
    }
}

