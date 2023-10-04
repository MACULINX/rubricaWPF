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

namespace Bucci.Marco._4I.RubricaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Contatto c = new Contatto();

            //Qui scateniamo il setter
            try
            {
                c.Numero = 101;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            c.Nome = "Marco";
            c.Cognome = "Bucci";




            Contatto[] Contatti = new Contatto[100];
            Contatti[0] = c;

        }
    }
}
