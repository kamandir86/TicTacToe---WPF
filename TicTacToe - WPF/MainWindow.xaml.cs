using BoardLogic;
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

namespace TicTacToe___WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Board game = new Board();

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var space = (Button)sender;
            if (!String.IsNullOrWhiteSpace(space.Content?.ToString())) return;
            space.Content = Board.CurrentPlayer;
            // setting X or O in place of a button
            Board.SetNextPlayer();
            // changing the player sign
            
        }

        private void NewGameButton(object sender, RoutedEventArgs e)
        {
            foreach (var item in fieldBoard.Children)
            {
                if (item is Button)
                {
                    ((Button)item).Content = String.Empty;
                }
            }
        }
    }
}
