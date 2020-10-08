using System.Windows;

namespace DecouverteWPF
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


        private void MonBouton_Click(object sender, RoutedEventArgs e)
        {
            MonLabel.Content = "toto";
        }
    }
}
