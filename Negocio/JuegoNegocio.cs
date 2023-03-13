using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;

namespace Negocio
{
    public class JuegoNegocio
    {
        public List<Juego> Listar()
        {
            List<Juego> lista = new List<Juego>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=Juegos_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Nombre, Genero, Creador, Imagen, Fecha_Lanzamiento from Juegos";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Juego aux = new Juego();
                    aux.Id = (int)lector["Id"];
                    aux.Name = (string)lector["Nombre"];
                    aux.Type = (string)lector["Genero"];
                    aux.Developer = (string)lector["Creador"];
                    aux.Image = (string)lector["imagen"];
                    aux.Date = (string)lector["Fecha_Lanzamiento"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Agregar(Juego nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Insert into Juegos (Nombre, Genero, Creador) values ('"+ nuevo.Name +"','"+ nuevo.Type +"', '"+nuevo.Developer +"') ");
                datos.EjecutarAccion();
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
    }
}
