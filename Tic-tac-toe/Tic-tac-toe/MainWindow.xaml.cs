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
        int Oswins = 0;
        int Xswins = 0;
        List<Wins> wins = new List<Wins>();
        Osclass Os = new Wins(Oswins, Osname);
        Xsclass Xs = new Wins(Xswins, Xsname);
        private void Wins_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Wins a in wins)
            {
                a.Wins();
            }
        }

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

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            {
                button_Copy1.Content = "O";
                XorO++;
            }
            else
            {
                button_Copy1.Content = "X";
                XorO--;
            }
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            {
                button_Copy2.Content = "O";
                XorO++;
            }
            else
            {
                button_Copy2.Content = "X";
                XorO--;
            }
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            {
                button_Copy4.Content = "O";
                XorO++;
            }
            else
            {
                button_Copy4.Content = "X";
                XorO--;
            }
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            { 
                button_Copy6.Content = "O";
                XorO++;
            }
            else
            {
                button_Copy6.Content = "X";
                XorO--;
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            {
                button_Copy.Content = "O";
                XorO++;
            }
            else
            {
                button_Copy.Content = "X";
                XorO--;
            }
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            {
                button_Copy3.Content = "O";
                XorO++;
            }
            else
            {
                button_Copy3.Content = "X";
                XorO--;
            }
        }

        private void button_Copy7_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            {
                button_Copy7.Content = "O";
                XorO++;
            }
            else
            {
                button_Copy7.Content = "X";
                XorO--;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (XorO == 1)
            {
                button.Content = "O";
                XorO++;
            }
            else
            {
                button.Content = "X";
                XorO--;
            }
        }

        private void Osbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("O Wins!");
            Oswins++;

        }

        private void Xsbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("X Wins!");
            Xswins++;

        }
    }
}

