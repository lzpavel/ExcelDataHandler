using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelDataHandler
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Thread thread = null;


        void LoadConfig()
        {
            Config.path = textBoxPath.Text;
            Config.sheet = textBoxSheet.Text;
            Config.column1Index = textBoxColumn1Index.Text;
            Config.column1Start = textBoxColumn1Start.Text;
            Config.column1End = textBoxColumn1End.Text;
            Config.column2Index = textBoxColumn2Index.Text;
            Config.column2Start = textBoxColumn2Start.Text;
            Config.column2End = textBoxColumn2End.Text;

            Config.colorMatchNo = labelMatchNoColor.BackColor;
            Config.colorMatchMore1 = labelMatchMore1Color.BackColor;

            Config.checkMatchMore1 = checkBoxMatchMore1.Checked;
            Config.fastMode = checkBoxFastMode.Checked;

        }

        void UploadConfig()
        {
            textBoxColumn1Index.Text = Config.column1Index;
            textBoxColumn1Start.Text = Config.column1Start;
            textBoxColumn1End.Text = Config.column1End;
            textBoxColumn2Index.Text = Config.column2Index;
            textBoxColumn2Start.Text = Config.column2Start;
            textBoxColumn2End.Text = Config.column2End;
        }

        void WorkerExcel()
        {
            try
            {
                Excel.Compare();
            }
            catch (Exception ex)
            {
                Log.Write(ex.Message);
            }
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBoxPath.Text = openFileDialog1.FileName;
        }

        private void buttonChangeColumns_Click(object sender, EventArgs e)
        {
            string s1 = textBoxColumn1Start.Text;
            string s2 = textBoxColumn1End.Text;
            string s3 = textBoxColumn1Index.Text;

            textBoxColumn1Start.Text = textBoxColumn2Start.Text;
            textBoxColumn1End.Text = textBoxColumn2End.Text;
            textBoxColumn1Index.Text = textBoxColumn2Index.Text;

            textBoxColumn2Start.Text = s1;
            textBoxColumn2End.Text = s2;
            textBoxColumn2Index.Text = s3;
        }

        private void buttonGetRanges_Click(object sender, EventArgs e)
        {
            LoadConfig();
            Excel.GetRanges();
            UploadConfig();

        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            LoadConfig();
            Config.InitCompare();
            thread = new Thread(WorkerExcel);
            thread.Start();
            timer1.Enabled = true;
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            FormLog formLog = new FormLog();
            formLog.Show();
        }

        private void labelMatchNoColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                labelMatchNoColor.BackColor = colorDialog1.Color;
            }
        }

        private void labelMatchMore1Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                labelMatchMore1Color.BackColor = colorDialog1.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Progress.isReady)
            {
                progressBar1.Maximum = Progress.total;
                progressBar1.Value = 0;
                Progress.isReady = false;
                Progress.isRunning = true;
            }

            if (Progress.isRunning)
            {
                progressBar1.Value = Progress.now;
                labelProgress.Text = Progress.now.ToString() + " / " + Progress.total.ToString();
            }

            if (Progress.isCompleted)
            {
                labelProgress.Text = "Completed: " + Progress.now.ToString() + " / " + Progress.total.ToString();

                Progress.isRunning = false;
                Progress.isCompleted = false;

                timer1.Enabled = false;

            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Excel.CloseDocument();
            Excel.CloseExcel();
            Excel.Dispose();
        }

       
    }
}
