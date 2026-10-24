namespace GetForegroundWindow
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            panel1.Width = 236;
            panel1.Dock = DockStyle.Left;
        }
        bool button3Clicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!button3Clicked)    //顯示整個選單
            {
                button3Clicked = true;
                panel1.Width = 236;
                this.ActiveControl = null;      //失去焦點
                panel1.Dock = DockStyle.Left;
            }
            else        //只顯示"三"
            {
                button3Clicked = false;
                panel1.Width = 70;
                panel1.Dock = DockStyle.None;
            }
        }
        private void buttonControlForm_Click(object sender, EventArgs e)
        {
            Button buttonControl = sender as Button;
            string userControl = buttonControl.Tag as string;
            Form1 form = (Form1)this.ParentForm;
            form?.PanelLoading(userControl);
        }
    }
}
