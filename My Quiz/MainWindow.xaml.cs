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

namespace My_Quiz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> players;
        List<Questions> questions;
        string str;
        int d;
        public MainWindow()
        {
            InitializeComponent();
            players = new List<Player>()
            {
                new Player("Первый_игрок",0)
            };
            players = players.ToList();

        }
    }
}
