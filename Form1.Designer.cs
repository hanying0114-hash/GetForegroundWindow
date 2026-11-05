namespace GetForegroundWindow
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
            splitContainer1 = new SplitContainer();
            pnlBuger = new Panel();
            ShowForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnlBuger);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ShowForm);
            splitContainer1.Size = new Size(1003, 707);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.TabIndex = 0;
            // 
            // pnlBuger
            // 
            pnlBuger.BackColor = SystemColors.ButtonHighlight;
            pnlBuger.Location = new Point(0, 0);
            pnlBuger.Margin = new Padding(2);
            pnlBuger.Name = "pnlBuger";
            pnlBuger.Size = new Size(236, 707);
            pnlBuger.TabIndex = 3;
            // 
            // ShowForm
            // 
            ShowForm.Dock = DockStyle.Fill;
            ShowForm.Location = new Point(0, 0);
            ShowForm.Name = "ShowForm";
            ShowForm.Size = new Size(929, 707);
            ShowForm.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1003, 707);
            Controls.Add(splitContainer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "小管家-設定";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private Panel pnlBuger;
        private Panel ShowForm;
    }
}
