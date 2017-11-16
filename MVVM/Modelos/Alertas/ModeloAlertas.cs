using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.Modelos.Alertas
{
    public class ModeloAlertas : ModeloBase
    {
        #region Campos
        private String mensajeAlert;

        private Visibility mostrarAlerta;
        #endregion

        #region Propiedades


        public RelayCommand ComandoCancelar
        {
            get
            {
                return new RelayCommand(Cancelar);
            }
        }

        public String MensajeAlert
        {
            get { return mensajeAlert; }
            set { mensajeAlert = value; OnPropertyChanged(); }
        }


        public Visibility MostarAlerta
        {
            get { return mostrarAlerta; }
            set { mostrarAlerta = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor
        public ModeloAlertas()
        {
            mostrarAlerta = Visibility.Collapsed;
        }
        #endregion

        #region Funciones
        public void ShowAlert(Boolean visible = false, String mensaje = "")
        {
            MensajeAlert = mensaje;
            MostarAlerta = visible ? Visibility.Visible : Visibility.Collapsed;
        }
        #endregion

        #region Comandos


        private void Cancelar()
        {
            ShowAlert(false);
        }

        #endregion
    }
}
