using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWService.Consultas
{
    public class Respuesta<T>
    {
        public T Objeto { get; set; }
        public String Mensaje { get; set; }

        public Respuesta(T objeto, String mensaje)
        {
            this.Objeto = objeto;
            this.Mensaje = mensaje;
        }

        public Respuesta()
        {
            this.Mensaje = String.Empty;
        }
    }
}
