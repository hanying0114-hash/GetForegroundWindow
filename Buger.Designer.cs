namespace GetForegroundWindow
{
    partial class Buger
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
            pnlBuger = new Panel();
            btnBotSensor = new Button();
            btnBotSkin = new Button();
            label2 = new Label();
            btnTimeSetting = new Button();
            btnTimeReport = new Button();
            label3 = new Label();
            btnMainForm = new Button();
            btnBuger = new Button();
            pnlBuger.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBuger
            // 
            pnlBuger.BackColor = SystemColors.ButtonHighlight;
            pnlBuger.Controls.Add(btnBotSensor);
            pnlBuger.Controls.Add(btnBotSkin);
            pnlBuger.Controls.Add(label2);
            pnlBuger.Controls.Add(btnTimeSetting);
            pnlBuger.Controls.Add(btnTimeReport);
            pnlBuger.Controls.Add(label3);
            pnlBuger.Controls.Add(btnMainForm);
            pnlBuger.Controls.Add(btnBuger);
            pnlBuger.Location = new Point(0, 0);
            pnlBuger.Margin = new Padding(2);
            pnlBuger.Name = "pnlBuger";
            pnlBuger.Size = new Size(236, 707);
            pnlBuger.TabIndex = 4;
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
            btnBotSensor.Tag = "BotSensor";
            btnBotSensor.Text = "小管家感知設定";
            btnBotSensor.TextAlign = ContentAlignment.MiddleLeft;
            btnBotSensor.UseVisualStyleBackColor = true;
            btnBotSensor.Click += Controlbtn_Click;
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
            btnBotSkin.Tag = "BotSkin";
            btnBotSkin.Text = "小管家外觀設定";
            btnBotSkin.TextAlign = ContentAlignment.MiddleLeft;
            btnBotSkin.UseVisualStyleBackColor = true;
            btnBotSkin.Click += Controlbtn_Click;
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
            // btnTimeSetting
            // 
            btnTimeSetting.Dock = DockStyle.Top;
            btnTimeSetting.FlatAppearance.BorderSize = 0;
            btnTimeSetting.FlatStyle = FlatStyle.Flat;
            btnTimeSetting.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnTimeSetting.Location = new Point(0, 228);
            btnTimeSetting.Margin = new Padding(2);
            btnTimeSetting.Name = "btnTimeSetting";
            btnTimeSetting.Size = new Size(236, 57);
            btnTimeSetting.TabIndex = 2;
            btnTimeSetting.Tag = "TimeSetting";
            btnTimeSetting.Text = "使用時間設定";
            btnTimeSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeSetting.UseVisualStyleBackColor = true;
            btnTimeSetting.Click += Controlbtn_Click;
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
            btnTimeReport.Tag = "TimeReport";
            btnTimeReport.Text = "使用時間報表";
            btnTimeReport.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeReport.UseVisualStyleBackColor = true;
            btnTimeReport.Click += Controlbtn_Click;
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
            // btnMainForm
            // 
            btnMainForm.Dock = DockStyle.Top;
            btnMainForm.FlatAppearance.BorderSize = 0;
            btnMainForm.FlatStyle = FlatStyle.Flat;
            btnMainForm.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnMainForm.Location = new Point(0, 57);
            btnMainForm.Margin = new Padding(2);
            btnMainForm.Name = "btnMainForm";
            btnMainForm.Size = new Size(236, 57);
            btnMainForm.TabIndex = 6;
            btnMainForm.Tag = "MainForm";
            btnMainForm.Text = "主畫面";
            btnMainForm.TextAlign = ContentAlignment.MiddleLeft;
            btnMainForm.UseVisualStyleBackColor = true;
            btnMainForm.Click += Controlbtn_Click;
            // 
            // btnBuger
            // 
            btnBuger.BackColor = SystemColors.ButtonHighlight;
            btnBuger.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuger.Dock = DockStyle.Top;
            btnBuger.FlatAppearance.BorderSize = 0;
            btnBuger.FlatStyle = FlatStyle.Flat;
            btnBuger.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnBuger.Image = Properties.Resources.螢幕擷取畫面_2026_10_04_2040072;
            btnBuger.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuger.Location = new Point(0, 0);
            btnBuger.Margin = new Padding(2);
            btnBuger.Name = "btnBuger";
            btnBuger.Size = new Size(236, 57);
            btnBuger.TabIndex = 1;
            btnBuger.TextAlign = ContentAlignment.MiddleLeft;
            btnBuger.UseVisualStyleBackColor = false;
            btnBuger.Click += btnBuger_Click;
            // 
            // Buger
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlBuger);
            Name = "Buger";
            Size = new Size(236, 707);
            pnlBuger.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBuger;
        private Button btnBotSensor;
        private Button btnBotSkin;
        private Label label2;
        private Button btnTimeSetting;
        private Button btnTimeReport;
        private Label label3;
        private Button btnMainForm;
        private Button btnBuger;
    }
}
