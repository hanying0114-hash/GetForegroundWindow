using System.Windows.Forms;

namespace GetForegroundWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlBuger.Controls.Add(new Buger());
            ShowForm.Controls.Add(new MainForm());
        }
        bool btnBugerClicked = false;
        UserControl panel;
        Dictionary<string, UserControl> dict = new Dictionary<string, UserControl>
        {//創建字典
            //初始創建字典選項
            ["TimeReport"] = new TimeReport(),
            ["TimeSetting"] = new TimeSetting(),
            ["BotSkin"] = new BotSkin(),
            ["BotSensor"] = new BotSensor(),
            ["MainForm"] = new MainForm()
        };
        public void PanelLoading(string userControl)
        {   //將換頁封裝成函式
            panel = dict[userControl]; //字典查詢
            bool panelContains = Controls.Contains(panel);  //panel是否包含在Controls中
            if (!panelContains)
            {
                ShowForm.Controls.Clear();
                ShowForm.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;
            }
        }
        public void PanelWidth(int width)
        {
            splitContainer1.SplitterDistance = width;
        }
    }
}
