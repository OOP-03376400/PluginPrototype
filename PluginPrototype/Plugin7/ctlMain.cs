using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plugin7
{
    public partial class ctlMain : UserControl
    {
        public ctlMain()
        {
            InitializeComponent();
        }

        private void ctlMain_Load(object sender, EventArgs e)
        {

            UserControl1 wpfCtrl = new UserControl1();
            wpfCtrl.InitializeComponent();
            elementHost1.Child = wpfCtrl;
        }
    }
}
