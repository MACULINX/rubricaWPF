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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            int idx = 0;
            Contatto[] Contatti = new Contatto[100];

            

            try
            {
                StreamReader buffer = new StreamReader("Dati.csv");
                while (!buffer.EndOfStream)
                {
                    string row = buffer.ReadLine();
                    Contatto contatto = new Contatto(row);

                    Contatti[idx++] = contatto;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < Contatti.Length; i++)
                if (Contatti[i] == null)
                    Contatti[i] = new Contatto();

            
            /*
            Contatto c = new Contatto();

            c.Nome = "Marco";
            c.Cognome = "Bucci";
            c.Email = "marco.bucci@studenti.ittsrimini.edu.it";

            Contatti[0] = c;
            */

            dgArray.ItemsSource = Contatti;

        }
    }
}
