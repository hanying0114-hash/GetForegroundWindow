namespace GetForegroundWindow
{
    partial class TimeSetting
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
            panel1 = new Panel();
            label3 = new Label();
            materialSwitch2 = new ReaLTaiizor.Controls.MaterialSwitch();
            panel2 = new Panel();
            label4 = new Label();
            materialSwitch3 = new ReaLTaiizor.Controls.MaterialSwitch();
            panel3 = new Panel();
            label2 = new Label();
            materialSwitch1 = new ReaLTaiizor.Controls.MaterialSwitch();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 61);
            label1.TabIndex = 1;
            label1.Text = "時間設定";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(materialSwitch2);
            panel1.Location = new Point(384, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 69);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(84, 16);
            label3.Name = "label3";
            label3.Size = new Size(146, 41);
            label3.TabIndex = 7;
            label3.Text = "畫面偵測";
            // 
            // materialSwitch2
            // 
            materialSwitch2.AutoSize = true;
            materialSwitch2.Depth = 0;
            materialSwitch2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialSwitch2.Location = new Point(9, 7);
            materialSwitch2.Margin = new Padding(0);
            materialSwitch2.MouseLocation = new Point(-1, -1);
            materialSwitch2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialSwitch2.Name = "materialSwitch2";
            materialSwitch2.Ripple = true;
            materialSwitch2.Size = new Size(87, 55);
            materialSwitch2.TabIndex = 6;
            materialSwitch2.UseAccentColor = false;
            materialSwitch2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(materialSwitch3);
            panel2.Location = new Point(695, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 69);
            panel2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(84, 16);
            label4.Name = "label4";
            label4.Size = new Size(146, 41);
            label4.TabIndex = 7;
            label4.Text = "畫面偵測";
            // 
            // materialSwitch3
            // 
            materialSwitch3.AutoSize = true;
            materialSwitch3.Depth = 0;
            materialSwitch3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialSwitch3.Location = new Point(9, 7);
            materialSwitch3.Margin = new Padding(0);
            materialSwitch3.MouseLocation = new Point(-1, -1);
            materialSwitch3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialSwitch3.Name = "materialSwitch3";
            materialSwitch3.Ripple = true;
            materialSwitch3.Size = new Size(87, 55);
            materialSwitch3.TabIndex = 6;
            materialSwitch3.UseAccentColor = false;
            materialSwitch3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(materialSwitch1);
            panel3.Location = new Point(17, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 69);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(84, 16);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 7;
            label2.Text = "畫面偵測";
            // 
            // materialSwitch1
            // 
            materialSwitch1.AutoSize = true;
            materialSwitch1.Depth = 0;
            materialSwitch1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialSwitch1.Location = new Point(9, 7);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(87, 55);
            materialSwitch1.TabIndex = 6;
            materialSwitch1.UseAccentColor = false;
            materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // TimeSetting
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "TimeSetting";
            Size = new Size(1003, 707);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private ReaLTaiizor.Controls.MaterialSwitch materialSwitch2;
        private Panel panel2;
        private Label label4;
        private ReaLTaiizor.Controls.MaterialSwitch materialSwitch3;
        private Panel panel3;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialSwitch materialSwitch1;
    }
}
