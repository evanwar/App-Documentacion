using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWService.Consultas.Datos_Generales;
using WWService.ModelBD;

namespace MVVM.Modelos.DatosGenerales
{
    public class ModeloDatosGenerales : ModeloBase
    {
        #region Campos
        Datos_Generales conexion;


        private ObservableCollection<tbl_DatosGenerales> datosGenerales;
        #endregion

        #region Propiedades


        public ObservableCollection<tbl_DatosGenerales> DatosGenerales
        {
            get { return datosGenerales; }
            set
            {
                datosGenerales = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region Constructor

        public ModeloDatosGenerales()
        {
            Inicializar();
        }

        #endregion

        #region Funciones

        public override void Inicializar()
        {
            conexion=new Datos_Generales();

            GetDatosGenerales();
        }

        private async void GetDatosGenerales()
        {
            var resultado =await conexion.Get();

            if (resultado.Objeto != null)
            {
                DatosGenerales = new ObservableCollection<tbl_DatosGenerales>(resultado.Objeto);
            }
            else
            {
                DatosGenerales = new ObservableCollection<tbl_DatosGenerales>();
            }


        }

        #endregion





    }
}
