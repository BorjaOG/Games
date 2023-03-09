namespace Juegos
{
    partial class frmAltaJuego
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lblcreador = new System.Windows.Forms.Label();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.txbgenero = new System.Windows.Forms.TextBox();
            this.txbcreador = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Location = new System.Drawing.Point(43, 113);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(42, 13);
            this.lblgenero.TabIndex = 1;
            this.lblgenero.Text = "Genero";
            // 
            // lblcreador
            // 
            this.lblcreador.AutoSize = true;
            this.lblcreador.Location = new System.Drawing.Point(43, 174);
            this.lblcreador.Name = "lblcreador";
            this.lblcreador.Size = new System.Drawing.Size(44, 13);
            this.lblcreador.TabIndex = 2;
            this.lblcreador.Text = "Creador";
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(111, 54);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(100, 20);
            this.txbnombre.TabIndex = 3;
            // 
            // txbgenero
            // 
            this.txbgenero.Location = new System.Drawing.Point(111, 110);
            this.txbgenero.Name = "txbgenero";
            this.txbgenero.Size = new System.Drawing.Size(100, 20);
            this.txbgenero.TabIndex = 4;
            // 
            // txbcreador
            // 
            this.txbcreador.Location = new System.Drawing.Point(111, 171);
            this.txbcreador.Name = "txbcreador";
            this.txbcreador.Size = new System.Drawing.Size(100, 20);
            this.txbcreador.TabIndex = 5;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(44, 363);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(92, 32);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(215, 363);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 32);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmAltaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txbcreador);
            this.Controls.Add(this.txbgenero);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.lblcreador);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAltaJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo juego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lblcreador;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.TextBox txbgenero;
        private System.Windows.Forms.TextBox txbcreador;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}