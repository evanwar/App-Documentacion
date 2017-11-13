using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_Documentacion.Vistas.Inicio
{
    /// <summary>
    /// Lógica de interacción para AreaDeTrabajo.xaml
    /// </summary>
    public partial class AreaDeTrabajo : Page
    {
        public WorItem Tarea { get; set; }
        public AreaDeTrabajo()
        {
            InitializeComponent();

            Tarea = new WorItem
            {
                Tarea = "Tarea 1",
                Title = "1254-CEM-4324"
            };

            this.DataContext = this;

        }
    }

    public class WorItem
    {
        public String Title { get; set; }

        public String Tarea { get; set; }
    }
}
