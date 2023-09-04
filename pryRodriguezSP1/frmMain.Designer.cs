namespace pryRodriguezSP1
{
    partial class frmMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(189, 195);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(124, 32);
            this.btnLeer.TabIndex = 1;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(25, 194);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(124, 33);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(64, 23);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(204, 96);
            this.txtDatos.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(332, 256);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "frmMain";
            this.Text = "Broker Seguros";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtDatos;
    }
}

