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

        private Juego Id;

        public frmPersonajes()
        {
            InitializeComponent();
        }
       

        private void frmPersonajes_Load(object sender, EventArgs e)
        {
            
            
            PersonajeNegocio negocio = new PersonajeNegocio(juego.Id);
            
            try
            {               
                listaPersonaje = new List<Personaje>();
                dgvPersonajes.DataSource = listaPersonaje;
                pbPersonajes.Load(listaPersonaje[1].Imagen);                

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
    }
}
