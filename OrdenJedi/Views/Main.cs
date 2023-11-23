using OrdenJedi.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenJedi
{
    public partial class FrmMain : Form
    {
        VMMain vMMain = new VMMain();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            vMMain.InitMain(this);
        }
    }
}
