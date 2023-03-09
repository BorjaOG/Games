using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class PersonajeNegocio
    {
        private int idJuego;

        public PersonajeNegocio(int idJuego)
        {
            this.idJuego = idJuego;
        }

        public List<Personaje> Listar()
        {
            List<Personaje> listaP = new List<Personaje>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT P.Nombre, P.habilidad, P.Imagen, P.IdJuego, J.Id FROM Personajes P JOIN Juegos J ON P.IdJuego = J.Id WHERE P.IdJuego = @idJuego");
                datos.comando.Parameters.Clear();
                datos.comando.Parameters.AddWithValue("@idJuego", this.idJuego);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Personaje aux = new Personaje();
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Habilidad = (string)datos.Lector["Habilidad"];
                    aux.Imagen = (string)datos.Lector["Imagen"];
                    aux.Id = (int)datos.Lector["Id"];

                    listaP.Add(aux);
                }
                return listaP;
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
        public void AgregarP(Personaje personaje)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Insert into Personaje (Nombre, Habilidad, Imagen, Id) values ('" + personaje.Nombre + "','" + personaje.Habilidad + "', '" + personaje.Imagen + "','" + personaje.Id + "') ");
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


