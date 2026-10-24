using System.Windows.Forms;

namespace GetForegroundWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlBuger.Size = new Size(70, 56);
        }
        bool btnBugerClicked = false;
        UserControl panel;
        //創建字典
        Dictionary<string, UserControl> dict = new Dictionary<string, UserControl>
        {
            //初始創建字典選項
            ["UserControl1"] = new UserControl1(),
            ["UserControl2"] = new UserControl2(),
            ["UserControl3"] = new UserControl3(),
            ["UserControl4"] = new UserControl4(),
        };
        private void btnBuger_Click(object sender, EventArgs e) 
        {
            if (!btnBugerClicked)   //顯示整個選單
            {
                btnBugerClicked = true;
                pnlBuger.Width = 236;
                this.ActiveControl = null;      //失去焦點
                pnlBuger.Dock = DockStyle.Left;
            }
            else       //只顯示"三"
            {
                btnBugerClicked = false;
                pnlBuger.Width = 70;
                pnlBuger.Dock = DockStyle.None;
            }
        }
        private void buttonControlForm_Click(object sender,EventArgs e)     //事件共用
        {
            Button buttonControl = sender as Button;        //接收當前按哪個按鈕
            string userControl = buttonControl.Tag as string;   //抓出他的Tag且轉成string
            PanelLoading(userControl);      //丟給函式PanelLoading
        }
        public void PanelLoading(string userControl)
        {   //將換頁封裝成函式
            panel = dict[userControl]; //字典查詢
            bool panelContains = Controls.Contains(panel);  //panel是否包含在Controls中
            if (!panelContains)
            {
                Controls.Clear();
                Controls.Add(panel);
                panel.Dock = DockStyle.Fill;
            }
        }
    }
}
