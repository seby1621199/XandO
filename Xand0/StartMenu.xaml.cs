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

namespace Xand0
{
    /// <summary>
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Window
    {
        public StartMenu()
        {
            InitializeComponent();
        }
        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btn_close_MouseEnter(object sender, MouseEventArgs e)
        {
            icon_exit.Foreground = Brushes.IndianRed;

        }

        private void btn_close_MouseLeave(object sender, MouseEventArgs e)
        {
            icon_exit.Foreground = new SolidColorBrush(Color.FromRgb(221, 255, 255));

        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.get_menu(this);
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            player_x_score.Text = "0";
            player_o_score.Text = "0";
        }
    }
}
