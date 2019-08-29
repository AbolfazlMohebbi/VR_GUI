using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VR_GUI
{
    public partial class Form1 : Form
    {
        //private TextWriter AmpWriter;
        private float ExpNum;
        private float Amp;
        private float Vel_Max;
        private float minDeltaSec, minWSec;
        private float Num_Pulses;
        private float Start_time;
        private float End_time;
        private float PRTS_dt;
        private float TrapV_ta;
        private float TrapV_tv;
        private float TrapV_tx;
        private float TrapV_ta_auto;
        private float TrapV_tv_auto;
        private float TrapV_Amp_auto;
        private float TrapV_Vel_auto;
        private float SOS_minFreq;
        private float SOS_maxFreq;
        private float SOS_freqCount;
        private float Random_Direction;
        private float PRBS_SR;
        private Image img;

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Amp.Enabled = true;
            label3.Enabled = true;
            textBox_Vel.Enabled = true;
            label2.Enabled = true;
            labelPbar.Text = "CSV generation in progress ...";

            if (comboBox_Exp.SelectedIndex == 0)
            {
                ExpGroupboxesDisable();
            }
            if (comboBox_Exp.SelectedIndex == 1)
            {
                ExpGroupboxesDisable();
                groupBox_HSin.Enabled = true;
                img = Image.FromFile("HSin_profile_ann.png");
                pictureBox1.Image = img;
            }
            if (comboBox_Exp.SelectedIndex == 2)
            {
                ExpGroupboxesDisable();
                groupBox_PRTS.Enabled = true;
                img = Image.FromFile("PRTS_profile_ann.png");
                pictureBox1.Image = img;
            }
            if (comboBox_Exp.SelectedIndex == 3)
            {
                ExpGroupboxesDisable();
                groupBox_TrapZ.Enabled = true;
                img = Image.FromFile("TrapZ_profile_ann.png");
                pictureBox1.Image = img;

            }
            if (comboBox_Exp.SelectedIndex == 4)
            {
                ExpGroupboxesDisable();
                groupBox_TrapV.Enabled = true;
                textBox_Amp.Enabled =false;
                label3.Enabled = false;
                img = Image.FromFile("TrapV_profile_ann.png");
                pictureBox1.Image = img;
                if (radioB_ManualTrapV.Checked == false)
                {
                    label19.Enabled = false;
                    label20.Enabled = false;
                    label21.Enabled = false;
                    textBox_ta.Enabled = false;
                    textBox_tv.Enabled = false;
                    textBox_tx.Enabled = false;
                }
                if (radioB_AutoTrapV.Checked == true)
                {
                    label2.Enabled = false;
                    textBox_Vel.Enabled = false;
                }
            }
            if (comboBox_Exp.SelectedIndex == 5)
            {
                ExpGroupboxesDisable();
                groupBox_SOS.Enabled = true;
                img = Image.FromFile("SOS_profile_ann.png");
                pictureBox1.Image = img;
            }
            if (comboBox_Exp.SelectedIndex == 6)
            {
                ExpGroupboxesDisable();
                groupBox_PRBS.Enabled = true;
                img = Image.FromFile("PRBS_profile_ann.png");
                pictureBox1.Image = img;
            }

        }

        public Form1()
        {
            InitializeComponent();

            comboBox_Exp.Items.Add("No Input - Normal VR");
            comboBox_Exp.Items.Add("H-SIN - Half Sinusoids Signal");
            comboBox_Exp.Items.Add("PRTS - Pseudorandom Ternary Sequence");
            comboBox_Exp.Items.Add("TrapZ - Trapezoidal Position Signal");
            comboBox_Exp.Items.Add("TrapV - Trapezoidal Velocity Signal");
            comboBox_Exp.Items.Add("SOS - Sum of Sinusoids Signal");
            comboBox_Exp.Items.Add("PRBS - Pseudorandom Binary Sequence");
            //comboBox1.SelectedItem = "PRTS - Pseudorandom Ternary Sequence";
            ExpGroupboxesDisable();

            comboBox_TrapV.Items.Add("1deg - 2dps (ta = 0.2s, tv = 0.3s)");
            comboBox_TrapV.Items.Add("2deg - 2dps (ta = 0.4s, tv = 0.6s)");
            comboBox_TrapV.Items.Add("5deg - 2dps (ta = 1.0s, tv = 1.5s)");
            comboBox_TrapV.Items.Add("10deg - 2dps (ta = 2.0s, tv = 3.0s)");

            comboBox_TrapV.Items.Add("1deg - 5dps (ta = 0.08s, tv = 0.12s)");
            comboBox_TrapV.Items.Add("2deg - 5dps (ta = 0.16s, tv = 0.24s)");
            comboBox_TrapV.Items.Add("5deg - 5dps (ta = 0.4s, tv = 0.6s)");
            comboBox_TrapV.Items.Add("10deg - 5dps (ta = 0.8s, tv = 1.2s)");

            comboBox_TrapV.Items.Add("1deg - 10dps (ta = 0.04s, tv = 0.06s)");
            comboBox_TrapV.Items.Add("2deg - 10dps (ta = 0.08s, tv = 0.12s)");
            comboBox_TrapV.Items.Add("5deg - 10dps (ta = 0.2s, tv = 0.3s)");
            comboBox_TrapV.Items.Add("10deg - 10dps (ta = 0.4s, tv = 0.6s)");

            ExpNum = 0.0f;
            Amp = 0.0f;
            Vel_Max = 0.0f;
            minDeltaSec = 0.0f;
            minWSec = 0.0f;
            Num_Pulses = 0.0f;
            Start_time = 0.0f;
            End_time = 0.0f;
            PRTS_dt = 0.0f;
            TrapV_ta = 0.0f;
            TrapV_tv = 0.0f;
            TrapV_tx = 0.0f;
            TrapV_ta_auto = 0.0f;
            TrapV_tv_auto = 0.0f;
            SOS_minFreq = 0.0f;
            SOS_maxFreq = 0.0f;
            SOS_freqCount = 0.0f;
            Random_Direction = 0.0f;
            PRBS_SR = 0.0f;
    }

        private void Button1_Click(object sender, EventArgs e)
        {
            ExpNum = comboBox_Exp.SelectedIndex;
            Amp = float.Parse(textBox_Amp.Text);
            Vel_Max = float.Parse(textBox_Vel.Text);
            Num_Pulses = float.Parse(textBox_nPulses.Text);
            Start_time = float.Parse(textBox_Tstart.Text);
            End_time = float.Parse(textBox_Tend.Text);

            if (groupBox_PRTS.Enabled) PRTS_dt = float.Parse(textBox_PRTSdt.Text);

            if (groupBox_TrapV.Enabled)
            {
                if (radioB_ManualTrapV.Checked == true)
                {
                    TrapV_ta = float.Parse(textBox_ta.Text);
                    TrapV_tv = float.Parse(textBox_tv.Text);
                    TrapV_tx = float.Parse(textBox_tx.Text);
                }

                if (radioB_AutoTrapV.Checked == true)
                {
                    TrapV_ta = TrapV_ta_auto;
                    TrapV_tv = TrapV_tv_auto;
                    TrapV_tx = float.Parse(textBox_txAuto.Text);
                    Amp = TrapV_Amp_auto;
                    Vel_Max = TrapV_Vel_auto;
                }

                minDeltaSec = float.Parse(textBox_TrapV_minD.Text);
                minWSec = float.Parse(textBox_TrapV_minW.Text);
            }

            if (groupBox_SOS.Enabled)
            {
                SOS_minFreq = float.Parse(textBox_minFreq.Text);
                SOS_maxFreq = float.Parse(textBox_maxFreq.Text);
                SOS_freqCount = float.Parse(textBox_nFreq.Text);
            }

            if (groupBox_TrapZ.Enabled)
            {
                minDeltaSec = float.Parse(textBox_TrapZ_minD.Text);
                minWSec = float.Parse(textBox_TrapZ_minW.Text);
            }

            if (groupBox_HSin.Enabled) minDeltaSec = float.Parse(textBox_HSIN_minD.Text);
            if (checkBox1.Checked) Random_Direction = 1.0f; else Random_Direction = 0.0f;
            if (groupBox_PRBS.Enabled) PRBS_SR = float.Parse(textBox_PRBS_SR.Text);

            string fileName = "ExpParams.csv";
            string seprtr = ",";
            StringBuilder SBoutput = new StringBuilder();

            string legends = "Experiment NO, P2P_Amp, Vel_max, minDeltaSec, minWSec, NumPulses, Start_Time, End_Time, PRTS_dt, TrapV_ta, TrapV_tv, TrapV_tx, SOS_minFreq, SOS_maxFreq, SOS_freqCount, Random Direction, PRBS_SR";

            float[][] dataOutput = new float[][]
            {
                new float[] { ExpNum, Amp, Vel_Max, minDeltaSec, minWSec, Num_Pulses, Start_time, End_time,
                              PRTS_dt, TrapV_ta, TrapV_tv, TrapV_tx, SOS_minFreq, SOS_maxFreq, SOS_freqCount, Random_Direction, PRBS_SR },
            };

            SBoutput.AppendLine(legends);
            SBoutput.AppendLine(String.Join(seprtr, dataOutput[0]));

            File.WriteAllText(fileName, SBoutput.ToString());

            //for (int i = 0; i < 1; i++)
            ////SBoutput.AppendLine(String.Join(seprtr, dataOutput[i]));
            ////File.WriteAllText(fileName, SBoutput.ToString());  //Start a new csv file
            //File.AppendAllText(fileName, SBoutput.ToString());   // add lines to an existing csv file

            progressBar1.Value = 0;
            progressBar1.Step = 1;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.PerformStep();
            }
            labelPbar.Text = "Done writing CSV file !";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RadioB_ManualTrapV_CheckedChanged(object sender, EventArgs e)
        {
            label19.Enabled = radioB_ManualTrapV.Checked;
            label20.Enabled = radioB_ManualTrapV.Checked;
            label21.Enabled = radioB_ManualTrapV.Checked;
            textBox_ta.Enabled = radioB_ManualTrapV.Checked;
            textBox_tv.Enabled = radioB_ManualTrapV.Checked;
            textBox_tx.Enabled = radioB_ManualTrapV.Checked;
        }

        private void ComboBox_TrapV_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPbar.Text = "CSV generation in progress ...";
            if (comboBox_TrapV.SelectedIndex == 0) { TrapV_ta_auto = 0.2f; TrapV_tv_auto = 0.3f; TrapV_Amp_auto = 1.0f; TrapV_Vel_auto = 2.0f;}
            if (comboBox_TrapV.SelectedIndex == 1) { TrapV_ta_auto = 0.4f; TrapV_tv_auto = 0.6f; TrapV_Amp_auto = 2.0f; TrapV_Vel_auto = 2.0f;}
            if (comboBox_TrapV.SelectedIndex == 2) { TrapV_ta_auto = 1.0f; TrapV_tv_auto = 1.5f; TrapV_Amp_auto = 5.0f; TrapV_Vel_auto = 2.0f;}
            if (comboBox_TrapV.SelectedIndex == 3) { TrapV_ta_auto = 2.0f; TrapV_tv_auto = 3.0f; TrapV_Amp_auto = 10.0f; TrapV_Vel_auto = 2.0f;}

            if (comboBox_TrapV.SelectedIndex == 4) { TrapV_ta_auto = 0.08f; TrapV_tv_auto = 0.12f; TrapV_Amp_auto = 1.0f; TrapV_Vel_auto = 5.0f;}
            if (comboBox_TrapV.SelectedIndex == 5) { TrapV_ta_auto = 0.16f; TrapV_tv_auto = 0.24f; TrapV_Amp_auto = 2.0f; TrapV_Vel_auto = 5.0f;}
            if (comboBox_TrapV.SelectedIndex == 6) { TrapV_ta_auto = 0.4f;  TrapV_tv_auto = 0.6f;  TrapV_Amp_auto = 5.0f; TrapV_Vel_auto = 5.0f;}
            if (comboBox_TrapV.SelectedIndex == 7) { TrapV_ta_auto = 0.8f;  TrapV_tv_auto = 1.2f;  TrapV_Amp_auto = 10.0f; TrapV_Vel_auto = 5.0f;}

            if (comboBox_TrapV.SelectedIndex == 8) { TrapV_ta_auto = 0.04f; TrapV_tv_auto = 0.06f; TrapV_Amp_auto = 1.0f; TrapV_Vel_auto = 10.0f;}
            if (comboBox_TrapV.SelectedIndex == 9) { TrapV_ta_auto = 0.08f; TrapV_tv_auto = 0.12f; TrapV_Amp_auto = 2.0f; TrapV_Vel_auto = 10.0f;}
            if (comboBox_TrapV.SelectedIndex ==10) { TrapV_ta_auto = 0.2f;  TrapV_tv_auto = 0.3f;  TrapV_Amp_auto = 5.0f; TrapV_Vel_auto = 10.0f;}
            if (comboBox_TrapV.SelectedIndex ==11) { TrapV_ta_auto = 0.4f;  TrapV_tv_auto = 0.6f;  TrapV_Amp_auto = 10.0f; TrapV_Vel_auto = 10.0f;}
        }

        private void RadioB_AutoTrapV_CheckedChanged(object sender, EventArgs e)
        {
            label12.Enabled = radioB_AutoTrapV.Checked;
            comboBox_TrapV.Enabled = radioB_AutoTrapV.Checked;
            textBox_txAuto.Enabled = radioB_AutoTrapV.Checked;
            label2.Enabled = !(radioB_AutoTrapV.Checked);
            textBox_Vel.Enabled = !(radioB_AutoTrapV.Checked);
        }

        private void ExpGroupboxesDisable()
        {
            groupBox_SOS.Enabled = false;
            groupBox_PRTS.Enabled = false;
            groupBox_PRBS.Enabled = false;
            groupBox_TrapZ.Enabled = false;
            groupBox_TrapV.Enabled = false;
            groupBox_HSin.Enabled = false;
        }
    }
}
