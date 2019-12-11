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

namespace Tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int XorO = 1;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            {
                button_Copy5.Content = "O";
                XorO++;
            }
            else
            {
                button_Copy5.Content = "X";
                XorO--;
            }
        }
    }
}

