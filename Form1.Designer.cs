namespace VR_GUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_SOS = new System.Windows.Forms.GroupBox();
            this.textBox_nFreq = new System.Windows.Forms.TextBox();
            this.textBox_maxFreq = new System.Windows.Forms.TextBox();
            this.textBox_minFreq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_GenParams = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_Tend = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Tstart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_nPulses = new System.Windows.Forms.TextBox();
            this.textBox_Vel = new System.Windows.Forms.TextBox();
            this.textBox_Amp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Exp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_PRTS = new System.Windows.Forms.GroupBox();
            this.textBox_PRTSdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_PRBS = new System.Windows.Forms.GroupBox();
            this.textBox_PRBS_SR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_TrapZ = new System.Windows.Forms.GroupBox();
            this.textBox_TrapZ_minD = new System.Windows.Forms.TextBox();
            this.textBox_TrapZ_minW = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox_TrapV = new System.Windows.Forms.GroupBox();
            this.textBox_txAuto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_TrapV = new System.Windows.Forms.ComboBox();
            this.radioB_AutoTrapV = new System.Windows.Forms.RadioButton();
            this.radioB_ManualTrapV = new System.Windows.Forms.RadioButton();
            this.textBox_tx = new System.Windows.Forms.TextBox();
            this.textBox_tv = new System.Windows.Forms.TextBox();
            this.textBox_ta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_TrapV_minD = new System.Windows.Forms.TextBox();
            this.textBox_TrapV_minW = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_HSin = new System.Windows.Forms.GroupBox();
            this.textBox_HSIN_minD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelPbar = new System.Windows.Forms.Label();
            this.groupBox_SOS.SuspendLayout();
            this.groupBox_GenParams.SuspendLayout();
            this.groupBox_PRTS.SuspendLayout();
            this.groupBox_PRBS.SuspendLayout();
            this.groupBox_TrapZ.SuspendLayout();
            this.groupBox_TrapV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_HSin.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox_SOS
            // 
            this.groupBox_SOS.Controls.Add(this.textBox_nFreq);
            this.groupBox_SOS.Controls.Add(this.textBox_maxFreq);
            this.groupBox_SOS.Controls.Add(this.textBox_minFreq);
            this.groupBox_SOS.Controls.Add(this.label6);
            this.groupBox_SOS.Controls.Add(this.label7);
            this.groupBox_SOS.Controls.Add(this.label8);
            this.groupBox_SOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SOS.Location = new System.Drawing.Point(431, 19);
            this.groupBox_SOS.Name = "groupBox_SOS";
            this.groupBox_SOS.Size = new System.Drawing.Size(398, 147);
            this.groupBox_SOS.TabIndex = 2;
            this.groupBox_SOS.TabStop = false;
            this.groupBox_SOS.Text = "Sum of Sin Parameters";
            // 
            // textBox_nFreq
            // 
            this.textBox_nFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nFreq.Location = new System.Drawing.Point(240, 108);
            this.textBox_nFreq.Name = "textBox_nFreq";
            this.textBox_nFreq.Size = new System.Drawing.Size(100, 23);
            this.textBox_nFreq.TabIndex = 14;
            // 
            // textBox_maxFreq
            // 
            this.textBox_maxFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maxFreq.Location = new System.Drawing.Point(240, 71);
            this.textBox_maxFreq.Name = "textBox_maxFreq";
            this.textBox_maxFreq.Size = new System.Drawing.Size(100, 23);
            this.textBox_maxFreq.TabIndex = 13;
            // 
            // textBox_minFreq
            // 
            this.textBox_minFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_minFreq.Location = new System.Drawing.Point(240, 33);
            this.textBox_minFreq.Name = "textBox_minFreq";
            this.textBox_minFreq.Size = new System.Drawing.Size(100, 23);
            this.textBox_minFreq.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Frequency Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Min Frequency (Hz):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Max Frequency (Hz):";
            // 
            // groupBox_GenParams
            // 
            this.groupBox_GenParams.Controls.Add(this.checkBox1);
            this.groupBox_GenParams.Controls.Add(this.textBox_Tend);
            this.groupBox_GenParams.Controls.Add(this.label11);
            this.groupBox_GenParams.Controls.Add(this.textBox_Tstart);
            this.groupBox_GenParams.Controls.Add(this.label9);
            this.groupBox_GenParams.Controls.Add(this.textBox_nPulses);
            this.groupBox_GenParams.Controls.Add(this.textBox_Vel);
            this.groupBox_GenParams.Controls.Add(this.textBox_Amp);
            this.groupBox_GenParams.Controls.Add(this.label5);
            this.groupBox_GenParams.Controls.Add(this.comboBox_Exp);
            this.groupBox_GenParams.Controls.Add(this.label4);
            this.groupBox_GenParams.Controls.Add(this.label3);
            this.groupBox_GenParams.Controls.Add(this.label2);
            this.groupBox_GenParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_GenParams.Location = new System.Drawing.Point(22, 19);
            this.groupBox_GenParams.Name = "groupBox_GenParams";
            this.groupBox_GenParams.Size = new System.Drawing.Size(398, 343);
            this.groupBox_GenParams.TabIndex = 3;
            this.groupBox_GenParams.TabStop = false;
            this.groupBox_GenParams.Text = "General Experiments Parameters";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(55, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Random Directions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_Tend
            // 
            this.textBox_Tend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tend.Location = new System.Drawing.Point(205, 254);
            this.textBox_Tend.Name = "textBox_Tend";
            this.textBox_Tend.Size = new System.Drawing.Size(100, 23);
            this.textBox_Tend.TabIndex = 12;
            this.textBox_Tend.Text = "200";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "End Time (Sec):";
            // 
            // textBox_Tstart
            // 
            this.textBox_Tstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tstart.Location = new System.Drawing.Point(205, 215);
            this.textBox_Tstart.Name = "textBox_Tstart";
            this.textBox_Tstart.Size = new System.Drawing.Size(100, 23);
            this.textBox_Tstart.TabIndex = 10;
            this.textBox_Tstart.Text = "4.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Start Time (Sec):";
            // 
            // textBox_nPulses
            // 
            this.textBox_nPulses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nPulses.Location = new System.Drawing.Point(205, 176);
            this.textBox_nPulses.Name = "textBox_nPulses";
            this.textBox_nPulses.Size = new System.Drawing.Size(100, 23);
            this.textBox_nPulses.TabIndex = 8;
            this.textBox_nPulses.Text = "10";
            // 
            // textBox_Vel
            // 
            this.textBox_Vel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Vel.Location = new System.Drawing.Point(205, 138);
            this.textBox_Vel.Name = "textBox_Vel";
            this.textBox_Vel.Size = new System.Drawing.Size(100, 23);
            this.textBox_Vel.TabIndex = 7;
            this.textBox_Vel.Text = "2";
            // 
            // textBox_Amp
            // 
            this.textBox_Amp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Amp.Location = new System.Drawing.Point(205, 100);
            this.textBox_Amp.Name = "textBox_Amp";
            this.textBox_Amp.Size = new System.Drawing.Size(100, 23);
            this.textBox_Amp.TabIndex = 6;
            this.textBox_Amp.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of Pulses:";
            // 
            // comboBox_Exp
            // 
            this.comboBox_Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Exp.FormattingEnabled = true;
            this.comboBox_Exp.Location = new System.Drawing.Point(100, 43);
            this.comboBox_Exp.Name = "comboBox_Exp";
            this.comboBox_Exp.Size = new System.Drawing.Size(276, 23);
            this.comboBox_Exp.TabIndex = 4;
            this.comboBox_Exp.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "VR Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "P2P Amplitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max Velocity:";
            // 
            // groupBox_PRTS
            // 
            this.groupBox_PRTS.Controls.Add(this.textBox_PRTSdt);
            this.groupBox_PRTS.Controls.Add(this.label10);
            this.groupBox_PRTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PRTS.Location = new System.Drawing.Point(22, 454);
            this.groupBox_PRTS.Name = "groupBox_PRTS";
            this.groupBox_PRTS.Size = new System.Drawing.Size(398, 71);
            this.groupBox_PRTS.TabIndex = 3;
            this.groupBox_PRTS.TabStop = false;
            this.groupBox_PRTS.Text = "PRTS Parameters";
            // 
            // textBox_PRTSdt
            // 
            this.textBox_PRTSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PRTSdt.Location = new System.Drawing.Point(205, 31);
            this.textBox_PRTSdt.Name = "textBox_PRTSdt";
            this.textBox_PRTSdt.Size = new System.Drawing.Size(100, 23);
            this.textBox_PRTSdt.TabIndex = 18;
            this.textBox_PRTSdt.Text = "0.2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "PRTS SR (dt): ";
            // 
            // groupBox_PRBS
            // 
            this.groupBox_PRBS.Controls.Add(this.textBox_PRBS_SR);
            this.groupBox_PRBS.Controls.Add(this.label1);
            this.groupBox_PRBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PRBS.Location = new System.Drawing.Point(22, 529);
            this.groupBox_PRBS.Name = "groupBox_PRBS";
            this.groupBox_PRBS.Size = new System.Drawing.Size(398, 69);
            this.groupBox_PRBS.TabIndex = 4;
            this.groupBox_PRBS.TabStop = false;
            this.groupBox_PRBS.Text = "PRBS Parameters";
            // 
            // textBox_PRBS_SR
            // 
            this.textBox_PRBS_SR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PRBS_SR.Location = new System.Drawing.Point(205, 31);
            this.textBox_PRBS_SR.Name = "textBox_PRBS_SR";
            this.textBox_PRBS_SR.Size = new System.Drawing.Size(100, 23);
            this.textBox_PRBS_SR.TabIndex = 20;
            this.textBox_PRBS_SR.Text = "0.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "PRBS SR: ";
            // 
            // groupBox_TrapZ
            // 
            this.groupBox_TrapZ.Controls.Add(this.textBox_TrapZ_minD);
            this.groupBox_TrapZ.Controls.Add(this.textBox_TrapZ_minW);
            this.groupBox_TrapZ.Controls.Add(this.label16);
            this.groupBox_TrapZ.Controls.Add(this.label17);
            this.groupBox_TrapZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TrapZ.Location = new System.Drawing.Point(22, 607);
            this.groupBox_TrapZ.Name = "groupBox_TrapZ";
            this.groupBox_TrapZ.Size = new System.Drawing.Size(398, 124);
            this.groupBox_TrapZ.TabIndex = 4;
            this.groupBox_TrapZ.TabStop = false;
            this.groupBox_TrapZ.Text = "TrapZ Parameters";
            // 
            // textBox_TrapZ_minD
            // 
            this.textBox_TrapZ_minD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TrapZ_minD.Location = new System.Drawing.Point(205, 71);
            this.textBox_TrapZ_minD.Name = "textBox_TrapZ_minD";
            this.textBox_TrapZ_minD.Size = new System.Drawing.Size(100, 23);
            this.textBox_TrapZ_minD.TabIndex = 19;
            this.textBox_TrapZ_minD.Text = "2.5";
            // 
            // textBox_TrapZ_minW
            // 
            this.textBox_TrapZ_minW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TrapZ_minW.Location = new System.Drawing.Point(205, 33);
            this.textBox_TrapZ_minW.Name = "textBox_TrapZ_minW";
            this.textBox_TrapZ_minW.Size = new System.Drawing.Size(100, 23);
            this.textBox_TrapZ_minW.TabIndex = 18;
            this.textBox_TrapZ_minW.Text = "2.5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Min Pulse Length (Sec):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "Min Delay Length (Sec):";
            // 
            // groupBox_TrapV
            // 
            this.groupBox_TrapV.Controls.Add(this.textBox_txAuto);
            this.groupBox_TrapV.Controls.Add(this.label12);
            this.groupBox_TrapV.Controls.Add(this.comboBox_TrapV);
            this.groupBox_TrapV.Controls.Add(this.radioB_AutoTrapV);
            this.groupBox_TrapV.Controls.Add(this.radioB_ManualTrapV);
            this.groupBox_TrapV.Controls.Add(this.textBox_tx);
            this.groupBox_TrapV.Controls.Add(this.textBox_tv);
            this.groupBox_TrapV.Controls.Add(this.textBox_ta);
            this.groupBox_TrapV.Controls.Add(this.label19);
            this.groupBox_TrapV.Controls.Add(this.label20);
            this.groupBox_TrapV.Controls.Add(this.label21);
            this.groupBox_TrapV.Controls.Add(this.textBox_TrapV_minD);
            this.groupBox_TrapV.Controls.Add(this.textBox_TrapV_minW);
            this.groupBox_TrapV.Controls.Add(this.label15);
            this.groupBox_TrapV.Controls.Add(this.label18);
            this.groupBox_TrapV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TrapV.Location = new System.Drawing.Point(431, 172);
            this.groupBox_TrapV.Name = "groupBox_TrapV";
            this.groupBox_TrapV.Size = new System.Drawing.Size(398, 426);
            this.groupBox_TrapV.TabIndex = 4;
            this.groupBox_TrapV.TabStop = false;
            this.groupBox_TrapV.Text = "TrapV Parameters";
            // 
            // textBox_txAuto
            // 
            this.textBox_txAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_txAuto.Location = new System.Drawing.Point(240, 310);
            this.textBox_txAuto.Name = "textBox_txAuto";
            this.textBox_txAuto.Size = new System.Drawing.Size(100, 23);
            this.textBox_txAuto.TabIndex = 34;
            this.textBox_txAuto.Text = "2.5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Position Time tx (Sec):";
            // 
            // comboBox_TrapV
            // 
            this.comboBox_TrapV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TrapV.FormattingEnabled = true;
            this.comboBox_TrapV.Location = new System.Drawing.Point(36, 347);
            this.comboBox_TrapV.Name = "comboBox_TrapV";
            this.comboBox_TrapV.Size = new System.Drawing.Size(304, 26);
            this.comboBox_TrapV.TabIndex = 32;
            this.comboBox_TrapV.SelectedIndexChanged += new System.EventHandler(this.ComboBox_TrapV_SelectedIndexChanged);
            // 
            // radioB_AutoTrapV
            // 
            this.radioB_AutoTrapV.AutoSize = true;
            this.radioB_AutoTrapV.Checked = true;
            this.radioB_AutoTrapV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB_AutoTrapV.Location = new System.Drawing.Point(17, 268);
            this.radioB_AutoTrapV.Name = "radioB_AutoTrapV";
            this.radioB_AutoTrapV.Size = new System.Drawing.Size(149, 21);
            this.radioB_AutoTrapV.TabIndex = 31;
            this.radioB_AutoTrapV.TabStop = true;
            this.radioB_AutoTrapV.Text = "Automatic Profile";
            this.radioB_AutoTrapV.UseVisualStyleBackColor = true;
            this.radioB_AutoTrapV.CheckedChanged += new System.EventHandler(this.RadioB_AutoTrapV_CheckedChanged);
            // 
            // radioB_ManualTrapV
            // 
            this.radioB_ManualTrapV.AutoSize = true;
            this.radioB_ManualTrapV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB_ManualTrapV.Location = new System.Drawing.Point(17, 115);
            this.radioB_ManualTrapV.Name = "radioB_ManualTrapV";
            this.radioB_ManualTrapV.Size = new System.Drawing.Size(130, 21);
            this.radioB_ManualTrapV.TabIndex = 30;
            this.radioB_ManualTrapV.Text = "Manual Profile";
            this.radioB_ManualTrapV.UseVisualStyleBackColor = true;
            this.radioB_ManualTrapV.CheckedChanged += new System.EventHandler(this.RadioB_ManualTrapV_CheckedChanged);
            // 
            // textBox_tx
            // 
            this.textBox_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tx.Location = new System.Drawing.Point(240, 215);
            this.textBox_tx.Name = "textBox_tx";
            this.textBox_tx.Size = new System.Drawing.Size(100, 23);
            this.textBox_tx.TabIndex = 29;
            this.textBox_tx.Text = "2.5";
            // 
            // textBox_tv
            // 
            this.textBox_tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tv.Location = new System.Drawing.Point(240, 183);
            this.textBox_tv.Name = "textBox_tv";
            this.textBox_tv.Size = new System.Drawing.Size(100, 23);
            this.textBox_tv.TabIndex = 28;
            // 
            // textBox_ta
            // 
            this.textBox_ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ta.Location = new System.Drawing.Point(240, 150);
            this.textBox_ta.Name = "textBox_ta";
            this.textBox_ta.Size = new System.Drawing.Size(100, 23);
            this.textBox_ta.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(65, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "Position Time tx (Sec):";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(32, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(199, 20);
            this.label20.TabIndex = 25;
            this.label20.Text = "Acceleration Time ta (Sec):";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(66, 183);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 20);
            this.label21.TabIndex = 24;
            this.label21.Text = "Velocity Time tv (Sec):";
            // 
            // textBox_TrapV_minD
            // 
            this.textBox_TrapV_minD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TrapV_minD.Location = new System.Drawing.Point(240, 68);
            this.textBox_TrapV_minD.Name = "textBox_TrapV_minD";
            this.textBox_TrapV_minD.Size = new System.Drawing.Size(100, 23);
            this.textBox_TrapV_minD.TabIndex = 23;
            this.textBox_TrapV_minD.Text = "2.5";
            // 
            // textBox_TrapV_minW
            // 
            this.textBox_TrapV_minW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TrapV_minW.Location = new System.Drawing.Point(240, 34);
            this.textBox_TrapV_minW.Name = "textBox_TrapV_minW";
            this.textBox_TrapV_minW.Size = new System.Drawing.Size(100, 23);
            this.textBox_TrapV_minW.TabIndex = 22;
            this.textBox_TrapV_minW.Text = "2.5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Min Pulse Length (Sec):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Min Delay Length (Sec):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(844, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_HSin
            // 
            this.groupBox_HSin.Controls.Add(this.textBox_HSIN_minD);
            this.groupBox_HSin.Controls.Add(this.label14);
            this.groupBox_HSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_HSin.Location = new System.Drawing.Point(22, 372);
            this.groupBox_HSin.Name = "groupBox_HSin";
            this.groupBox_HSin.Size = new System.Drawing.Size(398, 71);
            this.groupBox_HSin.TabIndex = 19;
            this.groupBox_HSin.TabStop = false;
            this.groupBox_HSin.Text = "H-Sin Parameters";
            // 
            // textBox_HSIN_minD
            // 
            this.textBox_HSIN_minD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HSIN_minD.Location = new System.Drawing.Point(205, 31);
            this.textBox_HSIN_minD.Name = "textBox_HSIN_minD";
            this.textBox_HSIN_minD.Size = new System.Drawing.Size(100, 23);
            this.textBox_HSIN_minD.TabIndex = 18;
            this.textBox_HSIN_minD.Text = "2.5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Min Delay Length (Sec):";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(489, 740);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 77);
            this.button2.TabIndex = 20;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(426, 703);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(398, 28);
            this.progressBar1.TabIndex = 21;
            // 
            // labelPbar
            // 
            this.labelPbar.AutoSize = true;
            this.labelPbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPbar.Location = new System.Drawing.Point(427, 678);
            this.labelPbar.Name = "labelPbar";
            this.labelPbar.Size = new System.Drawing.Size(220, 20);
            this.labelPbar.TabIndex = 22;
            this.labelPbar.Text = "CSV generation in progress ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 834);
            this.Controls.Add(this.labelPbar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox_HSin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_TrapV);
            this.Controls.Add(this.groupBox_TrapZ);
            this.Controls.Add(this.groupBox_PRBS);
            this.Controls.Add(this.groupBox_PRTS);
            this.Controls.Add(this.groupBox_GenParams);
            this.Controls.Add(this.groupBox_SOS);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox_SOS.ResumeLayout(false);
            this.groupBox_SOS.PerformLayout();
            this.groupBox_GenParams.ResumeLayout(false);
            this.groupBox_GenParams.PerformLayout();
            this.groupBox_PRTS.ResumeLayout(false);
            this.groupBox_PRTS.PerformLayout();
            this.groupBox_PRBS.ResumeLayout(false);
            this.groupBox_PRBS.PerformLayout();
            this.groupBox_TrapZ.ResumeLayout(false);
            this.groupBox_TrapZ.PerformLayout();
            this.groupBox_TrapV.ResumeLayout(false);
            this.groupBox_TrapV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_HSin.ResumeLayout(false);
            this.groupBox_HSin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_SOS;
        private System.Windows.Forms.GroupBox groupBox_GenParams;
        private System.Windows.Forms.ComboBox comboBox_Exp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nPulses;
        private System.Windows.Forms.TextBox textBox_Vel;
        private System.Windows.Forms.TextBox textBox_Amp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_PRTS;
        private System.Windows.Forms.GroupBox groupBox_PRBS;
        private System.Windows.Forms.GroupBox groupBox_TrapZ;
        private System.Windows.Forms.GroupBox groupBox_TrapV;
        private System.Windows.Forms.TextBox textBox_nFreq;
        private System.Windows.Forms.TextBox textBox_maxFreq;
        private System.Windows.Forms.TextBox textBox_minFreq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_Tend;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Tstart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_PRTSdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_TrapZ_minD;
        private System.Windows.Forms.TextBox textBox_TrapZ_minW;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_tx;
        private System.Windows.Forms.TextBox textBox_tv;
        private System.Windows.Forms.TextBox textBox_ta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_TrapV_minD;
        private System.Windows.Forms.TextBox textBox_TrapV_minW;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_HSin;
        private System.Windows.Forms.TextBox textBox_HSIN_minD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_PRBS_SR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioB_AutoTrapV;
        private System.Windows.Forms.RadioButton radioB_ManualTrapV;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelPbar;
        private System.Windows.Forms.ComboBox comboBox_TrapV;
        private System.Windows.Forms.TextBox textBox_txAuto;
        private System.Windows.Forms.Label label12;
    }
}

