using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWService.ModelBD;

namespace WWService.Consultas.Datos_Generales
{
    public class Datos_Generales : IOperacionesCrudcs<tbl_DatosGenerales>
    {
        Repositorio repositorio;

        public async Task<Respuesta<IEnumerable<tbl_DatosGenerales>>> Get(int usuario = 0, int skip = 0, int take = 0)
        {
            try
            {
                repositorio = new Repositorio();

                var lista = await repositorio.DatosGeneralesRepository.Get(x => x.intusuarioId == usuario);

                return new Respuesta<IEnumerable<tbl_DatosGenerales>>(lista, String.Empty);
            }
            catch (Exception ex)
            {
                return new Respuesta<IEnumerable<tbl_DatosGenerales>>(null, ex.Message);
            }
            finally
            {
                repositorio.Dispose();
            }
        }
    }
}
