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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            //Konverterar "string" till int
            int row = int.Parse(txtRow.Text);
            int column = int.Parse(txtColumn.Text);
            
                // Kontrollerar om rader och kolumner är giltiga inom Gridens storlek
                if (row >= 0 && row <= 3 && column >= 0 && column <= 3)  
                {
                    // Flytta knappen till den angivna raden och kolumnen
                    Grid.SetRow(btnrowandcolumn, row);
                    Grid.SetColumn(btnrowandcolumn, column);
                    btnrowandcolumn.Content = "Row " + row + ", Column " + column;
                }
                else
                {
                    MessageBox.Show("Row and Column values must be between 0 and 3.");
                }
            }
            
            
            

        }
    }

