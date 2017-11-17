using System.Collections.Generic;
using System.Threading.Tasks;

namespace WWService.Consultas
{
    public interface IOperacionesCrudcs<TEntity> where TEntity : class
    {
        Task<Respuesta<IEnumerable<TEntity>>> Get(int usuario = 0, int skip = 0, int take = 0);
    }
}
