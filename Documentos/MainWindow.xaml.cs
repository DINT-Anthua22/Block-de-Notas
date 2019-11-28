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
        string ancho, alto;
        Configuracion config;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void NuevoDocumentoButton_Click(object sender, RoutedEventArgs e)
        {
            Documento documento = new Documento();

            documento.Owner = this;
            documento.Show();
            documento.Title +=" "+ this.OwnedWindows.Count.ToString();

        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {

            config = new Configuracion();
            config.AnchoTextBox.Text = ancho;
            config.AltoTextBox.Text = alto;
            ancho = config.Ancho;
            alto = config.Alto;

            config.ShowDialog();

           
            
        }
    }
}
