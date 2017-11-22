using GalaSoft.MvvmLight.Command;
using MVVM.Modelos.Alertas;
using MVVM.Modelos.DatosGenerales;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MVVM.Modelos
{
    public class ModeloBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<WorItem> tareas;

        public ObservableCollection<WorItem> Tareas
        {
            get { return tareas; }
            set { tareas = value; OnPropertyChanged(); }
        }


        #region Campos

        private WindowState estadoVentana;

        private Uri displayPage;






        #endregion

        #region Propiedades


        public WindowState EstadoVentana
        {
            get { return estadoVentana; }
            set
            {

                estadoVentana = value;

                OnPropertyChanged();

            }
        }

        public Uri DisplayPage
        {
            get { return displayPage; }
            set
            {
                displayPage = value;
                OnPropertyChanged();
            }
        }

        public int IdUsuario { get; set; }


        public RelayCommand<String> ComandoEstadoVentana
        {
            get
            {
                return new RelayCommand<String>(AlternarEstadoVentana);
            }
        }

        public RelayCommand<Window> ComandoCerrarVentana
        {
            get
            {
                return new RelayCommand<Window>(CerrarVentana);
            }
        }

        public RelayCommand<String> Comandonavegar
        {
            get
            {
                return new RelayCommand<String>(Navegacion);
            }
        }


        #endregion

        #region Modelos

        private ModeloAlertas modeloALerta;

        public ModeloAlertas ModelALerta
        {
            get
            {
                if (modeloALerta == null)
                {
                    modeloALerta = new ModeloAlertas();
                }
                return modeloALerta;
            }
        }

        private ModeloDatosGenerales modeloDatosGenerales;

        public ModeloDatosGenerales ModeloDatosGenerales
        {
            get
            {
                if (modeloDatosGenerales == null)
                {
                    modeloDatosGenerales = new ModeloDatosGenerales();
                }
                return modeloDatosGenerales;
            }

        }


        #endregion

        #region Constructor

        public ModeloBase()
        {
           
        }

        #endregion

        #region Funciones

        public virtual void Inicializar()
        {


            tareas = new ObservableCollection<WorItem>();

            Tareas.Add(new WorItem
            {
                Tarea = "Tarea 1",
                Title = "1254-CEM-4324"
            });

        }


        #endregion

        #region Comandos

        private void AlternarEstadoVentana(String estado)
        {
            switch (estado)
            {

                case "Minimizar":

                    EstadoVentana = WindowState.Minimized;

                    break;

                case "Maximizar":

                    if (estadoVentana == WindowState.Maximized)
                    {
                        EstadoVentana = WindowState.Normal;
                    }
                    else
                    {
                        EstadoVentana = WindowState.Maximized;
                    }

                    break;
            }
        }

        private void CerrarVentana(Window w)
        {
            if (w != null)
            {
                w.Close();
            }
        }

        private void Navegacion(String pagina)
        {
            switch (pagina)
            {
                case "Inicio":
                    ModelALerta.ShowAlert(true, "Hola");
                    //DisplayPage = new Uri("Inicio/AreaDeTrabajo.xaml", UriKind.RelativeOrAbsolute);
                    break;
                case "Code":
                    DisplayPage = new Uri("Codigo/Code.xaml", UriKind.RelativeOrAbsolute);
                    break;

                case "Config":
                    DisplayPage = new Uri("Configuracion/Configuracion.xaml", UriKind.RelativeOrAbsolute);
                    break;
            }

        }


        #endregion

        #region Eventos


        public void OnPropertyChanged([CallerMemberName]String PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        #endregion

        #region Eventos Servicio

        #endregion
    }
}
public class WorItem
{
    public String Title { get; set; }

    public String Tarea { get; set; }
}