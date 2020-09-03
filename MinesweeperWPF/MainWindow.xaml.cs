using Minesweeper.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region fields
        /// <summary>
        /// Page d'une partie
        /// </summary>
        private GamePage game;
        private OptionsPage options;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            this.MainFrame.Source = new Uri("Pages/HomePage.xaml", UriKind.Relative);
        }

        /// <summary>
        /// Handler appelé lors d'un click sur l'un des item du menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu = ((MenuItem)e.Source);
            if ( menu == NewGame)
            {
                if (game == null)
                    game = GamePage.GamePageInstance;
                MainFrame.Navigate(game);
            }
            if (menu == Options)
            {
                if (options == null)
                    options = OptionsPage.OptionsPageInstance;
                MainFrame.Navigate(options);
            }
                

        }
    }
}
