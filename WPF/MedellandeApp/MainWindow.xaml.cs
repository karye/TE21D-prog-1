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
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace MedellandeApp
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

        /// <summary>
        /// Hantera klick på knappen Skicka
        /// </summary>
        /// <param name="sender">Vilket element som klickats på</param>
        /// <param name="e">Eventuella argument</param>
        private void KlickSkicka(object sender, RoutedEventArgs e)
        {
            // Läsa av epostadressen
            string epost = rutaEpost.Text;

            // Läsa av meddelandet
            string texten = rutaTexten.Text;

            // Hälsocheck!
            // Vi kontrollerar att epostadressen har rätt format
            string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(epost, regexEpost))
            {
                if (texten != "")
                {
                    // Inloggningsuppgifter
                    string id = "karim@gmail.com";
                    string lösen = "....";

                    // Input från amvändaren verkar ok!
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(id, lösen);

                    // Nu skicka vi...
                    smtp.Send(epost, id, "rubrik", texten);

                    // Bekräftelse till användaren
                    rutaStatus.Text = "Meddelandet skickat!";
                }
                else
                {
                    rutaStatus.Text = "Textmeddelandet saknas!";
                }
            }
            else
            {
                rutaStatus.Text = "Epostadressen saknas!";
            }
        }
    }
}
