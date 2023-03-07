using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Juego
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }    
        public string Creador { get; set; }       
        public string Imagen { get; set; }
        public string Fecha_Lanzamiento { get; set; }

    }
}
