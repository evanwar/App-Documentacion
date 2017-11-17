using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWService.Consultas.Datos_Generales;

namespace MVVM.Modelos.DatosGenerales
{
    public class ModeloDatosGenerales : ModeloBase
    {
        Datos_Generales conexion;

        public ModeloDatosGenerales()
        {
            conexion = new Datos_Generales();
        }

        private async void GetDatosGenerales()
        {
            var task = await conexion.Get();

            
        }
    }
}
