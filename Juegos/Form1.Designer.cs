namespace Juegos
{
    partial class Form1
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
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.pbJuego = new System.Windows.Forms.PictureBox();
            this.btnPersonaje = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Location = new System.Drawing.Point(12, 72);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.Size = new System.Drawing.Size(596, 247);
            this.dgvJuegos.StandardTab = true;
            this.dgvJuegos.TabIndex = 0;
            this.dgvJuegos.SelectionChanged += new System.EventHandler(this.dgvJuegos_SelectionChanged);
            // 
            // pbJuego
            // 
            this.pbJuego.Location = new System.Drawing.Point(637, 72);
            this.pbJuego.Name = "pbJuego";
            this.pbJuego.Size = new System.Drawing.Size(245, 247);
            this.pbJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJuego.TabIndex = 1;
            this.pbJuego.TabStop = false;
            // 
            // btnPersonaje
            // 
            this.btnPersonaje.Location = new System.Drawing.Point(13, 340);
            this.btnPersonaje.Name = "btnPersonaje";
            this.btnPersonaje.Size = new System.Drawing.Size(110, 23);
            this.btnPersonaje.TabIndex = 2;
            this.btnPersonaje.Text = "Ver Personajes";
            this.btnPersonaje.UseVisualStyleBackColor = true;
            this.btnPersonaje.Click += new System.EventHandler(this.btnPersonaje_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(13, 383);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(151, 37);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnPersonaje);
            this.Controls.Add(this.pbJuego);
            this.Controls.Add(this.dgvJuegos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJuego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJuegos;
        private System.Windows.Forms.PictureBox pbJuego;
        private System.Windows.Forms.Button btnPersonaje;
        private System.Windows.Forms.Button btnagregar;
    }
}

