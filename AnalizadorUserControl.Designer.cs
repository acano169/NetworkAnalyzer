using System.Windows.Forms;

namespace NetworkSniffer
{
    partial class AnalizadorUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void StartFocus()
        {
            this.IPTextBox1.SelectAll();
            this.IPTextBox1.Focus();
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back = new System.Windows.Forms.Button();
            this.IPTextBox1 = new System.Windows.Forms.TextBox();
            this.PointLabel1 = new System.Windows.Forms.Label();
            this.PointLabel2 = new System.Windows.Forms.Label();
            this.IPTextBox2 = new System.Windows.Forms.TextBox();
            this.PointLabel3 = new System.Windows.Forms.Label();
            this.IPTextBox3 = new System.Windows.Forms.TextBox();
            this.IPTextBox4 = new System.Windows.Forms.TextBox();
            this.IPInput = new System.Windows.Forms.Panel();
            this.ValidIPLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F);
            this.Back.Location = new System.Drawing.Point(20, 19);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 42);
            this.Back.TabIndex = 1;
            this.Back.Text = "Volver";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // IPTextBox1
            // 
            this.IPTextBox1.AcceptsTab = true;
            this.IPTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.IPTextBox1.Location = new System.Drawing.Point(10, 3);
            this.IPTextBox1.MaxLength = 3;
            this.IPTextBox1.Name = "IPTextBox1";
            this.IPTextBox1.ShortcutsEnabled = false;
            this.IPTextBox1.Size = new System.Drawing.Size(55, 30);
            this.IPTextBox1.TabIndex = 1;
            this.IPTextBox1.Text = "0";
            this.IPTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointLabel1
            // 
            this.PointLabel1.AutoSize = true;
            this.PointLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.PointLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointLabel1.Location = new System.Drawing.Point(65, 3);
            this.PointLabel1.Name = "PointLabel1";
            this.PointLabel1.Size = new System.Drawing.Size(22, 29);
            this.PointLabel1.TabIndex = 6;
            this.PointLabel1.Text = ".";
            // 
            // PointLabel2
            // 
            this.PointLabel2.AutoSize = true;
            this.PointLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.PointLabel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.PointLabel2.Location = new System.Drawing.Point(142, 3);
            this.PointLabel2.Name = "PointLabel2";
            this.PointLabel2.Size = new System.Drawing.Size(22, 29);
            this.PointLabel2.TabIndex = 8;
            this.PointLabel2.Text = ".";
            // 
            // IPTextBox2
            // 
            this.IPTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPTextBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.IPTextBox2.Location = new System.Drawing.Point(87, 3);
            this.IPTextBox2.MaxLength = 3;
            this.IPTextBox2.Name = "IPTextBox2";
            this.IPTextBox2.ShortcutsEnabled = false;
            this.IPTextBox2.Size = new System.Drawing.Size(55, 30);
            this.IPTextBox2.TabIndex = 2;
            this.IPTextBox2.Text = "0";
            this.IPTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointLabel3
            // 
            this.PointLabel3.AutoSize = true;
            this.PointLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.PointLabel3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.PointLabel3.Location = new System.Drawing.Point(219, 3);
            this.PointLabel3.Name = "PointLabel3";
            this.PointLabel3.Size = new System.Drawing.Size(22, 29);
            this.PointLabel3.TabIndex = 10;
            this.PointLabel3.Text = ".";
            // 
            // IPTextBox3
            // 
            this.IPTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPTextBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.IPTextBox3.Location = new System.Drawing.Point(164, 3);
            this.IPTextBox3.MaxLength = 3;
            this.IPTextBox3.Name = "IPTextBox3";
            this.IPTextBox3.ShortcutsEnabled = false;
            this.IPTextBox3.Size = new System.Drawing.Size(55, 30);
            this.IPTextBox3.TabIndex = 3;
            this.IPTextBox3.Text = "0";
            this.IPTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IPTextBox4
            // 
            this.IPTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPTextBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.IPTextBox4.Location = new System.Drawing.Point(241, 3);
            this.IPTextBox4.MaxLength = 3;
            this.IPTextBox4.Name = "IPTextBox4";
            this.IPTextBox4.ShortcutsEnabled = false;
            this.IPTextBox4.Size = new System.Drawing.Size(55, 30);
            this.IPTextBox4.TabIndex = 4;
            this.IPTextBox4.Text = "0";
            this.IPTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IPInput
            // 
            this.IPInput.BackColor = System.Drawing.SystemColors.Window;
            this.IPInput.Controls.Add(this.IPTextBox2);
            this.IPInput.Controls.Add(this.IPTextBox4);
            this.IPInput.Controls.Add(this.PointLabel1);
            this.IPInput.Controls.Add(this.IPTextBox3);
            this.IPInput.Controls.Add(this.PointLabel3);
            this.IPInput.Controls.Add(this.PointLabel2);
            this.IPInput.Controls.Add(this.IPTextBox1);
            this.IPInput.Location = new System.Drawing.Point(201, 205);
            this.IPInput.Name = "IPInput";
            this.IPInput.Size = new System.Drawing.Size(306, 37);
            this.IPInput.TabIndex = 12;
            // 
            // ValidIPLabel
            // 
            this.ValidIPLabel.AutoSize = true;
            this.ValidIPLabel.Location = new System.Drawing.Point(230, 397);
            this.ValidIPLabel.Name = "ValidIPLabel";
            this.ValidIPLabel.Size = new System.Drawing.Size(57, 20);
            this.ValidIPLabel.TabIndex = 13;
            this.ValidIPLabel.Text = "0.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // AnalizadorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValidIPLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.IPInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnalizadorUserControl";
            this.Size = new System.Drawing.Size(721, 641);
            this.Load += new System.EventHandler(this.AnalizadorUserControl_Load);
            this.IPInput.ResumeLayout(false);
            this.IPInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Back;
        private TextBox IPTextBox1;
        private Label PointLabel1;
        private Label PointLabel2;
        private TextBox IPTextBox2;
        private Label PointLabel3;
        private TextBox IPTextBox3;
        private TextBox IPTextBox4;
        private Panel IPInput;
        private Label ValidIPLabel;
        private Label label1;
    }
}
