using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelDataHandler
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        void UpdateLog()
        {
            richTextBoxLog.Clear();
            foreach (string s in Log.listMessages)
            {
                richTextBoxLog.AppendText(s);
            }
        }

        private void buttonLogUpdate_Click(object sender, EventArgs e)
        {
            UpdateLog();
        }

        private void FormLog_Activated(object sender, EventArgs e)
        {
            UpdateLog();
        }

        private void buttonLogClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
