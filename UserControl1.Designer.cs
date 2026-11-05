namespace GetForegroundWindow
{
    partial class TimeReport
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(315, 61);
            label1.TabIndex = 0;
            label1.Text = "使用時間報表";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Bottom;
            formsPlot1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            formsPlot1.Location = new Point(141, 111);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(720, 441);
            formsPlot1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(769, 603);
            button1.Name = "button1";
            button1.Size = new Size(188, 51);
            button1.TabIndex = 2;
            button1.Text = "切換至週報";
            button1.UseVisualStyleBackColor = true;
            // 
            // TimeReport
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(button1);
            Controls.Add(formsPlot1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "TimeReport";
            Size = new Size(1003, 707);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button button1;
    }
}
