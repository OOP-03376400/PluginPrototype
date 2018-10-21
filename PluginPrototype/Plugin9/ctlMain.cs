using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plugin9
{
    public partial class ctlMain : UserControl
    {
        private MyControl1 wpfCtrl;


        public ctlMain()
        {
            InitializeComponent();
        }

        private void plotterDisplayEx1_Load(object sender, EventArgs e)
        {

        }

        private void ctlMain_Load(object sender, EventArgs e)
        {
            wpfCtrl = new MyControl1();
            wpfCtrl.InitializeComponent();
            elementHost1.Child = wpfCtrl;
        }
    }
}


// References
// http://www.switchonthecode.com/tutorials/wpf-tutorial-using-wpf-in-winforms
// http://msdn.microsoft.com/en-us/library/ms742215.aspx
// http://msdn.microsoft.com/en-us/library/ms754008.aspx
// http://www.switchonthecode.com/frameworks/wpf
// http://www.codeproject.com/Articles/6334/Plug-ins-in-C
//
//
//
//