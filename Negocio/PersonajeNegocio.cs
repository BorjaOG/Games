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
        private Juego juego;

        public PersonajeNegocio(Juego juego)
        {
            this.juego = juego;
        }

        public PersonajeNegocio(int id)
        {
        }

        public List<Personaje> Listar(Juego juego)
        {
            List<Personaje> listaP = new List<Personaje>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearConsulta("Select P.Nombre, P.habilidad, P.Imagen, P.IdJuego, J.Id, from Personajes P, Juegos J where P.IdJuego = J.Id");
                datos.EjecutarLectura();
              
                
                
                while (datos.Lector.Read())
                {   
                   
                    
                    Personaje aux = new Personaje();
                    aux.Nombre = (string)datos.Lector["Nombre"]; 
                    aux.Habilidad = (string)datos.Lector["Habilidad"];
                    aux.Imagen = (string)datos.Lector["Imagen"];
                    aux.IdJuego = (string)datos.Lector["IdJuego"];
                    
                    

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
    }
}
