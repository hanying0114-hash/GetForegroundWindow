namespace GetForegroundWindow
{
    partial class UserControl1
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
            pnlBuger = new Panel();
            btnBotSensor = new Button();
            btnBotSkin = new Button();
            label2 = new Label();
            btnTimSetting = new Button();
            btnTimeReport = new Button();
            label3 = new Label();
            btnBuger = new Button();
            button3 = new Button();
            pnlBuger.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(355, 230);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(538, 169);
            label1.TabIndex = 0;
            label1.Text = "使用時間報表";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBuger
            // 
            pnlBuger.BackColor = SystemColors.ButtonHighlight;
            pnlBuger.Controls.Add(btnBotSensor);
            pnlBuger.Controls.Add(btnBotSkin);
            pnlBuger.Controls.Add(label2);
            pnlBuger.Controls.Add(btnTimSetting);
            pnlBuger.Controls.Add(btnTimeReport);
            pnlBuger.Controls.Add(label3);
            pnlBuger.Controls.Add(btnBuger);
            pnlBuger.Controls.Add(button3);
            pnlBuger.Location = new Point(0, 0);
            pnlBuger.Margin = new Padding(2);
            pnlBuger.Name = "pnlBuger";
            pnlBuger.Size = new Size(236, 707);
            pnlBuger.TabIndex = 1;
            // 
            // btnBotSensor
            // 
            btnBotSensor.Dock = DockStyle.Top;
            btnBotSensor.FlatAppearance.BorderSize = 0;
            btnBotSensor.FlatStyle = FlatStyle.Flat;
            btnBotSensor.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnBotSensor.Location = new Point(0, 399);
            btnBotSensor.Margin = new Padding(2);
            btnBotSensor.Name = "btnBotSensor";
            btnBotSensor.Size = new Size(236, 57);
            btnBotSensor.TabIndex = 5;
            btnBotSensor.Tag = "UserControl4";
            btnBotSensor.Text = "小管家感知設定";
            btnBotSensor.TextAlign = ContentAlignment.MiddleLeft;
            btnBotSensor.UseVisualStyleBackColor = true;
            btnBotSensor.Click += buttonControlForm_Click;
            // 
            // btnBotSkin
            // 
            btnBotSkin.Dock = DockStyle.Top;
            btnBotSkin.FlatAppearance.BorderSize = 0;
            btnBotSkin.FlatStyle = FlatStyle.Flat;
            btnBotSkin.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnBotSkin.Location = new Point(0, 342);
            btnBotSkin.Margin = new Padding(2);
            btnBotSkin.Name = "btnBotSkin";
            btnBotSkin.Size = new Size(236, 57);
            btnBotSkin.TabIndex = 3;
            btnBotSkin.Tag = "UserControl3";
            btnBotSkin.Text = "小管家外觀設定";
            btnBotSkin.TextAlign = ContentAlignment.MiddleLeft;
            btnBotSkin.UseVisualStyleBackColor = true;
            btnBotSkin.Click += buttonControlForm_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(0, 285);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(236, 57);
            label2.TabIndex = 4;
            label2.Text = "小管家相關";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTimSetting
            // 
            btnTimSetting.Dock = DockStyle.Top;
            btnTimSetting.FlatAppearance.BorderSize = 0;
            btnTimSetting.FlatStyle = FlatStyle.Flat;
            btnTimSetting.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnTimSetting.Location = new Point(0, 228);
            btnTimSetting.Margin = new Padding(2);
            btnTimSetting.Name = "btnTimSetting";
            btnTimSetting.Size = new Size(236, 57);
            btnTimSetting.TabIndex = 2;
            btnTimSetting.Tag = "UserControl2";
            btnTimSetting.Text = "使用時間設定";
            btnTimSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnTimSetting.UseVisualStyleBackColor = true;
            btnTimSetting.Click += buttonControlForm_Click;
            // 
            // btnTimeReport
            // 
            btnTimeReport.Dock = DockStyle.Top;
            btnTimeReport.FlatAppearance.BorderSize = 0;
            btnTimeReport.FlatStyle = FlatStyle.Flat;
            btnTimeReport.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnTimeReport.Location = new Point(0, 171);
            btnTimeReport.Margin = new Padding(2);
            btnTimeReport.Name = "btnTimeReport";
            btnTimeReport.Size = new Size(236, 57);
            btnTimeReport.TabIndex = 1;
            btnTimeReport.Tag = "UserControl1";
            btnTimeReport.Text = "使用時間報表";
            btnTimeReport.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeReport.UseVisualStyleBackColor = true;
            btnTimeReport.Click += buttonControlForm_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(0, 114);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(236, 57);
            label3.TabIndex = 1;
            label3.Text = "使用時間相關";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuger
            // 
            btnBuger.Dock = DockStyle.Top;
            btnBuger.FlatAppearance.BorderSize = 0;
            btnBuger.FlatStyle = FlatStyle.Flat;
            btnBuger.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnBuger.Location = new Point(0, 57);
            btnBuger.Margin = new Padding(2);
            btnBuger.Name = "btnBuger";
            btnBuger.Size = new Size(236, 57);
            btnBuger.TabIndex = 6;
            btnBuger.Tag = "";
            btnBuger.Text = "主畫面";
            btnBuger.TextAlign = ContentAlignment.MiddleLeft;
            btnBuger.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Image = Properties.Resources.螢幕擷取畫面_2026_10_04_2040072;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(236, 57);
            button3.TabIndex = 1;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UserControl1
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlBuger);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UserControl1";
            Size = new Size(1003, 707);
            pnlBuger.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel pnlBuger;
        private Button button3;
        private Button btnBotSensor;
        private Button btnBotSkin;
        private Label label2;
        private Button btnTimSetting;
        private Button btnTimeReport;
        private Label label3;
        private Button btnBuger;
    }
}
