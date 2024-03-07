using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkSniffer
{
    public partial class AnalizadorUserControl : UserControl
    {

        private bool ValidIP = false;
        private string IPAddressString;

        public AnalizadorUserControl()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (this.Parent is Base BaseForm)
            {
                BaseForm.AnalizadorFormVisible = false;
                BaseForm.InicioFormVisible = true;
            }
        }

        private void IPTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if ((!char.IsControl(((char)e.KeyData)) && ((char)e.KeyValue) != ((char)Keys.Left) && ((char)e.KeyValue) != ((char)Keys.Right)) && !char.IsDigit(((char)e.KeyData)))
            {
                e.Handled = true;
                return;
            }

            TextBox TextBoxSender = (TextBox)sender;

            if (TextBoxSender.Text.Length > 0 && TextBoxSender.Text.Length == 2)
            {
                if (Char.IsDigit(((char)e.KeyValue))) {
                    if (int.Parse(TextBoxSender.Text + ((char)e.KeyValue)) > 255)
                    {
                        TextBoxSender.Text = "255";
                    }
                    SendKeys.Send("{Tab}");
                }
            }
            if (TextBoxSender.SelectionStart == 0 && (((char)e.KeyValue) == ((char)Keys.Left) || ((char)e.KeyValue) == ((char)Keys.Back)))
            {
                int PreviousTextBox = TextBoxSender.TabIndex - 1;
                switch (PreviousTextBox)
                {
                    case 1:
                        IPTextBox1.Focus();
                        break;
                    case 2:
                        IPTextBox2.Focus();
                        break;
                    case 3:
                        IPTextBox3.Focus();
                        break;
                }
            }
            else if(((char)e.KeyValue) == ((char)Keys.Return) || (TextBoxSender.SelectionStart == TextBoxSender.Text.Length && ((char)e.KeyValue) == ((char)Keys.Right)))
            {
                int PreviousTextBox = TextBoxSender.TabIndex + 1;
                switch (PreviousTextBox)
                {
                    case 2:
                        IPTextBox2.Focus();
                        break;
                    case 3:
                        IPTextBox3.Focus();
                        break;
                    case 4:
                        IPTextBox4.Focus();
                        break;
                }
            }
            ParseIPAdress();
        }

        private void IPTextBox_TextChanged(object sender, EventArgs e)
        {
            ParseIPAdress();
        }

        private void ParseIPAdress()
        {
            IPAddressString = IPTextBox1.Text + "." + IPTextBox2.Text + "." + IPTextBox3.Text + "." + IPTextBox4.Text;
            ValidIP = IPAddress.TryParse(IPAddressString, out _);
        }

        private void AnalizadorUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}