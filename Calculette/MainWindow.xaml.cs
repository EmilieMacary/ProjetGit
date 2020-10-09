using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        private const string PUISSANCE = "^";

        public decimal Resultat { get; set; } = 0;
        public string Saisie { get; set; } = string.Empty;
        public string Operateur { get; set; } = string.Empty;
        public decimal PremierNombre { get; set; } = 0;
        public decimal DeuxiemeNombre { get; set; } = 0;

        public Dictionary<string, string> OperateursMethodes = new Dictionary<string, string>() { { PLUS, "Add" }, { MOINS, "Subtract" }, { MULTIPLIER, "Multiply" }, { DIVISER, "Divide" } };

        private delegate void MonDelegate(string str);

        private event MonDelegate MonEvent;

        private delegate decimal DelegateOperation(decimal nb1, decimal nb2);

        private event DelegateOperation EventOperation;

        private readonly Dictionary<string, DelegateOperation> _convertStringOperation = new Dictionary<string, DelegateOperation>()
        {
            { PLUS, decimal.Add }, { MOINS, decimal.Subtract }, { MULTIPLIER, decimal.Multiply }, { DIVISER, decimal.Divide }, { PUISSANCE, PowNumbers}
        };

        public MainWindow()
        {
            InitializeComponent();
            ButtonPlus.Content = PLUS;
            ButtonMoins.Content = MOINS;
            ButtonMultiplier.Content = MULTIPLIER;
            ButtonDiviser.Content = DIVISER;
            ButtonPuissance.Content = PUISSANCE;
            
            decimal decimalDuScope = 17;
            // exemple delegate
            DelegateOperation exampleEvent = (n1, n2) => { return n1 * n2 + decimalDuScope; }; //n1 et n2 seront renseignés à l'appel de exampleEvent
            // equivalent à
            DelegateOperation exampleEvent2 = (n1, n2) => n1 * n2 + decimalDuScope;

        }

        private void ButtonClickChiffre(object sender, RoutedEventArgs e)
        {
            MonEvent?.Invoke((string)((Button)sender).Content);

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

            EventOperation = _convertStringOperation[Operateur];

        }

        private void ButtonClickEgal(object sender, RoutedEventArgs e)
        {
            // var toto = typeof(string).GetMembers();
            //MethodBase operation = typeof(decimal).GetMethod(OperateursMethodes[Operateur]);
            //Resultat = (decimal)operation.Invoke(null, new object[] { PremierNombre, DeuxiemeNombre });

            Resultat = EventOperation(PremierNombre, DeuxiemeNombre);
            Saisie = Resultat.ToString();
            TextBoxResultat.Text = Saisie;
            Operateur = string.Empty;
            PremierNombre = Resultat;
            DeuxiemeNombre = 0;
        }

        private void MyMethod(string str)
        {
            TextBoxResultat.Text = str;
        }

        private void MyMethod2(string str)
        {
            TextBoxResultat.Text = str;
        }

        public static decimal PowNumbers(decimal number1, decimal number2)
        {
            return (decimal)Math.Pow((double)number1, (double)number2);
        }

        private void ButtonSubscribeClick(object sender, RoutedEventArgs e)
        {
            MonEvent += MyMethod;
            MonEvent += MyMethod2;
        }

        private void ButtonUnsubscribeClick(object sender, RoutedEventArgs e)
        {
            MonEvent = null;
        }
    }
}
