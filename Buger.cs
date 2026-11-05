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
    public partial class Buger : UserControl
    {
        public Buger()
        {
            InitializeComponent(); 
            pnlBuger.Size = new Size(70, 56);
        }
        bool btnBugerClicked = false;
        private void btnBuger_Click(object sender, EventArgs e)
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
            Form1 form = (Form1)this.ParentForm;
            form?.PanelWidth(pnlBuger.Width);
        }
        private void Controlbtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Form1 form = (Form1)this.ParentForm;
            form?.PanelLoading(btn.Tag.ToString());
        }
    }
}
