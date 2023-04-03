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
            omstart();
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

            // Har spelare 1 vunnit?
            HarVunnit("X");

            // Har spelare 2 vunnit?
            HarVunnit("O");
        }

        // En metod för att återställa spelet
        public void omstart()
        {
            // Tömma rutorna
            knapp1.Content = "";
            knapp2.Content = "";
            knapp3.Content = "";
            knapp4.Content = "";
            knapp5.Content = "";
            knapp6.Content = "";
            knapp7.Content = "";
            knapp8.Content = "";
            knapp9.Content = "";

            // Spelare 1 börjar (X)
            spelareTur = true;
        }

        // Har någon spelare vunnit?
        public void HarVunnit(string tecken)
        {
            if (knapp1.Content == tecken && knapp2.Content == tecken && knapp3.Content == tecken ||
                knapp4.Content == tecken && knapp5.Content == tecken && knapp6.Content == tecken ||
                knapp7.Content == tecken && knapp8.Content == tecken && knapp9.Content == tecken || 
                knapp1.Content == tecken && knapp4.Content == tecken && knapp7.Content == tecken ||
                knapp2.Content == tecken && knapp5.Content == tecken && knapp8.Content == tecken ||
                knapp3.Content == tecken && knapp6.Content == tecken && knapp9.Content == tecken ||
                knapp1.Content == tecken && knapp5.Content == tecken && knapp9.Content == tecken ||
                knapp3.Content == tecken && knapp5.Content == tecken && knapp7.Content == tecken)
            {
                MessageBox.Show("Spelare 1 har vunnit!");
                omstart();
            }
        }
    }
}
