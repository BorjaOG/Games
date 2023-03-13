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
    public partial class frmPersonajes : Form
    {
        private Juego juego = null;

        private List<Personaje> listaPersonaje;
        public frmPersonajes(Juego juego)
        {
            InitializeComponent();
            this.juego = juego;
        }

        private void frmPersonajes_Load(object sender, EventArgs e)
        {


            PersonajeNegocio negocio = new PersonajeNegocio(juego.Id);

            try
            {
                listaPersonaje = negocio.Listar();
                dgvPersonajes.DataSource = listaPersonaje;
                if (listaPersonaje.Count > 0)
                {
                    pbPersonajes.Load(listaPersonaje[0].Imagen);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvPersonajes_SelectionChanged(object sender, EventArgs e)
        {
            Personaje seleccionado = (Personaje)dgvPersonajes.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.Imagen);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbPersonajes.Load(imagen);
            }
            catch (Exception ex)
            {

                pbPersonajes.Load("https://worldwellnessgroup.org.au/wp-content/uploads/2020/07/placeholder.png");
            }
        }




        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            frmAltaPersonaje frmAltaPersonaje = new frmAltaPersonaje();


            //agregar personaje..
        }

        private void btnAgregarP_Click_1(object sender, EventArgs e)
        {

        }
    }
}