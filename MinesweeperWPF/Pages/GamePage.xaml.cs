using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Minesweeper.Pages
{
    /// <summary>
    /// Logique d'interaction pour GamePage.xaml
    /// </summary>
    public sealed partial class GamePage : Page
    {
        static GamePage()
        {
            
        }

        private GamePage()
        {
            InitializeComponent();
        }

        public static GamePage GamePageInstance { get; } = new GamePage();
    }
}
