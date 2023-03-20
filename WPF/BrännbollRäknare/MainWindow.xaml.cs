using System;
using System.IO;
using System.Timers;
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

namespace BrännbollRäknare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Poäng i brännboll
        const int poängFrivarv = 5;
        const int poängBränning = 2;
        const int poängLyra = 2;
        const int poängVarv = 1;

        // Variabler för att summera lagens poäng
        int totalInne = 0;
        int totalUte = 0;

        public MainWindow()
        {
            InitializeComponent();

            // Skapa en timer
            Timer timer = new Timer(1000);
            timer.Elapsed += OnTimerEvent;
            timer.Start();
        }

        private void OnTimerEvent(Object source, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(UppdateraKlockan);
        }

        private void UppdateraKlockan()
        {
            // Tiden just nu
            DateTime nu = DateTime.Now;

            // Skriv ut klockan
            rutaKlockan.Text = nu.ToString("HH:mm:ss");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KlickFrivarv(object sender, RoutedEventArgs e)
        {
            // Lag inne får frivarvs poäng
            totalInne += poängFrivarv;

            // Skriv ut nya totala poängen för innelaget
            rutaInne.Text = totalInne.ToString();

            // Tiden just nu
            DateTime nu = DateTime.Now;

            // Skriv händelsen i historiken
            rutaHistorik.Text += $"{nu.ToString("HH:mm:ss")} Frivarv + {poängFrivarv} poäng lag Inne\n";

            // Spara ned historiken för säkerhetsskull
            SparaTillFil();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KlickBränning(object sender, RoutedEventArgs e)
        {
            // Lag ute får bränning poäng
            totalUte += poängBränning;

            // Skriv ut nya totala poängen för utelaget
            rutaUte.Text = totalUte.ToString();

            // Tiden just nu
            DateTime nu = DateTime.Now;

            // Skriv händelsen i historiken
            rutaHistorik.Text += $"{nu.ToString("HH:mm:ss")} bränning + {poängBränning} poäng lag Ute\n";

            // Spara ned historiken för säkerhetsskull
            SparaTillFil();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KlickLyra(object sender, RoutedEventArgs e)
        {
            // Lag ute får bränning poäng
            totalUte += poängLyra;

            // Skriv ut nya totala poängen för utelaget
            rutaUte.Text = totalUte.ToString();

            // Tiden just nu
            DateTime nu = DateTime.Now;

            // Skriv händelsen i historiken
            rutaHistorik.Text += $"{nu.ToString("HH:mm:ss")} lyra + {poängLyra} poäng lag Ute\n";

            // Spara ned historiken för säkerhetsskull
            SparaTillFil();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KlickVarv(object sender, RoutedEventArgs e)
        {
            // Lag inne får frivarvs poäng
            totalInne += poängVarv;

            // Skriv ut nya totala poängen för innelaget
            rutaInne.Text = totalInne.ToString();

            // Tiden just nu
            DateTime nu = DateTime.Now;

            // Skriv händelsen i historiken
            rutaHistorik.Text += $"{nu.ToString("HH:mm:ss")} varv + {poängVarv} poäng lag Inne\n";

            // Spara ned historiken för säkerhetsskull
            SparaTillFil();
        }

        private void SparaTillFil()
        {
            string filnamn = "historik.txt";
            File.WriteAllText(filnamn, rutaHistorik.Text);
        }
    }
}
