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

namespace LuffarSchackPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Rita ut spelplan
            SkapaSpelplan();
        }

        // Metod för att hantera knappen KlickStarta
        private void KlickStarta(object sender, RoutedEventArgs e)
        {

        }

        // Skapa spelplanen
        public void SkapaSpelplan()
        {
            // Ange antal rader och kolumner i griden
            for (int i = 0; i < 4; i++)
            {
                spelplan.RowDefinitions.Add(new RowDefinition());
                spelplan.ColumnDefinitions.Add(new ColumnDefinition());
            }

            // Loopafram flera rader
            for (int j = 0; j < 4; j++)
            {
                // Loopa fram en rad
                for (int i = 0; i < 4; i++)
                {
                    // SKapa en virtuell knapp
                    Button knapp = new Button();

                    // Virtuella knappens position i griden
                    Grid.SetRow(knapp, j);
                    Grid.SetColumn(knapp, i);

                    // Rita ut knappen
                    spelplan.Children.Add(knapp);
                }
            }
        }
    }
}
