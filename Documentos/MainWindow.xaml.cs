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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _alto="500";
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
        string _ancho="500";
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
        Configuracion config;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void NuevoDocumentoButton_Click(object sender, RoutedEventArgs e)
        {
            Documento documento = new Documento();

            documento.Owner = this;
            documento.Width = double.Parse(Ancho);
            documento.Height = double.Parse(Alto);
            documento.Title +=" "+ this.OwnedWindows.Count.ToString();
            documento.Show();
           

        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {

            config = new Configuracion();
            config.Owner = this;

            config.Ancho = Ancho;
            config.Alto = Alto;

           if(config.ShowDialog() == true){
                Alto = config.Alto;
                Ancho = config.Ancho;
           }
            
           
            
        }
    }
}
