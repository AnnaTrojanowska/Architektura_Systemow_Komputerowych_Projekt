
namespace Intel_8086
{
    partial class Form1
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
            this.Reset1 = new System.Windows.Forms.Button();
            this.AXLabel = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Button();
            this.AX_text = new System.Windows.Forms.TextBox();
            this.BX_text = new System.Windows.Forms.TextBox();
            this.BXLabel = new System.Windows.Forms.Label();
            this.CXLabel = new System.Windows.Forms.Label();
            this.DXLabel = new System.Windows.Forms.Label();
            this.CX_text = new System.Windows.Forms.TextBox();
            this.DX_text = new System.Windows.Forms.TextBox();
            this.SI_text = new System.Windows.Forms.TextBox();
            this.SILabel = new System.Windows.Forms.Label();
            this.DILabel = new System.Windows.Forms.Label();
            this.DI_text = new System.Windows.Forms.TextBox();
            this.BPLabel = new System.Windows.Forms.Label();
            this.BP_text = new System.Windows.Forms.TextBox();
            this.SPLabel = new System.Windows.Forms.Label();
            this.SP_text = new System.Windows.Forms.TextBox();
            this.DISPLabel = new System.Windows.Forms.Label();
            this.DISP_text = new System.Windows.Forms.TextBox();
            this.Reset2 = new System.Windows.Forms.Button();
            this.Mem_move = new System.Windows.Forms.Button();
            this.Mem_Xchg = new System.Windows.Forms.Button();
            this.BX_TO_AX = new System.Windows.Forms.Button();
            this.CX_TO_AX = new System.Windows.Forms.Button();
            this.DX_TO_AX = new System.Windows.Forms.Button();
            this.AX_TO_BX = new System.Windows.Forms.Button();
            this.CX_TO_BX = new System.Windows.Forms.Button();
            this.DX_TO_BX = new System.Windows.Forms.Button();
            this.AX_TO_CX = new System.Windows.Forms.Button();
            this.BX_TO_CX = new System.Windows.Forms.Button();
            this.DX_TO_CX = new System.Windows.Forms.Button();
            this.AX_TO_DX = new System.Windows.Forms.Button();
            this.BX_TO_DX = new System.Windows.Forms.Button();
            this.CX_TO_DX = new System.Windows.Forms.Button();
            this.XCHG_DX_CX = new System.Windows.Forms.Button();
            this.XCHG_DX_BX = new System.Windows.Forms.Button();
            this.XCHG_DX_AX = new System.Windows.Forms.Button();
            this.XCHG_CX_DX = new System.Windows.Forms.Button();
            this.XCHG_CX_BX = new System.Windows.Forms.Button();
            this.XCHG_CX_AX = new System.Windows.Forms.Button();
            this.XCHG_BX_DX = new System.Windows.Forms.Button();
            this.XCHG_BX_CX = new System.Windows.Forms.Button();
            this.XCHG_BX_AX = new System.Windows.Forms.Button();
            this.XCHG_AX_DX = new System.Windows.Forms.Button();
            this.XCHG_AX_CX = new System.Windows.Forms.Button();
            this.XCHG_AX_BX = new System.Windows.Forms.Button();
            this.Push_AX = new System.Windows.Forms.Button();
            this.Push_BX = new System.Windows.Forms.Button();
            this.Push_CX = new System.Windows.Forms.Button();
            this.Push_DX = new System.Windows.Forms.Button();
            this.Pop_AX = new System.Windows.Forms.Button();
            this.Pop_BX = new System.Windows.Forms.Button();
            this.Pop_CX = new System.Windows.Forms.Button();
            this.Pop_DX = new System.Windows.Forms.Button();
            this.Random2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mem_To_Reg = new System.Windows.Forms.RadioButton();
            this.Reg_To_Mem = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Index_base_check = new System.Windows.Forms.RadioButton();
            this.Base_check = new System.Windows.Forms.RadioButton();
            this.Index_check = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DI_check = new System.Windows.Forms.RadioButton();
            this.SI_check = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AX_check = new System.Windows.Forms.RadioButton();
            this.DX_check = new System.Windows.Forms.RadioButton();
            this.CX_check = new System.Windows.Forms.RadioButton();
            this.BX_check = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BP_check = new System.Windows.Forms.RadioButton();
            this.BX2_check = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DI_BP_check = new System.Windows.Forms.RadioButton();
            this.SI_BP_check = new System.Windows.Forms.RadioButton();
            this.DI_BX_check = new System.Windows.Forms.RadioButton();
            this.SI_BX_check = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reset1
            // 
            this.Reset1.Location = new System.Drawing.Point(71, 15);
            this.Reset1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reset1.Name = "Reset1";
            this.Reset1.Size = new System.Drawing.Size(100, 28);
            this.Reset1.TabIndex = 0;
            this.Reset1.Text = "Reset";
            this.Reset1.UseVisualStyleBackColor = true;
            this.Reset1.Click += new System.EventHandler(this.Reset1_Click);
            // 
            // AXLabel
            // 
            this.AXLabel.AutoSize = true;
            this.AXLabel.Location = new System.Drawing.Point(16, 57);
            this.AXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AXLabel.Name = "AXLabel";
            this.AXLabel.Size = new System.Drawing.Size(26, 17);
            this.AXLabel.TabIndex = 1;
            this.AXLabel.Text = "AX";
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(179, 15);
            this.Random.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(100, 28);
            this.Random.TabIndex = 2;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // AX_text
            // 
            this.AX_text.Location = new System.Drawing.Point(71, 53);
            this.AX_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AX_text.Name = "AX_text";
            this.AX_text.Size = new System.Drawing.Size(132, 22);
            this.AX_text.TabIndex = 3;
            this.AX_text.Text = "0000";
            this.AX_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BX_text
            // 
            this.BX_text.Location = new System.Drawing.Point(71, 85);
            this.BX_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BX_text.Name = "BX_text";
            this.BX_text.Size = new System.Drawing.Size(132, 22);
            this.BX_text.TabIndex = 4;
            this.BX_text.Text = "0000";
            this.BX_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BXLabel
            // 
            this.BXLabel.AutoSize = true;
            this.BXLabel.Location = new System.Drawing.Point(16, 89);
            this.BXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BXLabel.Name = "BXLabel";
            this.BXLabel.Size = new System.Drawing.Size(26, 17);
            this.BXLabel.TabIndex = 5;
            this.BXLabel.Text = "BX";
            // 
            // CXLabel
            // 
            this.CXLabel.AutoSize = true;
            this.CXLabel.Location = new System.Drawing.Point(16, 121);
            this.CXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CXLabel.Name = "CXLabel";
            this.CXLabel.Size = new System.Drawing.Size(26, 17);
            this.CXLabel.TabIndex = 6;
            this.CXLabel.Text = "CX";
            // 
            // DXLabel
            // 
            this.DXLabel.AutoSize = true;
            this.DXLabel.Location = new System.Drawing.Point(16, 153);
            this.DXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DXLabel.Name = "DXLabel";
            this.DXLabel.Size = new System.Drawing.Size(27, 17);
            this.DXLabel.TabIndex = 7;
            this.DXLabel.Text = "DX";
            // 
            // CX_text
            // 
            this.CX_text.Location = new System.Drawing.Point(71, 117);
            this.CX_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CX_text.Name = "CX_text";
            this.CX_text.Size = new System.Drawing.Size(132, 22);
            this.CX_text.TabIndex = 8;
            this.CX_text.Text = "0000";
            this.CX_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DX_text
            // 
            this.DX_text.Location = new System.Drawing.Point(71, 149);
            this.DX_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DX_text.Name = "DX_text";
            this.DX_text.Size = new System.Drawing.Size(132, 22);
            this.DX_text.TabIndex = 9;
            this.DX_text.Text = "0000";
            this.DX_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SI_text
            // 
            this.SI_text.Location = new System.Drawing.Point(403, 50);
            this.SI_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SI_text.Name = "SI_text";
            this.SI_text.Size = new System.Drawing.Size(132, 22);
            this.SI_text.TabIndex = 15;
            this.SI_text.Text = "0000";
            this.SI_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SILabel
            // 
            this.SILabel.AutoSize = true;
            this.SILabel.Location = new System.Drawing.Point(356, 59);
            this.SILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SILabel.Name = "SILabel";
            this.SILabel.Size = new System.Drawing.Size(20, 17);
            this.SILabel.TabIndex = 17;
            this.SILabel.Text = "SI";
            // 
            // DILabel
            // 
            this.DILabel.AutoSize = true;
            this.DILabel.Location = new System.Drawing.Point(356, 86);
            this.DILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DILabel.Name = "DILabel";
            this.DILabel.Size = new System.Drawing.Size(21, 17);
            this.DILabel.TabIndex = 19;
            this.DILabel.Text = "DI";
            // 
            // DI_text
            // 
            this.DI_text.Location = new System.Drawing.Point(403, 82);
            this.DI_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DI_text.Name = "DI_text";
            this.DI_text.Size = new System.Drawing.Size(132, 22);
            this.DI_text.TabIndex = 18;
            this.DI_text.Text = "0000";
            this.DI_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BPLabel
            // 
            this.BPLabel.AutoSize = true;
            this.BPLabel.Location = new System.Drawing.Point(355, 122);
            this.BPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BPLabel.Name = "BPLabel";
            this.BPLabel.Size = new System.Drawing.Size(26, 17);
            this.BPLabel.TabIndex = 21;
            this.BPLabel.Text = "BP";
            // 
            // BP_text
            // 
            this.BP_text.Location = new System.Drawing.Point(403, 118);
            this.BP_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BP_text.Name = "BP_text";
            this.BP_text.Size = new System.Drawing.Size(132, 22);
            this.BP_text.TabIndex = 20;
            this.BP_text.Text = "0000";
            this.BP_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SPLabel
            // 
            this.SPLabel.AutoSize = true;
            this.SPLabel.Location = new System.Drawing.Point(356, 150);
            this.SPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SPLabel.Name = "SPLabel";
            this.SPLabel.Size = new System.Drawing.Size(26, 17);
            this.SPLabel.TabIndex = 23;
            this.SPLabel.Text = "SP";
            // 
            // SP_text
            // 
            this.SP_text.Location = new System.Drawing.Point(403, 146);
            this.SP_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SP_text.Name = "SP_text";
            this.SP_text.Size = new System.Drawing.Size(132, 22);
            this.SP_text.TabIndex = 22;
            this.SP_text.Text = "0000";
            this.SP_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DISPLabel
            // 
            this.DISPLabel.AutoSize = true;
            this.DISPLabel.Location = new System.Drawing.Point(356, 193);
            this.DISPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DISPLabel.Name = "DISPLabel";
            this.DISPLabel.Size = new System.Drawing.Size(39, 17);
            this.DISPLabel.TabIndex = 25;
            this.DISPLabel.Text = "DISP";
            // 
            // DISP_text
            // 
            this.DISP_text.Location = new System.Drawing.Point(403, 190);
            this.DISP_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DISP_text.Name = "DISP_text";
            this.DISP_text.Size = new System.Drawing.Size(132, 22);
            this.DISP_text.TabIndex = 24;
            this.DISP_text.Text = "0000";
            this.DISP_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Reset2
            // 
            this.Reset2.Location = new System.Drawing.Point(361, 15);
            this.Reset2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reset2.Name = "Reset2";
            this.Reset2.Size = new System.Drawing.Size(100, 28);
            this.Reset2.TabIndex = 28;
            this.Reset2.Text = "Reset";
            this.Reset2.UseVisualStyleBackColor = true;
            this.Reset2.Click += new System.EventHandler(this.Reset2_Click);
            // 
            // Mem_move
            // 
            this.Mem_move.Location = new System.Drawing.Point(335, 247);
            this.Mem_move.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mem_move.Name = "Mem_move";
            this.Mem_move.Size = new System.Drawing.Size(100, 28);
            this.Mem_move.TabIndex = 29;
            this.Mem_move.Text = "MOV";
            this.Mem_move.UseVisualStyleBackColor = true;
            this.Mem_move.Click += new System.EventHandler(this.Mem_move_Click);
            // 
            // Mem_Xchg
            // 
            this.Mem_Xchg.Location = new System.Drawing.Point(477, 247);
            this.Mem_Xchg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mem_Xchg.Name = "Mem_Xchg";
            this.Mem_Xchg.Size = new System.Drawing.Size(100, 28);
            this.Mem_Xchg.TabIndex = 38;
            this.Mem_Xchg.Text = "XCHG";
            this.Mem_Xchg.UseVisualStyleBackColor = true;
            this.Mem_Xchg.Click += new System.EventHandler(this.Mem_Xchg_Click);
            // 
            // BX_TO_AX
            // 
            this.BX_TO_AX.Location = new System.Drawing.Point(36, 193);
            this.BX_TO_AX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BX_TO_AX.Name = "BX_TO_AX";
            this.BX_TO_AX.Size = new System.Drawing.Size(113, 28);
            this.BX_TO_AX.TabIndex = 49;
            this.BX_TO_AX.Text = "MOV AX , BX";
            this.BX_TO_AX.UseVisualStyleBackColor = true;
            this.BX_TO_AX.Click += new System.EventHandler(this.BX_TO_AX_Click);
            // 
            // CX_TO_AX
            // 
            this.CX_TO_AX.Location = new System.Drawing.Point(36, 229);
            this.CX_TO_AX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CX_TO_AX.Name = "CX_TO_AX";
            this.CX_TO_AX.Size = new System.Drawing.Size(113, 28);
            this.CX_TO_AX.TabIndex = 50;
            this.CX_TO_AX.Text = "MOV AX , CX";
            this.CX_TO_AX.UseVisualStyleBackColor = true;
            this.CX_TO_AX.Click += new System.EventHandler(this.CX_TO_AX_Click);
            // 
            // DX_TO_AX
            // 
            this.DX_TO_AX.Location = new System.Drawing.Point(36, 265);
            this.DX_TO_AX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DX_TO_AX.Name = "DX_TO_AX";
            this.DX_TO_AX.Size = new System.Drawing.Size(113, 28);
            this.DX_TO_AX.TabIndex = 51;
            this.DX_TO_AX.Text = "MOV AX , DX";
            this.DX_TO_AX.UseVisualStyleBackColor = true;
            this.DX_TO_AX.Click += new System.EventHandler(this.DX_TO_AX_Click);
            // 
            // AX_TO_BX
            // 
            this.AX_TO_BX.Location = new System.Drawing.Point(36, 300);
            this.AX_TO_BX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AX_TO_BX.Name = "AX_TO_BX";
            this.AX_TO_BX.Size = new System.Drawing.Size(113, 28);
            this.AX_TO_BX.TabIndex = 52;
            this.AX_TO_BX.Text = "MOV BX , AX";
            this.AX_TO_BX.UseVisualStyleBackColor = true;
            this.AX_TO_BX.Click += new System.EventHandler(this.AX_TO_BX_Click);
            // 
            // CX_TO_BX
            // 
            this.CX_TO_BX.Location = new System.Drawing.Point(36, 336);
            this.CX_TO_BX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CX_TO_BX.Name = "CX_TO_BX";
            this.CX_TO_BX.Size = new System.Drawing.Size(113, 28);
            this.CX_TO_BX.TabIndex = 53;
            this.CX_TO_BX.Text = "MOV BX , CX";
            this.CX_TO_BX.UseVisualStyleBackColor = true;
            this.CX_TO_BX.Click += new System.EventHandler(this.CX_TO_BX_Click);
            // 
            // DX_TO_BX
            // 
            this.DX_TO_BX.Location = new System.Drawing.Point(36, 372);
            this.DX_TO_BX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DX_TO_BX.Name = "DX_TO_BX";
            this.DX_TO_BX.Size = new System.Drawing.Size(113, 28);
            this.DX_TO_BX.TabIndex = 54;
            this.DX_TO_BX.Text = "MOV BX , DX";
            this.DX_TO_BX.UseVisualStyleBackColor = true;
            this.DX_TO_BX.Click += new System.EventHandler(this.DX_TO_BX_Click);
            // 
            // AX_TO_CX
            // 
            this.AX_TO_CX.Location = new System.Drawing.Point(36, 407);
            this.AX_TO_CX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AX_TO_CX.Name = "AX_TO_CX";
            this.AX_TO_CX.Size = new System.Drawing.Size(113, 28);
            this.AX_TO_CX.TabIndex = 55;
            this.AX_TO_CX.Text = "MOV CX , AX";
            this.AX_TO_CX.UseVisualStyleBackColor = true;
            this.AX_TO_CX.Click += new System.EventHandler(this.AX_TO_CX_Click);
            // 
            // BX_TO_CX
            // 
            this.BX_TO_CX.Location = new System.Drawing.Point(36, 443);
            this.BX_TO_CX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BX_TO_CX.Name = "BX_TO_CX";
            this.BX_TO_CX.Size = new System.Drawing.Size(113, 28);
            this.BX_TO_CX.TabIndex = 56;
            this.BX_TO_CX.Text = "MOV CX , BX";
            this.BX_TO_CX.UseVisualStyleBackColor = true;
            this.BX_TO_CX.Click += new System.EventHandler(this.BX_TO_CX_Click);
            // 
            // DX_TO_CX
            // 
            this.DX_TO_CX.Location = new System.Drawing.Point(36, 479);
            this.DX_TO_CX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DX_TO_CX.Name = "DX_TO_CX";
            this.DX_TO_CX.Size = new System.Drawing.Size(113, 28);
            this.DX_TO_CX.TabIndex = 57;
            this.DX_TO_CX.Text = "MOV CX , DX";
            this.DX_TO_CX.UseVisualStyleBackColor = true;
            this.DX_TO_CX.Click += new System.EventHandler(this.DX_TO_CX_Click);
            // 
            // AX_TO_DX
            // 
            this.AX_TO_DX.Location = new System.Drawing.Point(36, 514);
            this.AX_TO_DX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AX_TO_DX.Name = "AX_TO_DX";
            this.AX_TO_DX.Size = new System.Drawing.Size(113, 28);
            this.AX_TO_DX.TabIndex = 58;
            this.AX_TO_DX.Text = "MOV DX , AX";
            this.AX_TO_DX.UseVisualStyleBackColor = true;
            this.AX_TO_DX.Click += new System.EventHandler(this.AX_TO_DX_Click);
            // 
            // BX_TO_DX
            // 
            this.BX_TO_DX.Location = new System.Drawing.Point(36, 550);
            this.BX_TO_DX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BX_TO_DX.Name = "BX_TO_DX";
            this.BX_TO_DX.Size = new System.Drawing.Size(113, 28);
            this.BX_TO_DX.TabIndex = 59;
            this.BX_TO_DX.Text = "MOV DX , BX";
            this.BX_TO_DX.UseVisualStyleBackColor = true;
            this.BX_TO_DX.Click += new System.EventHandler(this.BX_TO_DX_Click);
            // 
            // CX_TO_DX
            // 
            this.CX_TO_DX.Location = new System.Drawing.Point(36, 586);
            this.CX_TO_DX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CX_TO_DX.Name = "CX_TO_DX";
            this.CX_TO_DX.Size = new System.Drawing.Size(113, 28);
            this.CX_TO_DX.TabIndex = 60;
            this.CX_TO_DX.Text = "MOV DX , CX";
            this.CX_TO_DX.UseVisualStyleBackColor = true;
            this.CX_TO_DX.Click += new System.EventHandler(this.CX_TO_DX_Click);
            // 
            // XCHG_DX_CX
            // 
            this.XCHG_DX_CX.Location = new System.Drawing.Point(197, 586);
            this.XCHG_DX_CX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_DX_CX.Name = "XCHG_DX_CX";
            this.XCHG_DX_CX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_DX_CX.TabIndex = 73;
            this.XCHG_DX_CX.Text = "XCHG DX , CX";
            this.XCHG_DX_CX.UseVisualStyleBackColor = true;
            this.XCHG_DX_CX.Click += new System.EventHandler(this.XCHG_DX_CX_Click);
            // 
            // XCHG_DX_BX
            // 
            this.XCHG_DX_BX.Location = new System.Drawing.Point(197, 550);
            this.XCHG_DX_BX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_DX_BX.Name = "XCHG_DX_BX";
            this.XCHG_DX_BX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_DX_BX.TabIndex = 72;
            this.XCHG_DX_BX.Text = "XCHG DX , BX";
            this.XCHG_DX_BX.UseVisualStyleBackColor = true;
            this.XCHG_DX_BX.Click += new System.EventHandler(this.XCHG_DX_BX_Click);
            // 
            // XCHG_DX_AX
            // 
            this.XCHG_DX_AX.Location = new System.Drawing.Point(197, 514);
            this.XCHG_DX_AX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_DX_AX.Name = "XCHG_DX_AX";
            this.XCHG_DX_AX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_DX_AX.TabIndex = 71;
            this.XCHG_DX_AX.Text = "XCHG DX , AX";
            this.XCHG_DX_AX.UseVisualStyleBackColor = true;
            this.XCHG_DX_AX.Click += new System.EventHandler(this.XCHG_DX_AX_Click);
            // 
            // XCHG_CX_DX
            // 
            this.XCHG_CX_DX.Location = new System.Drawing.Point(197, 479);
            this.XCHG_CX_DX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_CX_DX.Name = "XCHG_CX_DX";
            this.XCHG_CX_DX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_CX_DX.TabIndex = 70;
            this.XCHG_CX_DX.Text = "XCHG CX , DX";
            this.XCHG_CX_DX.UseVisualStyleBackColor = true;
            this.XCHG_CX_DX.Click += new System.EventHandler(this.XCHG_CX_DX_Click);
            // 
            // XCHG_CX_BX
            // 
            this.XCHG_CX_BX.Location = new System.Drawing.Point(197, 443);
            this.XCHG_CX_BX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_CX_BX.Name = "XCHG_CX_BX";
            this.XCHG_CX_BX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_CX_BX.TabIndex = 69;
            this.XCHG_CX_BX.Text = "XCHG CX , BX";
            this.XCHG_CX_BX.UseVisualStyleBackColor = true;
            this.XCHG_CX_BX.Click += new System.EventHandler(this.XCHG_CX_BX_Click);
            // 
            // XCHG_CX_AX
            // 
            this.XCHG_CX_AX.Location = new System.Drawing.Point(197, 407);
            this.XCHG_CX_AX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_CX_AX.Name = "XCHG_CX_AX";
            this.XCHG_CX_AX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_CX_AX.TabIndex = 68;
            this.XCHG_CX_AX.Text = "XCHG CX , AX";
            this.XCHG_CX_AX.UseVisualStyleBackColor = true;
            this.XCHG_CX_AX.Click += new System.EventHandler(this.XCHG_CX_AX_Click);
            // 
            // XCHG_BX_DX
            // 
            this.XCHG_BX_DX.Location = new System.Drawing.Point(197, 372);
            this.XCHG_BX_DX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_BX_DX.Name = "XCHG_BX_DX";
            this.XCHG_BX_DX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_BX_DX.TabIndex = 67;
            this.XCHG_BX_DX.Text = "XCHG BX , DX";
            this.XCHG_BX_DX.UseVisualStyleBackColor = true;
            this.XCHG_BX_DX.Click += new System.EventHandler(this.XCHG_BX_DX_Click);
            // 
            // XCHG_BX_CX
            // 
            this.XCHG_BX_CX.Location = new System.Drawing.Point(197, 336);
            this.XCHG_BX_CX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_BX_CX.Name = "XCHG_BX_CX";
            this.XCHG_BX_CX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_BX_CX.TabIndex = 66;
            this.XCHG_BX_CX.Text = "XCHG BX , CX";
            this.XCHG_BX_CX.UseVisualStyleBackColor = true;
            this.XCHG_BX_CX.Click += new System.EventHandler(this.XCHG_BX_CX_Click);
            // 
            // XCHG_BX_AX
            // 
            this.XCHG_BX_AX.Location = new System.Drawing.Point(197, 300);
            this.XCHG_BX_AX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_BX_AX.Name = "XCHG_BX_AX";
            this.XCHG_BX_AX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_BX_AX.TabIndex = 65;
            this.XCHG_BX_AX.Text = "XCHG BX , AX";
            this.XCHG_BX_AX.UseVisualStyleBackColor = true;
            this.XCHG_BX_AX.Click += new System.EventHandler(this.XCHG_BX_AX_Click);
            // 
            // XCHG_AX_DX
            // 
            this.XCHG_AX_DX.Location = new System.Drawing.Point(197, 265);
            this.XCHG_AX_DX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_AX_DX.Name = "XCHG_AX_DX";
            this.XCHG_AX_DX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_AX_DX.TabIndex = 64;
            this.XCHG_AX_DX.Text = "XCHG AX , DX";
            this.XCHG_AX_DX.UseVisualStyleBackColor = true;
            this.XCHG_AX_DX.Click += new System.EventHandler(this.XCHG_AX_DX_Click);
            // 
            // XCHG_AX_CX
            // 
            this.XCHG_AX_CX.Location = new System.Drawing.Point(197, 229);
            this.XCHG_AX_CX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_AX_CX.Name = "XCHG_AX_CX";
            this.XCHG_AX_CX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_AX_CX.TabIndex = 63;
            this.XCHG_AX_CX.Text = "XCHG AX , CX";
            this.XCHG_AX_CX.UseVisualStyleBackColor = true;
            this.XCHG_AX_CX.Click += new System.EventHandler(this.XCHG_AX_CX_Click);
            // 
            // XCHG_AX_BX
            // 
            this.XCHG_AX_BX.Location = new System.Drawing.Point(197, 193);
            this.XCHG_AX_BX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XCHG_AX_BX.Name = "XCHG_AX_BX";
            this.XCHG_AX_BX.Size = new System.Drawing.Size(115, 28);
            this.XCHG_AX_BX.TabIndex = 62;
            this.XCHG_AX_BX.Text = "XCHG AX , BX";
            this.XCHG_AX_BX.UseVisualStyleBackColor = true;
            this.XCHG_AX_BX.Click += new System.EventHandler(this.XCHG_AX_BX_Click);
            // 
            // Push_AX
            // 
            this.Push_AX.Location = new System.Drawing.Point(332, 321);
            this.Push_AX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Push_AX.Name = "Push_AX";
            this.Push_AX.Size = new System.Drawing.Size(100, 28);
            this.Push_AX.TabIndex = 75;
            this.Push_AX.Text = "PUSH AX";
            this.Push_AX.UseVisualStyleBackColor = true;
            this.Push_AX.Click += new System.EventHandler(this.Push_AX_Click);
            // 
            // Push_BX
            // 
            this.Push_BX.Location = new System.Drawing.Point(332, 357);
            this.Push_BX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Push_BX.Name = "Push_BX";
            this.Push_BX.Size = new System.Drawing.Size(100, 28);
            this.Push_BX.TabIndex = 76;
            this.Push_BX.Text = "PUSH BX";
            this.Push_BX.UseVisualStyleBackColor = true;
            this.Push_BX.Click += new System.EventHandler(this.Push_BX_Click);
            // 
            // Push_CX
            // 
            this.Push_CX.Location = new System.Drawing.Point(332, 393);
            this.Push_CX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Push_CX.Name = "Push_CX";
            this.Push_CX.Size = new System.Drawing.Size(100, 28);
            this.Push_CX.TabIndex = 77;
            this.Push_CX.Text = "PUSH CX";
            this.Push_CX.UseVisualStyleBackColor = true;
            this.Push_CX.Click += new System.EventHandler(this.Push_CX_Click);
            // 
            // Push_DX
            // 
            this.Push_DX.Location = new System.Drawing.Point(332, 428);
            this.Push_DX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Push_DX.Name = "Push_DX";
            this.Push_DX.Size = new System.Drawing.Size(100, 28);
            this.Push_DX.TabIndex = 78;
            this.Push_DX.Text = "PUSH DX";
            this.Push_DX.UseVisualStyleBackColor = true;
            this.Push_DX.Click += new System.EventHandler(this.Push_DX_Click);
            // 
            // Pop_AX
            // 
            this.Pop_AX.Location = new System.Drawing.Point(489, 321);
            this.Pop_AX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pop_AX.Name = "Pop_AX";
            this.Pop_AX.Size = new System.Drawing.Size(100, 28);
            this.Pop_AX.TabIndex = 79;
            this.Pop_AX.Text = "POP AX";
            this.Pop_AX.UseVisualStyleBackColor = true;
            this.Pop_AX.Click += new System.EventHandler(this.Pop_AX_Click);
            // 
            // Pop_BX
            // 
            this.Pop_BX.Location = new System.Drawing.Point(489, 357);
            this.Pop_BX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pop_BX.Name = "Pop_BX";
            this.Pop_BX.Size = new System.Drawing.Size(100, 28);
            this.Pop_BX.TabIndex = 80;
            this.Pop_BX.Text = "POP BX";
            this.Pop_BX.UseVisualStyleBackColor = true;
            this.Pop_BX.Click += new System.EventHandler(this.Pop_BX_Click);
            // 
            // Pop_CX
            // 
            this.Pop_CX.Location = new System.Drawing.Point(489, 393);
            this.Pop_CX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pop_CX.Name = "Pop_CX";
            this.Pop_CX.Size = new System.Drawing.Size(100, 28);
            this.Pop_CX.TabIndex = 81;
            this.Pop_CX.Text = "POP CX";
            this.Pop_CX.UseVisualStyleBackColor = true;
            this.Pop_CX.Click += new System.EventHandler(this.Pop_CX_Click);
            // 
            // Pop_DX
            // 
            this.Pop_DX.Location = new System.Drawing.Point(489, 428);
            this.Pop_DX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pop_DX.Name = "Pop_DX";
            this.Pop_DX.Size = new System.Drawing.Size(100, 28);
            this.Pop_DX.TabIndex = 82;
            this.Pop_DX.Text = "POP DX";
            this.Pop_DX.UseVisualStyleBackColor = true;
            this.Pop_DX.Click += new System.EventHandler(this.Pop_DX_Click);
            // 
            // Random2
            // 
            this.Random2.Location = new System.Drawing.Point(469, 15);
            this.Random2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Random2.Name = "Random2";
            this.Random2.Size = new System.Drawing.Size(100, 28);
            this.Random2.TabIndex = 83;
            this.Random2.Text = "Random";
            this.Random2.UseVisualStyleBackColor = true;
            this.Random2.Click += new System.EventHandler(this.Random2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mem_To_Reg);
            this.groupBox1.Controls.Add(this.Reg_To_Mem);
            this.groupBox1.Location = new System.Drawing.Point(676, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(215, 86);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // Mem_To_Reg
            // 
            this.Mem_To_Reg.AutoSize = true;
            this.Mem_To_Reg.Location = new System.Drawing.Point(8, 52);
            this.Mem_To_Reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mem_To_Reg.Name = "Mem_To_Reg";
            this.Mem_To_Reg.Size = new System.Drawing.Size(162, 21);
            this.Mem_To_Reg.TabIndex = 13;
            this.Mem_To_Reg.TabStop = true;
            this.Mem_To_Reg.Text = "Z pamięci do rejestru";
            this.Mem_To_Reg.UseVisualStyleBackColor = true;
            // 
            // Reg_To_Mem
            // 
            this.Reg_To_Mem.AutoSize = true;
            this.Reg_To_Mem.Location = new System.Drawing.Point(8, 23);
            this.Reg_To_Mem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reg_To_Mem.Name = "Reg_To_Mem";
            this.Reg_To_Mem.Size = new System.Drawing.Size(162, 21);
            this.Reg_To_Mem.TabIndex = 12;
            this.Reg_To_Mem.TabStop = true;
            this.Reg_To_Mem.Text = "Z rejestru do pamięci";
            this.Reg_To_Mem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Index_base_check);
            this.groupBox2.Controls.Add(this.Base_check);
            this.groupBox2.Controls.Add(this.Index_check);
            this.groupBox2.Location = new System.Drawing.Point(676, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(215, 122);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // Index_base_check
            // 
            this.Index_base_check.AutoSize = true;
            this.Index_base_check.Location = new System.Drawing.Point(9, 80);
            this.Index_base_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Index_base_check.Name = "Index_base_check";
            this.Index_base_check.Size = new System.Drawing.Size(147, 21);
            this.Index_base_check.TabIndex = 17;
            this.Index_base_check.TabStop = true;
            this.Index_base_check.Text = "indeksowo-bazowy";
            this.Index_base_check.UseVisualStyleBackColor = true;
            // 
            // Base_check
            // 
            this.Base_check.AutoSize = true;
            this.Base_check.Location = new System.Drawing.Point(8, 52);
            this.Base_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Base_check.Name = "Base_check";
            this.Base_check.Size = new System.Drawing.Size(76, 21);
            this.Base_check.TabIndex = 16;
            this.Base_check.TabStop = true;
            this.Base_check.Text = "bazowy";
            this.Base_check.UseVisualStyleBackColor = true;
            // 
            // Index_check
            // 
            this.Index_check.AutoSize = true;
            this.Index_check.Location = new System.Drawing.Point(8, 23);
            this.Index_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Index_check.Name = "Index_check";
            this.Index_check.Size = new System.Drawing.Size(94, 21);
            this.Index_check.TabIndex = 15;
            this.Index_check.TabStop = true;
            this.Index_check.Text = "indeksowy";
            this.Index_check.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DI_check);
            this.groupBox3.Controls.Add(this.SI_check);
            this.groupBox3.Location = new System.Drawing.Point(676, 238);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(108, 108);
            this.groupBox3.TabIndex = 86;
            this.groupBox3.TabStop = false;
            // 
            // DI_check
            // 
            this.DI_check.AutoSize = true;
            this.DI_check.Location = new System.Drawing.Point(8, 52);
            this.DI_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DI_check.Name = "DI_check";
            this.DI_check.Size = new System.Drawing.Size(42, 21);
            this.DI_check.TabIndex = 44;
            this.DI_check.TabStop = true;
            this.DI_check.Text = "DI";
            this.DI_check.UseVisualStyleBackColor = true;
            // 
            // SI_check
            // 
            this.SI_check.AutoSize = true;
            this.SI_check.Location = new System.Drawing.Point(8, 23);
            this.SI_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SI_check.Name = "SI_check";
            this.SI_check.Size = new System.Drawing.Size(41, 21);
            this.SI_check.TabIndex = 43;
            this.SI_check.TabStop = true;
            this.SI_check.Text = "SI";
            this.SI_check.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AX_check);
            this.groupBox4.Controls.Add(this.DX_check);
            this.groupBox4.Controls.Add(this.CX_check);
            this.groupBox4.Controls.Add(this.BX_check);
            this.groupBox4.Location = new System.Drawing.Point(792, 238);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(99, 135);
            this.groupBox4.TabIndex = 87;
            this.groupBox4.TabStop = false;
            // 
            // AX_check
            // 
            this.AX_check.AutoSize = true;
            this.AX_check.Location = new System.Drawing.Point(8, 23);
            this.AX_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AX_check.Name = "AX_check";
            this.AX_check.Size = new System.Drawing.Size(47, 21);
            this.AX_check.TabIndex = 46;
            this.AX_check.TabStop = true;
            this.AX_check.Text = "AX";
            this.AX_check.UseVisualStyleBackColor = true;
            // 
            // DX_check
            // 
            this.DX_check.AutoSize = true;
            this.DX_check.Location = new System.Drawing.Point(8, 108);
            this.DX_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DX_check.Name = "DX_check";
            this.DX_check.Size = new System.Drawing.Size(48, 21);
            this.DX_check.TabIndex = 45;
            this.DX_check.TabStop = true;
            this.DX_check.Text = "DX";
            this.DX_check.UseVisualStyleBackColor = true;
            // 
            // CX_check
            // 
            this.CX_check.AutoSize = true;
            this.CX_check.Location = new System.Drawing.Point(8, 80);
            this.CX_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CX_check.Name = "CX_check";
            this.CX_check.Size = new System.Drawing.Size(47, 21);
            this.CX_check.TabIndex = 44;
            this.CX_check.TabStop = true;
            this.CX_check.Text = "CX";
            this.CX_check.UseVisualStyleBackColor = true;
            // 
            // BX_check
            // 
            this.BX_check.AutoSize = true;
            this.BX_check.Location = new System.Drawing.Point(8, 52);
            this.BX_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BX_check.Name = "BX_check";
            this.BX_check.Size = new System.Drawing.Size(47, 21);
            this.BX_check.TabIndex = 43;
            this.BX_check.TabStop = true;
            this.BX_check.Text = "BX";
            this.BX_check.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BP_check);
            this.groupBox5.Controls.Add(this.BX2_check);
            this.groupBox5.Location = new System.Drawing.Point(676, 353);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(108, 78);
            this.groupBox5.TabIndex = 88;
            this.groupBox5.TabStop = false;
            // 
            // BP_check
            // 
            this.BP_check.AutoSize = true;
            this.BP_check.Location = new System.Drawing.Point(9, 52);
            this.BP_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BP_check.Name = "BP_check";
            this.BP_check.Size = new System.Drawing.Size(47, 21);
            this.BP_check.TabIndex = 46;
            this.BP_check.TabStop = true;
            this.BP_check.Text = "BP";
            this.BP_check.UseVisualStyleBackColor = true;
            // 
            // BX2_check
            // 
            this.BX2_check.AutoSize = true;
            this.BX2_check.Location = new System.Drawing.Point(8, 23);
            this.BX2_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BX2_check.Name = "BX2_check";
            this.BX2_check.Size = new System.Drawing.Size(47, 21);
            this.BX2_check.TabIndex = 45;
            this.BX2_check.TabStop = true;
            this.BX2_check.Text = "BX";
            this.BX2_check.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DI_BP_check);
            this.groupBox6.Controls.Add(this.SI_BP_check);
            this.groupBox6.Controls.Add(this.DI_BX_check);
            this.groupBox6.Controls.Add(this.SI_BX_check);
            this.groupBox6.Location = new System.Drawing.Point(792, 380);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(108, 140);
            this.groupBox6.TabIndex = 89;
            this.groupBox6.TabStop = false;
            // 
            // DI_BP_check
            // 
            this.DI_BP_check.AutoSize = true;
            this.DI_BP_check.Location = new System.Drawing.Point(8, 108);
            this.DI_BP_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DI_BP_check.Name = "DI_BP_check";
            this.DI_BP_check.Size = new System.Drawing.Size(71, 21);
            this.DI_BP_check.TabIndex = 52;
            this.DI_BP_check.TabStop = true;
            this.DI_BP_check.Text = "DI i BP";
            this.DI_BP_check.UseVisualStyleBackColor = true;
            // 
            // SI_BP_check
            // 
            this.SI_BP_check.AutoSize = true;
            this.SI_BP_check.Location = new System.Drawing.Point(8, 80);
            this.SI_BP_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SI_BP_check.Name = "SI_BP_check";
            this.SI_BP_check.Size = new System.Drawing.Size(70, 21);
            this.SI_BP_check.TabIndex = 51;
            this.SI_BP_check.TabStop = true;
            this.SI_BP_check.Text = "SI i BP";
            this.SI_BP_check.UseVisualStyleBackColor = true;
            // 
            // DI_BX_check
            // 
            this.DI_BX_check.AutoSize = true;
            this.DI_BX_check.Location = new System.Drawing.Point(8, 52);
            this.DI_BX_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DI_BX_check.Name = "DI_BX_check";
            this.DI_BX_check.Size = new System.Drawing.Size(71, 21);
            this.DI_BX_check.TabIndex = 50;
            this.DI_BX_check.TabStop = true;
            this.DI_BX_check.Text = "DI i BX";
            this.DI_BX_check.UseVisualStyleBackColor = true;
            // 
            // SI_BX_check
            // 
            this.SI_BX_check.AutoSize = true;
            this.SI_BX_check.Location = new System.Drawing.Point(8, 23);
            this.SI_BX_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SI_BX_check.Name = "SI_BX_check";
            this.SI_BX_check.Size = new System.Drawing.Size(70, 21);
            this.SI_BX_check.TabIndex = 49;
            this.SI_BX_check.TabStop = true;
            this.SI_BX_check.Text = "SI i BX";
            this.SI_BX_check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(944, 636);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Random2);
            this.Controls.Add(this.Pop_DX);
            this.Controls.Add(this.Pop_CX);
            this.Controls.Add(this.Pop_BX);
            this.Controls.Add(this.Pop_AX);
            this.Controls.Add(this.Push_DX);
            this.Controls.Add(this.Push_CX);
            this.Controls.Add(this.Push_BX);
            this.Controls.Add(this.Push_AX);
            this.Controls.Add(this.XCHG_DX_CX);
            this.Controls.Add(this.XCHG_DX_BX);
            this.Controls.Add(this.XCHG_DX_AX);
            this.Controls.Add(this.XCHG_CX_DX);
            this.Controls.Add(this.XCHG_CX_BX);
            this.Controls.Add(this.XCHG_CX_AX);
            this.Controls.Add(this.XCHG_BX_DX);
            this.Controls.Add(this.XCHG_BX_CX);
            this.Controls.Add(this.XCHG_BX_AX);
            this.Controls.Add(this.XCHG_AX_DX);
            this.Controls.Add(this.XCHG_AX_CX);
            this.Controls.Add(this.XCHG_AX_BX);
            this.Controls.Add(this.CX_TO_DX);
            this.Controls.Add(this.BX_TO_DX);
            this.Controls.Add(this.AX_TO_DX);
            this.Controls.Add(this.DX_TO_CX);
            this.Controls.Add(this.BX_TO_CX);
            this.Controls.Add(this.AX_TO_CX);
            this.Controls.Add(this.DX_TO_BX);
            this.Controls.Add(this.CX_TO_BX);
            this.Controls.Add(this.AX_TO_BX);
            this.Controls.Add(this.DX_TO_AX);
            this.Controls.Add(this.CX_TO_AX);
            this.Controls.Add(this.BX_TO_AX);
            this.Controls.Add(this.Mem_Xchg);
            this.Controls.Add(this.Mem_move);
            this.Controls.Add(this.Reset2);
            this.Controls.Add(this.DISPLabel);
            this.Controls.Add(this.DISP_text);
            this.Controls.Add(this.SPLabel);
            this.Controls.Add(this.SP_text);
            this.Controls.Add(this.BPLabel);
            this.Controls.Add(this.BP_text);
            this.Controls.Add(this.DILabel);
            this.Controls.Add(this.DI_text);
            this.Controls.Add(this.SILabel);
            this.Controls.Add(this.SI_text);
            this.Controls.Add(this.DX_text);
            this.Controls.Add(this.CX_text);
            this.Controls.Add(this.DXLabel);
            this.Controls.Add(this.CXLabel);
            this.Controls.Add(this.BXLabel);
            this.Controls.Add(this.BX_text);
            this.Controls.Add(this.AX_text);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.AXLabel);
            this.Controls.Add(this.Reset1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "INTEL 8086 - Anna Trojanowska ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset1;
        private System.Windows.Forms.Label AXLabel;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.TextBox AX_text;
        private System.Windows.Forms.TextBox BX_text;
        private System.Windows.Forms.Label BXLabel;
        private System.Windows.Forms.Label CXLabel;
        private System.Windows.Forms.Label DXLabel;
        private System.Windows.Forms.TextBox CX_text;
        private System.Windows.Forms.TextBox DX_text;
        private System.Windows.Forms.TextBox SI_text;
        private System.Windows.Forms.Label SILabel;
        private System.Windows.Forms.Label DILabel;
        private System.Windows.Forms.TextBox DI_text;
        private System.Windows.Forms.Label BPLabel;
        private System.Windows.Forms.TextBox BP_text;
        private System.Windows.Forms.Label SPLabel;
        private System.Windows.Forms.TextBox SP_text;
        private System.Windows.Forms.Label DISPLabel;
        private System.Windows.Forms.TextBox DISP_text;
        private System.Windows.Forms.Button Reset2;
        private System.Windows.Forms.Button Mem_move;
        private System.Windows.Forms.Button Mem_Xchg;
        private System.Windows.Forms.Button BX_TO_AX;
        private System.Windows.Forms.Button CX_TO_AX;
        private System.Windows.Forms.Button DX_TO_AX;
        private System.Windows.Forms.Button AX_TO_BX;
        private System.Windows.Forms.Button CX_TO_BX;
        private System.Windows.Forms.Button DX_TO_BX;
        private System.Windows.Forms.Button AX_TO_CX;
        private System.Windows.Forms.Button BX_TO_CX;
        private System.Windows.Forms.Button DX_TO_CX;
        private System.Windows.Forms.Button AX_TO_DX;
        private System.Windows.Forms.Button BX_TO_DX;
        private System.Windows.Forms.Button CX_TO_DX;
        private System.Windows.Forms.Button XCHG_DX_CX;
        private System.Windows.Forms.Button XCHG_DX_BX;
        private System.Windows.Forms.Button XCHG_DX_AX;
        private System.Windows.Forms.Button XCHG_CX_DX;
        private System.Windows.Forms.Button XCHG_CX_BX;
        private System.Windows.Forms.Button XCHG_CX_AX;
        private System.Windows.Forms.Button XCHG_BX_DX;
        private System.Windows.Forms.Button XCHG_BX_CX;
        private System.Windows.Forms.Button XCHG_BX_AX;
        private System.Windows.Forms.Button XCHG_AX_DX;
        private System.Windows.Forms.Button XCHG_AX_CX;
        private System.Windows.Forms.Button XCHG_AX_BX;
        private System.Windows.Forms.Button Push_AX;
        private System.Windows.Forms.Button Push_BX;
        private System.Windows.Forms.Button Push_CX;
        private System.Windows.Forms.Button Push_DX;
        private System.Windows.Forms.Button Pop_AX;
        private System.Windows.Forms.Button Pop_BX;
        private System.Windows.Forms.Button Pop_CX;
        private System.Windows.Forms.Button Pop_DX;
        private System.Windows.Forms.Button Random2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Mem_To_Reg;
        private System.Windows.Forms.RadioButton Reg_To_Mem;
        private System.Windows.Forms.RadioButton Index_base_check;
        private System.Windows.Forms.RadioButton Base_check;
        private System.Windows.Forms.RadioButton Index_check;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton DI_check;
        private System.Windows.Forms.RadioButton SI_check;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton DX_check;
        private System.Windows.Forms.RadioButton CX_check;
        private System.Windows.Forms.RadioButton BX_check;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton BP_check;
        private System.Windows.Forms.RadioButton BX2_check;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton DI_BP_check;
        private System.Windows.Forms.RadioButton SI_BP_check;
        private System.Windows.Forms.RadioButton DI_BX_check;
        private System.Windows.Forms.RadioButton SI_BX_check;
        private System.Windows.Forms.RadioButton AX_check;
    }
}

