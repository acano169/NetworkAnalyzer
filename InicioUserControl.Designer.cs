namespace NetworkSniffer
{
    partial class InicioUserControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mapper = new System.Windows.Forms.Button();
            this.Analyzer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mapper
            // 
            this.Mapper.Location = new System.Drawing.Point(456, 232);
            this.Mapper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mapper.Name = "Mapper";
            this.Mapper.Size = new System.Drawing.Size(208, 125);
            this.Mapper.TabIndex = 3;
            this.Mapper.Text = "Mapeador";
            this.Mapper.UseVisualStyleBackColor = true;
            // 
            // Analyzer
            // 
            this.Analyzer.Location = new System.Drawing.Point(134, 232);
            this.Analyzer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Analyzer.Name = "Analyzer";
            this.Analyzer.Size = new System.Drawing.Size(208, 125);
            this.Analyzer.TabIndex = 2;
            this.Analyzer.Text = "Analizador";
            this.Analyzer.UseVisualStyleBackColor = true;
            this.Analyzer.Click += new System.EventHandler(this.button1_Click);
            // 
            // InicioUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Mapper);
            this.Controls.Add(this.Analyzer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InicioUserControl";
            this.Size = new System.Drawing.Size(826, 591);
            this.Load += new System.EventHandler(this.InicioUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mapper;
        private System.Windows.Forms.Button Analyzer;
    }
}
