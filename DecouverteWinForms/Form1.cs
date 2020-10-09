using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecouverteWinForms
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickChiffre(object sender, EventArgs e)
        {
            ExampleClass exampleFinalise = new ExampleClass();
            exampleFinalise.ShowDuration();

            Saisie += ((Button)sender).Text;

            if (Operateur == string.Empty)
                PremierNombre = decimal.Parse(Saisie);
            else
                DeuxiemeNombre = decimal.Parse(Saisie.Substring(Saisie.LastIndexOf(Operateur) + 1));

            TextBoxResultat.Text = Saisie;
        }

        private void buttonClickOperation(object sender, EventArgs e)
        {
            Operateur = ((Button)sender).Text;
            Saisie += Operateur;
            TextBoxResultat.Text = Saisie;
        }

        private void buttonEgal_Click(object sender, EventArgs e)
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
