using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //Skapar en ny instans av fönstret
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bnt3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bnt4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}