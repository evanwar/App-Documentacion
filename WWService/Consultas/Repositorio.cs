using System;
using WWService.ModelBD;

namespace WWService.Consultas
{
    public class Repositorio : IDisposable
    {

        dbDocumentacionEntities contexto = new dbDocumentacionEntities();

        private CRUD<tbl_DatosGenerales> datosGeneralesRepository;


        public CRUD<tbl_DatosGenerales> DatosGeneralesRepository
        {
            get
            {
                if (datosGeneralesRepository == null)
                {
                    this.datosGeneralesRepository = new CRUD<tbl_DatosGenerales>(contexto);
                }

                return datosGeneralesRepository;
            }

        }


        public async void Save()
        {
          await  contexto.SaveChangesAsync();
        }

        private Boolean disposed = false;

        protected virtual void Dispose(Boolean disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    contexto.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
