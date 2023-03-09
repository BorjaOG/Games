namespace Juegos
{
    partial class AgregarJ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbNombreP = new System.Windows.Forms.TextBox();
            this.txbHabilidadP = new System.Windows.Forms.TextBox();
            this.txbImagenP = new System.Windows.Forms.TextBox();
            this.NombreP = new System.Windows.Forms.Label();
            this.HabilidadP = new System.Windows.Forms.Label();
            this.ImagenP = new System.Windows.Forms.Label();
            this.btnAceptarP = new System.Windows.Forms.Button();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNombreP
            // 
            this.txbNombreP.Location = new System.Drawing.Point(116, 57);
            this.txbNombreP.Name = "txbNombreP";
            this.txbNombreP.Size = new System.Drawing.Size(100, 20);
            this.txbNombreP.TabIndex = 0;
            // 
            // txbHabilidadP
            // 
            this.txbHabilidadP.Location = new System.Drawing.Point(116, 121);
            this.txbHabilidadP.Name = "txbHabilidadP";
            this.txbHabilidadP.Size = new System.Drawing.Size(100, 20);
            this.txbHabilidadP.TabIndex = 1;
            // 
            // txbImagenP
            // 
            this.txbImagenP.Location = new System.Drawing.Point(116, 187);
            this.txbImagenP.Name = "txbImagenP";
            this.txbImagenP.Size = new System.Drawing.Size(100, 20);
            this.txbImagenP.TabIndex = 2;
            // 
            // NombreP
            // 
            this.NombreP.AutoSize = true;
            this.NombreP.Location = new System.Drawing.Point(29, 63);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(44, 13);
            this.NombreP.TabIndex = 3;
            this.NombreP.Text = "Nombre";
            // 
            // HabilidadP
            // 
            this.HabilidadP.AutoSize = true;
            this.HabilidadP.Location = new System.Drawing.Point(29, 128);
            this.HabilidadP.Name = "HabilidadP";
            this.HabilidadP.Size = new System.Drawing.Size(51, 13);
            this.HabilidadP.TabIndex = 4;
            this.HabilidadP.Text = "Habilidad";
            // 
            // ImagenP
            // 
            this.ImagenP.AutoSize = true;
            this.ImagenP.Location = new System.Drawing.Point(29, 194);
            this.ImagenP.Name = "ImagenP";
            this.ImagenP.Size = new System.Drawing.Size(42, 13);
            this.ImagenP.TabIndex = 5;
            this.ImagenP.Text = "Imagen";
            // 
            // btnAceptarP
            // 
            this.btnAceptarP.Location = new System.Drawing.Point(42, 304);
            this.btnAceptarP.Name = "btnAceptarP";
            this.btnAceptarP.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarP.TabIndex = 6;
            this.btnAceptarP.Text = "Aceptar";
            this.btnAceptarP.UseVisualStyleBackColor = true;
            this.btnAceptarP.Click += new System.EventHandler(this.btnAceptarP_Click);
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.Location = new System.Drawing.Point(194, 304);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarP.TabIndex = 7;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.UseVisualStyleBackColor = true;
            // 
            // AgregarJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 394);
            this.Controls.Add(this.btnCancelarP);
            this.Controls.Add(this.btnAceptarP);
            this.Controls.Add(this.ImagenP);
            this.Controls.Add(this.HabilidadP);
            this.Controls.Add(this.NombreP);
            this.Controls.Add(this.txbImagenP);
            this.Controls.Add(this.txbHabilidadP);
            this.Controls.Add(this.txbNombreP);
            this.Name = "AgregarJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nuevo Personaje";
            this.Load += new System.EventHandler(this.AgregarJ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombreP;
        private System.Windows.Forms.TextBox txbHabilidadP;
        private System.Windows.Forms.TextBox txbImagenP;
        private System.Windows.Forms.Label NombreP;
        private System.Windows.Forms.Label HabilidadP;
        private System.Windows.Forms.Label ImagenP;
        private System.Windows.Forms.Button btnAceptarP;
        private System.Windows.Forms.Button btnCancelarP;
    }
}