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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockPanelWindow.xaml
    /// </summary>
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage(new Uri("C:\\Users\\kevin\\Source\\Repos\\hemuppgift-wpf-kevindaouk\\Hemuppgift_WPFtemplate\\TrophyImage.jpg"));

            // Ställ in bilden på Image-kontrollen och visa den
            imageControl.Source = bitmap;
            imageControl.Visibility = Visibility.Visible;
        }
    }
}
