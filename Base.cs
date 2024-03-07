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
    public partial class Base : Form
    {

        public InicioUserControl InicioForm;
        public AnalizadorUserControl AnalizadorForm;

        public bool InicioFormVisible
        {
            get { return InicioForm.Visible; }
            set { InicioForm.Visible = value; UpdateFormSize(); }
        }

        public bool AnalizadorFormVisible
        {
            get { return AnalizadorForm.Visible; }
            set { AnalizadorForm.Visible = value; UpdateFormSize(); }
        }

        private void UpdateFormSize()
        {
            if (InicioFormVisible)
            {
                Size = new Size(InicioForm.Width, InicioForm.Height);
            }
            else if (AnalizadorFormVisible)
            {
                Size = new Size(AnalizadorForm.Width, AnalizadorForm.Height);
            }
        }

        public Base()
        {
            InitializeComponent();

            InicioForm = new InicioUserControl();
            AnalizadorForm = new AnalizadorUserControl();

            InicioForm.Visible = true;
            AnalizadorForm.Visible = false;

            Controls.Add(InicioForm);
            Controls.Add(AnalizadorForm);

            UpdateFormSize();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            this.ClientSize = InicioForm.Size;
            InicioForm.Location = new Point(0, 0);
        }
    }
}
