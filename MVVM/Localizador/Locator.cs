using MVVM.Modelos.Inicio;
using System.ComponentModel;
using System.Windows;

namespace MVVM.Localizador
{
    public class Locator
    {
        private DependencyObject dummy = new DependencyObject();

        public ModeloInicio InicioViwModel
        {
            get
            {
                if (IsInDesignMode())
                {
                    return new ModeloInicio();
                }

                return new ModeloInicio();
            }
        }

        private bool IsInDesignMode()
        {
            return DesignerProperties.GetIsInDesignMode(dummy);
        }
    }
}
