
namespace ExcelDataHandler
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelColumns = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGetRanges = new System.Windows.Forms.Button();
            this.buttonChangeColumns = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRows2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxColumn2End = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxColumn2Start = new System.Windows.Forms.TextBox();
            this.textBoxColumn2Index = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRows1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxColumn1End = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxColumn1Start = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxColumn1Index = new System.Windows.Forms.TextBox();
            this.textBoxSheet = new System.Windows.Forms.TextBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxFastMode = new System.Windows.Forms.CheckBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.labelMatchMore1Color = new System.Windows.Forms.Label();
            this.checkBoxMatchMore1 = new System.Windows.Forms.CheckBox();
            this.labelMatchNoColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanelColumns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanelRows2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanelRows1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanelColumns);
            this.groupBox1.Controls.Add(this.textBoxSheet);
            this.groupBox1.Controls.Add(this.buttonPath);
            this.groupBox1.Controls.Add(this.textBoxPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel";
            // 
            // tableLayoutPanelColumns
            // 
            this.tableLayoutPanelColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelColumns.ColumnCount = 3;
            this.tableLayoutPanelColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelColumns.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanelColumns.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanelColumns.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanelColumns.Location = new System.Drawing.Point(6, 92);
            this.tableLayoutPanelColumns.Name = "tableLayoutPanelColumns";
            this.tableLayoutPanelColumns.RowCount = 1;
            this.tableLayoutPanelColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanelColumns.Size = new System.Drawing.Size(764, 117);
            this.tableLayoutPanelColumns.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonGetRanges);
            this.panel1.Controls.Add(this.buttonChangeColumns);
            this.panel1.Location = new System.Drawing.Point(346, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 111);
            this.panel1.TabIndex = 8;
            // 
            // buttonGetRanges
            // 
            this.buttonGetRanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetRanges.Location = new System.Drawing.Point(3, 26);
            this.buttonGetRanges.Name = "buttonGetRanges";
            this.buttonGetRanges.Size = new System.Drawing.Size(64, 27);
            this.buttonGetRanges.TabIndex = 5;
            this.buttonGetRanges.Text = "Auto Get";
            this.buttonGetRanges.UseVisualStyleBackColor = true;
            this.buttonGetRanges.Click += new System.EventHandler(this.buttonGetRanges_Click);
            // 
            // buttonChangeColumns
            // 
            this.buttonChangeColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeColumns.Location = new System.Drawing.Point(3, 65);
            this.buttonChangeColumns.Name = "buttonChangeColumns";
            this.buttonChangeColumns.Size = new System.Drawing.Size(64, 27);
            this.buttonChangeColumns.TabIndex = 7;
            this.buttonChangeColumns.Text = "<=>";
            this.buttonChangeColumns.UseVisualStyleBackColor = true;
            this.buttonChangeColumns.Click += new System.EventHandler(this.buttonChangeColumns_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanelRows2);
            this.groupBox3.Controls.Add(this.textBoxColumn2Index);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(422, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 111);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Column2";
            // 
            // tableLayoutPanelRows2
            // 
            this.tableLayoutPanelRows2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelRows2.ColumnCount = 2;
            this.tableLayoutPanelRows2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRows2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRows2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanelRows2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanelRows2.Location = new System.Drawing.Point(6, 59);
            this.tableLayoutPanelRows2.Name = "tableLayoutPanelRows2";
            this.tableLayoutPanelRows2.RowCount = 1;
            this.tableLayoutPanelRows2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRows2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanelRows2.Size = new System.Drawing.Size(327, 42);
            this.tableLayoutPanelRows2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.textBoxColumn2End);
            this.panel4.Location = new System.Drawing.Point(166, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 36);
            this.panel4.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "REnd:";
            // 
            // textBoxColumn2End
            // 
            this.textBoxColumn2End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumn2End.Location = new System.Drawing.Point(55, 3);
            this.textBoxColumn2End.Name = "textBoxColumn2End";
            this.textBoxColumn2End.Size = new System.Drawing.Size(102, 27);
            this.textBoxColumn2End.TabIndex = 1;
            this.textBoxColumn2End.Text = "7";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.textBoxColumn2Start);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 36);
            this.panel5.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "RStart:";
            // 
            // textBoxColumn2Start
            // 
            this.textBoxColumn2Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumn2Start.Location = new System.Drawing.Point(61, 3);
            this.textBoxColumn2Start.Name = "textBoxColumn2Start";
            this.textBoxColumn2Start.Size = new System.Drawing.Size(94, 27);
            this.textBoxColumn2Start.TabIndex = 0;
            this.textBoxColumn2Start.Text = "1";
            // 
            // textBoxColumn2Index
            // 
            this.textBoxColumn2Index.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumn2Index.Location = new System.Drawing.Point(69, 26);
            this.textBoxColumn2Index.Name = "textBoxColumn2Index";
            this.textBoxColumn2Index.Size = new System.Drawing.Size(260, 27);
            this.textBoxColumn2Index.TabIndex = 5;
            this.textBoxColumn2Index.Text = "H";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "CIndex:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanelRows1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxColumn1Index);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 111);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Column1";
            // 
            // tableLayoutPanelRows1
            // 
            this.tableLayoutPanelRows1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelRows1.ColumnCount = 2;
            this.tableLayoutPanelRows1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRows1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRows1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanelRows1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanelRows1.Location = new System.Drawing.Point(6, 59);
            this.tableLayoutPanelRows1.Name = "tableLayoutPanelRows1";
            this.tableLayoutPanelRows1.RowCount = 1;
            this.tableLayoutPanelRows1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRows1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanelRows1.Size = new System.Drawing.Size(325, 42);
            this.tableLayoutPanelRows1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxColumn1End);
            this.panel3.Location = new System.Drawing.Point(165, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 36);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "REnd:";
            // 
            // textBoxColumn1End
            // 
            this.textBoxColumn1End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumn1End.Location = new System.Drawing.Point(55, 3);
            this.textBoxColumn1End.Name = "textBoxColumn1End";
            this.textBoxColumn1End.Size = new System.Drawing.Size(99, 27);
            this.textBoxColumn1End.TabIndex = 1;
            this.textBoxColumn1End.Text = "3";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxColumn1Start);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 36);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "RStart:";
            // 
            // textBoxColumn1Start
            // 
            this.textBoxColumn1Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumn1Start.Location = new System.Drawing.Point(61, 3);
            this.textBoxColumn1Start.Name = "textBoxColumn1Start";
            this.textBoxColumn1Start.Size = new System.Drawing.Size(92, 27);
            this.textBoxColumn1Start.TabIndex = 0;
            this.textBoxColumn1Start.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "CIndex:";
            // 
            // textBoxColumn1Index
            // 
            this.textBoxColumn1Index.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColumn1Index.Location = new System.Drawing.Point(69, 26);
            this.textBoxColumn1Index.Name = "textBoxColumn1Index";
            this.textBoxColumn1Index.Size = new System.Drawing.Size(256, 27);
            this.textBoxColumn1Index.TabIndex = 0;
            this.textBoxColumn1Index.Text = "A";
            // 
            // textBoxSheet
            // 
            this.textBoxSheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSheet.Location = new System.Drawing.Point(61, 59);
            this.textBoxSheet.Name = "textBoxSheet";
            this.textBoxSheet.Size = new System.Drawing.Size(656, 27);
            this.textBoxSheet.TabIndex = 5;
            this.textBoxSheet.Text = "1";
            // 
            // buttonPath
            // 
            this.buttonPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPath.Location = new System.Drawing.Point(723, 25);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(47, 29);
            this.buttonPath.TabIndex = 4;
            this.buttonPath.Text = "...";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(61, 26);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(656, 27);
            this.textBoxPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sheet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.checkBoxFastMode);
            this.groupBox4.Controls.Add(this.buttonLog);
            this.groupBox4.Controls.Add(this.buttonCompare);
            this.groupBox4.Controls.Add(this.labelMatchMore1Color);
            this.groupBox4.Controls.Add(this.checkBoxMatchMore1);
            this.groupBox4.Controls.Add(this.labelMatchNoColor);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 290);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // checkBoxFastMode
            // 
            this.checkBoxFastMode.AutoSize = true;
            this.checkBoxFastMode.Checked = true;
            this.checkBoxFastMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFastMode.Location = new System.Drawing.Point(6, 76);
            this.checkBoxFastMode.Name = "checkBoxFastMode";
            this.checkBoxFastMode.Size = new System.Drawing.Size(158, 24);
            this.checkBoxFastMode.TabIndex = 6;
            this.checkBoxFastMode.Text = "Fast mode via RAM";
            this.checkBoxFastMode.UseVisualStyleBackColor = true;
            // 
            // buttonLog
            // 
            this.buttonLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLog.Location = new System.Drawing.Point(676, 255);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(94, 29);
            this.buttonLog.TabIndex = 5;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCompare.Location = new System.Drawing.Point(6, 255);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(94, 29);
            this.buttonCompare.TabIndex = 4;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // labelMatchMore1Color
            // 
            this.labelMatchMore1Color.AutoSize = true;
            this.labelMatchMore1Color.BackColor = System.Drawing.Color.Blue;
            this.labelMatchMore1Color.Location = new System.Drawing.Point(178, 47);
            this.labelMatchMore1Color.MinimumSize = new System.Drawing.Size(20, 20);
            this.labelMatchMore1Color.Name = "labelMatchMore1Color";
            this.labelMatchMore1Color.Size = new System.Drawing.Size(20, 20);
            this.labelMatchMore1Color.TabIndex = 3;
            this.labelMatchMore1Color.Click += new System.EventHandler(this.labelMatchMore1Color_Click);
            // 
            // checkBoxMatchMore1
            // 
            this.checkBoxMatchMore1.AutoSize = true;
            this.checkBoxMatchMore1.Checked = true;
            this.checkBoxMatchMore1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMatchMore1.Location = new System.Drawing.Point(6, 46);
            this.checkBoxMatchMore1.Name = "checkBoxMatchMore1";
            this.checkBoxMatchMore1.Size = new System.Drawing.Size(166, 24);
            this.checkBoxMatchMore1.TabIndex = 2;
            this.checkBoxMatchMore1.Text = "Check more 1 match";
            this.checkBoxMatchMore1.UseVisualStyleBackColor = true;
            // 
            // labelMatchNoColor
            // 
            this.labelMatchNoColor.AutoSize = true;
            this.labelMatchNoColor.BackColor = System.Drawing.Color.Red;
            this.labelMatchNoColor.Location = new System.Drawing.Point(178, 23);
            this.labelMatchNoColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.labelMatchNoColor.Name = "labelMatchNoColor";
            this.labelMatchNoColor.Size = new System.Drawing.Size(20, 20);
            this.labelMatchNoColor.TabIndex = 1;
            this.labelMatchNoColor.Click += new System.EventHandler(this.labelMatchNoColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Match color:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.labelProgress);
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Location = new System.Drawing.Point(12, 532);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(776, 86);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Progress";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(6, 23);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(39, 20);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "0 / 0";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(6, 46);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(764, 29);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel (*.xlsx; *.xlsm; *.xls)|*.xlsx; *.xlsm; *.xls|All files (*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Excel Data Handler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanelColumns.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanelRows2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanelRows1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSheet;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxColumn1End;
        private System.Windows.Forms.TextBox textBoxColumn1Start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColumns;
        private System.Windows.Forms.Button buttonChangeColumns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelMatchMore1Color;
        private System.Windows.Forms.CheckBox checkBoxMatchMore1;
        private System.Windows.Forms.Label labelMatchNoColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRows2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxColumn2End;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxColumn2Start;
        private System.Windows.Forms.TextBox textBoxColumn2Index;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRows1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxColumn1Index;
        private System.Windows.Forms.Button buttonGetRanges;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxFastMode;
    }
}

