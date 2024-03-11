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
        private IPAddress IPAddress;
        private string IPAddressBinary;

        public AnalizadorUserControl()
        {
            InitializeComponent();

            this.IPTextBox1.KeyPress += this.IPTextBox_KeyPress;
            this.IPTextBox1.PreviewKeyDown += this.IPTextBox_PreviewKeyDown;
            this.IPTextBox1.KeyDown += this.IPTextBox_KeyDown;
            this.IPTextBox1.TextChanged += this.IPTextBox_TextChanged;

            this.IPTextBox2.KeyPress += this.IPTextBox_KeyPress;
            this.IPTextBox2.PreviewKeyDown += this.IPTextBox_PreviewKeyDown;
            this.IPTextBox2.KeyDown += this.IPTextBox_KeyDown;
            this.IPTextBox2.TextChanged += this.IPTextBox_TextChanged;

            this.IPTextBox3.KeyPress += this.IPTextBox_KeyPress;
            this.IPTextBox3.PreviewKeyDown += this.IPTextBox_PreviewKeyDown;
            this.IPTextBox3.KeyDown += this.IPTextBox_KeyDown;
            this.IPTextBox3.TextChanged += this.IPTextBox_TextChanged;

            this.IPTextBox4.KeyPress += this.IPTextBox_KeyPress;
            this.IPTextBox4.PreviewKeyDown += this.IPTextBox_PreviewKeyDown;
            this.IPTextBox4.KeyDown += this.IPTextBox_KeyDown;
            this.IPTextBox4.TextChanged += this.IPTextBox_TextChanged;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (this.Parent is Base BaseForm)
            {
                BaseForm.AnalizadorFormVisible = false;
                BaseForm.InicioFormVisible = true;
            }
        }

        private void IPTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void IPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Keys pressedKey = e.KeyData;
            TextBox currentTextBox = (TextBox)sender;


            if (currentTextBox.SelectionStart == 0 && (pressedKey == Keys.Left || pressedKey == Keys.Back))
            {
                MoveFocusToPreviousTextBox(currentTextBox);
                e.Handled = true;
            }
            else if (pressedKey == Keys.Return || pressedKey == Keys.OemPeriod || (currentTextBox.SelectionStart == currentTextBox.Text.Length && pressedKey == Keys.Right))
            {
                MoveFocusToNextTextBox(currentTextBox);
                e.Handled = true;
            }
        }

        private void MoveFocusToPreviousTextBox(TextBox currentTextBox)
        {
            int previousTabIndex = currentTextBox.TabIndex - 1;
            MoveFocusToTextBoxByTabIndex(previousTabIndex);
        }

        private void MoveFocusToNextTextBox(TextBox currentTextBox)
        {
            int nextTabIndex = currentTextBox.TabIndex + 1;
            MoveFocusToTextBoxByTabIndex(nextTabIndex);
        }

        private void MoveFocusToTextBoxByTabIndex(int tabIndex)
        {
            var textBoxes = new Dictionary<int, TextBox>
            {
                { 1, IPTextBox1 },
                { 2, IPTextBox2 },
                { 3, IPTextBox3 },
                { 4, IPTextBox4 }
            };

            if (textBoxes.TryGetValue(tabIndex, out var nextTextBox))
            {
                nextTextBox.SelectAll();
                nextTextBox.Focus();
            }
        }

        private void IPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedKey = (char)e.KeyChar;

            if (char.IsLetter(pressedKey) || pressedKey == ' ' || (!char.IsControl(pressedKey) && !char.IsDigit(pressedKey)))
            {
                e.Handled = true;
                return;
            }

            TextBox TextBoxSender = (TextBox)sender;

            if (char.IsDigit(pressedKey)) 
            {
                TextBoxSender.Text = TextBoxSender.Text.TrimStart('0');

                if (TextBoxSender.Text.Length > 0 && TextBoxSender.Text.Length == 2)
                {

                    if (int.Parse(TextBoxSender.Text + pressedKey) > 255)
                    {
                        TextBoxSender.Text = "255";
                        TextBoxSender.SelectionStart = 3;
                    }

                    if (TextBoxSender.TabIndex != 4)
                    {
                        SendKeys.Send("{Tab}");
                    }
                }
            }
        }

        private void IPTextBox_TextChanged(object sender, EventArgs e)
        {
            ParseIPAdress();
        }

        private void ParseIPAdress()
        {
            IPAddressString = IPTextBox1.Text + "." + IPTextBox2.Text + "." + IPTextBox3.Text + "." + IPTextBox4.Text;
            ValidIP = IPAddress.TryParse(IPAddressString, out IPAddress);
            if (ValidIP) 
            {
                this.ValidIPLabel.Text = IPAddressString;
                IPAddressBinary = this.IPStringToBinary(IPAddress);
                this.label1.Text = IPAddressBinary;
            } 
            else
            {
                this.ValidIPLabel.Text = "IP no válida";
            }
        }

        private String IPStringToBinary(IPAddress IPAddress) 
        {
            var IPAddressBytes = IPAddress
                .GetAddressBytes()
                .Select(number => Convert.ToString(number, 2).PadLeft(8, '0'));
            return string.Join(".", IPAddressBytes);
        }

        private void AnalizadorUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}