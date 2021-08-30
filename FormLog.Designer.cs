
namespace ExcelDataHandler
{
    partial class FormLog
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
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.buttonLogUpdate = new System.Windows.Forms.Button();
            this.buttonLogClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(431, 356);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // buttonLogUpdate
            // 
            this.buttonLogUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogUpdate.Location = new System.Drawing.Point(12, 374);
            this.buttonLogUpdate.Name = "buttonLogUpdate";
            this.buttonLogUpdate.Size = new System.Drawing.Size(94, 29);
            this.buttonLogUpdate.TabIndex = 1;
            this.buttonLogUpdate.Text = "Update";
            this.buttonLogUpdate.UseVisualStyleBackColor = true;
            this.buttonLogUpdate.Click += new System.EventHandler(this.buttonLogUpdate_Click);
            // 
            // buttonLogClose
            // 
            this.buttonLogClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogClose.Location = new System.Drawing.Point(349, 374);
            this.buttonLogClose.Name = "buttonLogClose";
            this.buttonLogClose.Size = new System.Drawing.Size(94, 29);
            this.buttonLogClose.TabIndex = 2;
            this.buttonLogClose.Text = "Close";
            this.buttonLogClose.UseVisualStyleBackColor = true;
            this.buttonLogClose.Click += new System.EventHandler(this.buttonLogClose_Click);
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 415);
            this.Controls.Add(this.buttonLogClose);
            this.Controls.Add(this.buttonLogUpdate);
            this.Controls.Add(this.richTextBoxLog);
            this.Name = "FormLog";
            this.Text = "Log";
            this.Activated += new System.EventHandler(this.FormLog_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonLogUpdate;
        private System.Windows.Forms.Button buttonLogClose;
    }
}