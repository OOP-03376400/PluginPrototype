using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Plugin8
{
    public partial class ctlMain : UserControl
    {
        public ctlMain()
        {
            MyControl wpfCtrl = new MyControl();
            InitializeComponent();
            wpfCtrl.InitializeComponent();
            elementHost1.Child = wpfCtrl;
        }
    }
}
