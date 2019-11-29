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
using System.Windows.Shapes;

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        string _alto;
        public string Alto
        {
            get
            {
                return _alto;
            }
            set
            {
                if (_alto != value)
                {
                    _alto = value;
                }
            }
        }
        string _ancho;
        public string Ancho
        {
            get
            {
                return _ancho;
            }
            set
            {
                if (_ancho != value)
                {
                    _ancho = value;
                }
            }
        }
        public Configuracion()
        {
            InitializeComponent();
        }

        private void AceptarButtton_Click(object sender, RoutedEventArgs e)
        {

            this.DialogResult = true;
            this.Close();
        }

        
    }
}
