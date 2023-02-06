namespace SE_258971_Assignment1
{
    partial class Form1
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
            this.buttonSampling = new System.Windows.Forms.Button();
            this.labelSampling = new System.Windows.Forms.Label();
            this.groupBoxSampling = new System.Windows.Forms.GroupBox();
            this.textBoxNextSamplingTime = new System.Windows.Forms.TextBox();
            this.buttonLogging = new System.Windows.Forms.Button();
            this.labelLogging = new System.Windows.Forms.Label();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            this.textBoxNextLoggingTime = new System.Windows.Forms.TextBox();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.groupBoxShow = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSampling.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            this.groupBoxShow.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSampling
            // 
            this.buttonSampling.Location = new System.Drawing.Point(6, 96);
            this.buttonSampling.Name = "buttonSampling";
            this.buttonSampling.Size = new System.Drawing.Size(75, 23);
            this.buttonSampling.TabIndex = 0;
            this.buttonSampling.Text = "Sampling";
            this.buttonSampling.UseVisualStyleBackColor = true;
            this.buttonSampling.Click += new System.EventHandler(this.buttonSampling_Click);
            // 
            // labelSampling
            // 
            this.labelSampling.AutoSize = true;
            this.labelSampling.Location = new System.Drawing.Point(6, 28);
            this.labelSampling.Name = "labelSampling";
            this.labelSampling.Size = new System.Drawing.Size(114, 15);
            this.labelSampling.TabIndex = 2;
            this.labelSampling.Text = "Next Sampling Time";
            this.labelSampling.Click += new System.EventHandler(this.labelSampling_Click);
            // 
            // groupBoxSampling
            // 
            this.groupBoxSampling.Controls.Add(this.buttonSampling);
            this.groupBoxSampling.Controls.Add(this.textBoxNextSamplingTime);
            this.groupBoxSampling.Controls.Add(this.labelSampling);
            this.groupBoxSampling.Location = new System.Drawing.Point(60, 37);
            this.groupBoxSampling.Name = "groupBoxSampling";
            this.groupBoxSampling.Size = new System.Drawing.Size(332, 156);
            this.groupBoxSampling.TabIndex = 3;
            this.groupBoxSampling.TabStop = false;
            this.groupBoxSampling.Text = "Sampling";
            this.groupBoxSampling.Enter += new System.EventHandler(this.groupBoxSampling_Enter);
            // 
            // textBoxNextSamplingTime
            // 
            this.textBoxNextSamplingTime.Location = new System.Drawing.Point(149, 25);
            this.textBoxNextSamplingTime.Name = "textBoxNextSamplingTime";
            this.textBoxNextSamplingTime.Size = new System.Drawing.Size(161, 23);
            this.textBoxNextSamplingTime.TabIndex = 3;
            this.textBoxNextSamplingTime.TextChanged += new System.EventHandler(this.textBoxNextSamplingTime_TextChanged);
            // 
            // buttonLogging
            // 
            this.buttonLogging.Location = new System.Drawing.Point(0, 131);
            this.buttonLogging.Name = "buttonLogging";
            this.buttonLogging.Size = new System.Drawing.Size(103, 23);
            this.buttonLogging.TabIndex = 4;
            this.buttonLogging.Text = "Logging on File";
            this.buttonLogging.UseVisualStyleBackColor = true;
            this.buttonLogging.Click += new System.EventHandler(this.buttonLogging_Click);
            // 
            // labelLogging
            // 
            this.labelLogging.AutoSize = true;
            this.labelLogging.Location = new System.Drawing.Point(6, 31);
            this.labelLogging.Name = "labelLogging";
            this.labelLogging.Size = new System.Drawing.Size(108, 15);
            this.labelLogging.TabIndex = 6;
            this.labelLogging.Text = "Next Logging Time";
            this.labelLogging.Click += new System.EventHandler(this.labelLogging_Click);
            // 
            // groupBoxLogging
            // 
            this.groupBoxLogging.Controls.Add(this.textBoxNextLoggingTime);
            this.groupBoxLogging.Controls.Add(this.buttonLogging);
            this.groupBoxLogging.Controls.Add(this.labelLogging);
            this.groupBoxLogging.Location = new System.Drawing.Point(60, 217);
            this.groupBoxLogging.Name = "groupBoxLogging";
            this.groupBoxLogging.Size = new System.Drawing.Size(332, 160);
            this.groupBoxLogging.TabIndex = 7;
            this.groupBoxLogging.TabStop = false;
            this.groupBoxLogging.Text = "Logging";
            this.groupBoxLogging.Enter += new System.EventHandler(this.groupBoxLogging_Enter);
            // 
            // textBoxNextLoggingTime
            // 
            this.textBoxNextLoggingTime.Location = new System.Drawing.Point(149, 23);
            this.textBoxNextLoggingTime.Name = "textBoxNextLoggingTime";
            this.textBoxNextLoggingTime.Size = new System.Drawing.Size(161, 23);
            this.textBoxNextLoggingTime.TabIndex = 7;
            this.textBoxNextLoggingTime.TextChanged += new System.EventHandler(this.textBoxNextLoggingTime_TextChanged);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(16, 22);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(152, 337);
            this.textBoxShow.TabIndex = 8;
            this.textBoxShow.TextChanged += new System.EventHandler(this.textBoxShow_TextChanged);
            // 
            // groupBoxShow
            // 
            this.groupBoxShow.Controls.Add(this.textBoxShow);
            this.groupBoxShow.Location = new System.Drawing.Point(425, 12);
            this.groupBoxShow.Name = "groupBoxShow";
            this.groupBoxShow.Size = new System.Drawing.Size(200, 365);
            this.groupBoxShow.TabIndex = 9;
            this.groupBoxShow.TabStop = false;
            this.groupBoxShow.Text = "Sensor Values";
            this.groupBoxShow.Enter += new System.EventHandler(this.groupBoxShow_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 398);
            this.Controls.Add(this.groupBoxSampling);
            this.Controls.Add(this.groupBoxLogging);
            this.Controls.Add(this.groupBoxShow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.groupBoxSampling.ResumeLayout(false);
            this.groupBoxSampling.PerformLayout();
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            this.groupBoxShow.ResumeLayout(false);
            this.groupBoxShow.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSampling;
        private Label labelSampling;
        private GroupBox groupBoxSampling;
        private Button buttonLogging;
        private Label labelLogging;
        private GroupBox groupBoxLogging;
        private TextBox textBoxShow;
        private GroupBox groupBoxShow;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox textBoxNextSamplingTime;
        private TextBox textBoxNextLoggingTime;
    }
}