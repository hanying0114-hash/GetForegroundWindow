namespace GetForegroundWindow
{
    partial class UserControl2
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
            btnBotSensor = new Button();
            btnBotSkin = new Button();
            label2 = new Label();
            btnTimeSetting = new Button();
            btnTimeReport = new Button();
            label3 = new Label();
            btnForm = new Button();
            btnBuger = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(386, 197);
            label1.Name = "label1";
            label1.Size = new Size(475, 259);
            label1.TabIndex = 1;
            label1.Text = "時間設定";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnBotSensor);
            panel1.Controls.Add(btnBotSkin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnTimeSetting);
            panel1.Controls.Add(btnTimeReport);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnForm);
            panel1.Controls.Add(btnBuger);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 707);
            panel1.TabIndex = 2;
            // 
            // btnBotSensor
            // 
            btnBotSensor.Dock = DockStyle.Top;
            btnBotSensor.FlatAppearance.BorderSize = 0;
            btnBotSensor.FlatStyle = FlatStyle.Flat;
            btnBotSensor.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnBotSensor.Location = new Point(0, 399);
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
            label2.Name = "label2";
            label2.Size = new Size(236, 57);
            label2.TabIndex = 4;
            label2.Text = "小管家相關";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTimeSetting
            // 
            btnTimeSetting.Dock = DockStyle.Top;
            btnTimeSetting.FlatAppearance.BorderSize = 0;
            btnTimeSetting.FlatStyle = FlatStyle.Flat;
            btnTimeSetting.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnTimeSetting.Location = new Point(0, 228);
            btnTimeSetting.Name = "btnTimeSetting";
            btnTimeSetting.Size = new Size(236, 57);
            btnTimeSetting.TabIndex = 2;
            btnTimeSetting.Tag = "UserControl2";
            btnTimeSetting.Text = "使用時間設定";
            btnTimeSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeSetting.UseVisualStyleBackColor = true;
            btnTimeSetting.Click += buttonControlForm_Click;
            // 
            // btnTimeReport
            // 
            btnTimeReport.Dock = DockStyle.Top;
            btnTimeReport.FlatAppearance.BorderSize = 0;
            btnTimeReport.FlatStyle = FlatStyle.Flat;
            btnTimeReport.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnTimeReport.Location = new Point(0, 171);
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
            label3.Name = "label3";
            label3.Size = new Size(236, 57);
            label3.TabIndex = 1;
            label3.Text = "使用時間相關";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnForm
            // 
            btnForm.Dock = DockStyle.Top;
            btnForm.FlatAppearance.BorderSize = 0;
            btnForm.FlatStyle = FlatStyle.Flat;
            btnForm.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnForm.Location = new Point(0, 57);
            btnForm.Margin = new Padding(2);
            btnForm.Name = "btnForm";
            btnForm.Size = new Size(236, 57);
            btnForm.TabIndex = 7;
            btnForm.Tag = "UserControl1";
            btnForm.Text = "主畫面";
            btnForm.TextAlign = ContentAlignment.MiddleLeft;
            btnForm.UseVisualStyleBackColor = true;
            // 
            // btnBuger
            // 
            btnBuger.BackColor = SystemColors.ButtonHighlight;
            btnBuger.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuger.Dock = DockStyle.Top;
            btnBuger.FlatAppearance.BorderSize = 0;
            btnBuger.FlatStyle = FlatStyle.Flat;
            btnBuger.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnBuger.Image = Properties.Resources.螢幕擷取畫面_2026_10_04_2040072;
            btnBuger.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuger.Location = new Point(0, 0);
            btnBuger.Name = "btnBuger";
            btnBuger.Size = new Size(236, 57);
            btnBuger.TabIndex = 1;
            btnBuger.TextAlign = ContentAlignment.MiddleLeft;
            btnBuger.UseVisualStyleBackColor = false;
            btnBuger.Click += button3_Click;
            // 
            // UserControl2
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "UserControl2";
            Size = new Size(1003, 707);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnBuger;
        private Button btnBotSensor;
        private Button btnBotSkin;
        private Label label2;
        private Button btnTimeSetting;
        private Button btnTimeReport;
        private Label label3;
        private Button btnForm;
    }
}
