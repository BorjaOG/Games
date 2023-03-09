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
    public partial class frmJuego : Form
    {

        private List<Juego> listaJuego;
        public frmJuego()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JuegoNegocio negocio = new JuegoNegocio();
            listaJuego = negocio.Listar();
            dgvJuegos.DataSource = listaJuego;
            pbJuego.Load(listaJuego[0].Imagen);

        }

        private void dgvJuegos_SelectionChanged(object sender, EventArgs e)
        {
            Juego seleccionado = (Juego)dgvJuegos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.Imagen);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbJuego.Load(imagen);
            }
            catch (Exception ex)
            {

                pbJuego.Load("https://worldwellnessgroup.org.au/wp-content/uploads/2020/07/placeholder.png");
            }
            
        }

        private void btnPersonaje_Click(object sender, EventArgs e)
        {
            Juego seleccionado;
            seleccionado = (Juego)dgvJuegos.CurrentRow.DataBoundItem;

            frmPersonajes personajes = new frmPersonajes(seleccionado);
            personajes.Show();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            frmAltaJuego alta = new frmAltaJuego();
            alta.ShowDialog();
        }
    }
}
