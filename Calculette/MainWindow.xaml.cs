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

namespace Calculette
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Resultat { get; set; }
        public string Saisie { get; set; }
        public string Operation { get; set; }
        public double PremierNombre { get; set; }
        public double DeuxiemeNombre { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Saisie = String.Empty;
            Resultat = 0;
            PremierNombre = 0;
            DeuxiemeNombre = 0;
            Operation = String.Empty;
        }

        private void ButtonClickDigit(object sender, RoutedEventArgs e)
        {
            Saisie += (string)((Button)sender).Content;

            if (Operation == String.Empty)
                PremierNombre = Double.Parse(Saisie);
            else
                DeuxiemeNombre = Double.Parse(Saisie.Substring(Saisie.LastIndexOf(Operation) + 1));

            TextBoxResultat.Text = Saisie;
        }

        private void ButtonClickPlus(object sender, RoutedEventArgs e)
        {
            string OperationPlus = (string)((Button)sender).Content;
            Saisie += OperationPlus;
            Operation = OperationPlus;

            TextBoxResultat.Text = Saisie;
        }

        private void ButtonClickEgal(object sender, RoutedEventArgs e)
        {

        }
    }
}
