using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para Documento.xaml
    /// </summary>
    public partial class Documento : Window
    {
        public Documento()
        {
            InitializeComponent();
            Configuracion c = new Configuracion();
            double ancho, alto;
            alto=double.Parse(c.AltoTextBox.Text);
            ancho=double.Parse(c.AnchoTextBox.Text);
            this.Height = alto;
            this.Width = ancho;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result=MessageBox.Show("¿Seguro que quieres cerrar?", "Cerrar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    e.Cancel = false;
                    break;
                case MessageBoxResult.No:
                    e.Cancel = true;
                    break;
            }

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            string ruta;

            SaveFileDialog dialogo = new SaveFileDialog();

            dialogo.Filter = "Archivos de texto (*.txt)|*.txt";
            
            dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (dialogo.ShowDialog()==true)
            {
                ruta = dialogo.FileName;
                StreamWriter streamWriter =new StreamWriter(ruta, true, Encoding.UTF8);
                streamWriter.Write(TextoTextBox.Text);
                streamWriter.Close();
            }
        }
    }
}
