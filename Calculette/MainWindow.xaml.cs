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

            if (Operation == string.Empty)
                PremierNombre = double.Parse(Saisie);
            else
                DeuxiemeNombre = double.Parse(Saisie.Substring(Saisie.LastIndexOf(Operation) + 1));

            TextBoxResultat.Text = Saisie;
        }

        private void ButtonClickOperation(object sender, RoutedEventArgs e)
        {
            Operation = (string)((Button)sender).Content;
            Saisie += Operation;
            TextBoxResultat.Text = Saisie;
        }


        private void ButtonClickEgal(object sender, RoutedEventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    Resultat = PremierNombre + DeuxiemeNombre;
                    break;
                case "-":
                    Resultat = PremierNombre - DeuxiemeNombre;
                    break;
                case "*":
                    Resultat = PremierNombre * DeuxiemeNombre;
                    break;
                case "/":
                    Resultat = PremierNombre / DeuxiemeNombre;
                    break;
                default:
                    break;
            }
            Saisie = Resultat.ToString();
            TextBoxResultat.Text = Saisie;
            Saisie = string.Empty;
            PremierNombre = 0;
            DeuxiemeNombre = 0;
            Operation = string.Empty;
        }
    }
}
