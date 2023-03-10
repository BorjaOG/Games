using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juegos
{


    public partial class AgregarJ : Form
    {
        public AgregarJ()
        {
            InitializeComponent();
        }
        public bool Insertar(Personaje personaje)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("INSERT INTO Personajes (Nombre, Habilidad, Imagen, Id_Juego) VALUES (@nombre, @habilidad, @imagen, @id_juego)");
                datos.comando.Parameters.Clear();
                datos.comando.Parameters.AddWithValue("@nombre", personaje.Nombre);
                datos.comando.Parameters.AddWithValue("@habilidad", personaje.Habilidad);
                datos.comando.Parameters.AddWithValue("@imagen", personaje.Imagen);
                datos.comando.Parameters.AddWithValue("@id_juego", personaje.Id);
                datos.EjecutarAccion();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
       

        public void btnAceptarP_Click(object sender, EventArgs e)
        {
            PersonajeNegocio negocio = new PersonajeNegocio(0);
            try
            {
                Personaje nuevoPersonaje = new Personaje();
                nuevoPersonaje.Nombre = txbNombreP.Text;
                nuevoPersonaje.Habilidad = txbHabilidadP.Text;
                nuevoPersonaje.Imagen = txbImagenP.Text;

                negocio.AgregarP(nuevoPersonaje);
                MessageBox.Show("El personaje se ha guardado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el personaje: " + ex.Message);
            }
        }
        // cargar el frmAltaPersonajes
        private void AgregarJ_Load(object sender, EventArgs e)
        {

        }
    }
}
