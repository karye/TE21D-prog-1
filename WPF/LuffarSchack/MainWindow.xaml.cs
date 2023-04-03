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

namespace LuffarSchack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Global variabel
        bool spelareTur = true;

        public MainWindow()
        {
            InitializeComponent();

            // Rensa spelplanen
            knapp1.Content = "";
            knapp2.Content = "";
            knapp3.Content = "";
            knapp4.Content = "";
            knapp5.Content = "";
            knapp6.Content = "";
            knapp7.Content = "";
            knapp8.Content = "";
            knapp9.Content = "";
        }

        // Hantera klick på startknappen
        private void KlickStarta(object sender, RoutedEventArgs e)
        {
            
        }

        // Hantera klick på cellerna
        private void KlickKnapp(object sender, RoutedEventArgs e)
        {
            // Vem skickade "eventet"?
            Button knapp = (Button)sender;

            // Provar läsa av knappens namn
            //Console.WriteLine(knapp.Name);

            // Prova ändrar vad som står på knappen
            knapp.FontSize = 90;

            // Varannan gång spelare 1 och varannan spelare 2
            if (spelareTur)
            {
                knapp.Content = "X";
                spelareTur = false;
            }
            else
            {
                knapp.Content = "O";
                spelareTur = true;
            }

            // Är första raden XXX?
            if (knapp1.Content == "X" && knapp2.Content == "X" && knapp3.Content == "X")
            {
                MessageBox.Show("Spelare 1 har vunnit!");
            }
        }
    }
}
