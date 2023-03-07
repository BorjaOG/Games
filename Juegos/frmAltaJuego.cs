using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Juegos
{
    public partial class frmAltaJuego : Form
    {
        public frmAltaJuego()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            
            Juego nuevo = new Juego();
            JuegoNegocio negocio = new JuegoNegocio();
            try
            {
                nuevo.Nombre = txbnombre.Text;
                nuevo.Genero = txbgenero.Text;
                nuevo.Creador = txbcreador.Text;

                negocio.Agregar(nuevo);
                MessageBox.Show("Juego Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
