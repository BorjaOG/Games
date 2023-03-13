namespace Juegos
{
    partial class frmPersonajes
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
            this.dgvPersonajes = new System.Windows.Forms.DataGridView();
            this.pbPersonajes = new System.Windows.Forms.PictureBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.Location = new System.Drawing.Point(40, 60);
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.Size = new System.Drawing.Size(523, 197);
            this.dgvPersonajes.TabIndex = 0;
            this.dgvPersonajes.SelectionChanged += new System.EventHandler(this.dgvPersonajes_SelectionChanged);
            // 
            // pbPersonajes
            // 
            this.pbPersonajes.Location = new System.Drawing.Point(582, 60);
            this.pbPersonajes.Name = "pbPersonajes";
            this.pbPersonajes.Size = new System.Drawing.Size(206, 197);
            this.pbPersonajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonajes.TabIndex = 1;
            this.pbPersonajes.TabStop = false;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(40, 345);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(137, 36);
            this.btnAgregarP.TabIndex = 2;
            this.btnAgregarP.Text = "Add Character";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click_1);
            // 
            // frmPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.pbPersonajes);
            this.Controls.Add(this.dgvPersonajes);
            this.Name = "frmPersonajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonajes";
            this.Load += new System.EventHandler(this.frmPersonajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.PictureBox pbPersonajes;
        private System.Windows.Forms.Button btnAgregarP;
    }
}