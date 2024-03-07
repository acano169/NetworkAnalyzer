using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkSniffer
{
    public partial class InicioUserControl : UserControl
    {
        public InicioUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base BaseForm = this.Parent as Base;

            if (BaseForm != null) {
                BaseForm.InicioFormVisible = false;
                BaseForm.AnalizadorFormVisible = true;
            }
        }

        private void InicioUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
