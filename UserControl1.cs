using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetForegroundWindow
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            pnlBuger.Width = 236;
            pnlBuger.Dock = DockStyle.Left;
        }
        bool btnBugerClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!btnBugerClicked)    //顯示整個選單
            {
                btnBugerClicked = true;
                pnlBuger.Width = 236;
                this.ActiveControl = null;      //失去焦點
                pnlBuger.Dock = DockStyle.Left;
            }
            else        //只顯示"三"
            {
                btnBugerClicked = false;
                pnlBuger.Size = new Size(70, 56);
                pnlBuger.Dock = DockStyle.None;
            }
        }
        private void buttonControlForm_Click(object sender, EventArgs e)
        {
            Button buttonControl = sender as Button;
            Form1 form = (Form1)this.ParentForm;    
            form?.PanelLoading(buttonControl.Tag as string);
        }
    }
}
