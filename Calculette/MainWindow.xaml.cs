using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace Calculette
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string PLUS = "+";
        private const string MOINS = "-";
        private const string MULTIPLIER = "*";
        private const string DIVISER = "/";

        public decimal Resultat { get; set; } = 0;
        public string Saisie { get; set; } = string.Empty;
        public string Operateur { get; set; } = string.Empty;
        public decimal PremierNombre { get; set; } = 0;
        public decimal DeuxiemeNombre { get; set; } = 0;

        public Dictionary<string, string> OperateursMethodes = new Dictionary<string, string>() { { PLUS, "Add" }, { MOINS, "Subtract" }, { MULTIPLIER, "Multiply" }, { DIVISER, "Divide" } };

        public MainWindow()
        {
            InitializeComponent();
            ButtonPlus.Content = PLUS;
            ButtonMoins.Content = MOINS;
            ButtonMultiplier.Content = MULTIPLIER;
            ButtonDiviser.Content = DIVISER;
        }

        private void ButtonClickChiffre(object sender, RoutedEventArgs e)
        {
            Saisie += (string)((Button)sender).Content;

            if (Operateur == string.Empty)
                PremierNombre = decimal.Parse(Saisie);
            else
                DeuxiemeNombre = decimal.Parse(Saisie.Substring(Saisie.LastIndexOf(Operateur) + 1));

            TextBoxResultat.Text = Saisie;
        }

        private void ButtonClickOperateur(object sender, RoutedEventArgs e)
        {
            Operateur = (string)((Button)sender).Content;
            Saisie += Operateur;
            TextBoxResultat.Text = Saisie;
        }

        private void ButtonClickEgal(object sender, RoutedEventArgs e)
        {
            MethodBase operation = typeof(decimal).GetMethod(OperateursMethodes[Operateur]);
            Resultat = (decimal)operation.Invoke(null, new object[] { PremierNombre, DeuxiemeNombre });
            Saisie = Resultat.ToString();
            TextBoxResultat.Text = Saisie;
            Operateur = string.Empty;
            PremierNombre = Resultat;
            DeuxiemeNombre = 0;
        }
    }
}
