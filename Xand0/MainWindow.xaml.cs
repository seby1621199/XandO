using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Xand0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nr = 0;
        StartMenu menu;
        Game game = new Game();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void clear(object sender)
        {
            var obj = (Grid)sender;
            obj.Children.Clear();
            obj.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF302F2F");

        }

        public void get_menu(object sender)
        {
            var obj = (StartMenu)sender;
            menu = obj;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            var test = (Grid)sender;
            test.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF515050");

            MaterialDesignThemes.Wpf.PackIcon iconX = new MaterialDesignThemes.Wpf.PackIcon();
            iconX.Kind = MaterialDesignThemes.Wpf.PackIconKind.AlphaX;
            iconX.VerticalAlignment = VerticalAlignment.Center;
            iconX.HorizontalAlignment = HorizontalAlignment.Center;
            iconX.Width = _0and0.Width;
            iconX.Height = _0and0.Height;

            MaterialDesignThemes.Wpf.PackIcon iconO = new MaterialDesignThemes.Wpf.PackIcon();
            iconO.Kind = MaterialDesignThemes.Wpf.PackIconKind.AlphaO;
            iconO.VerticalAlignment = VerticalAlignment.Center;
            iconO.HorizontalAlignment = HorizontalAlignment.Center;
            iconO.Width = _0and0.Width;
            iconO.Height = _0and0.Height;

            int y = System.Windows.Controls.Grid.GetColumn(test);
            int x = System.Windows.Controls.Grid.GetRow(test);
            if (nr % 2 == 0 && game.check_empty(x, y))
            {
                test.Children.Add(iconX);
                {
                    game.add(nr, x, y);
                    nr++;
                }
            }
            else
            {
                if (game.check_empty(x, y))
                {
                    test.Children.Add(iconO);

                    game.add(nr, x, y);
                    nr++;
                }

            }
            if (game.win() == "x")
            {

                menu.player_x_score.Text = (int.Parse(menu.player_x_score.Text) + 1).ToString();

                nr = 0;
                MessageBox.Show("X","Winner");
                game.clear();
                clear(_0and0);
                clear(_0and0);
                clear(_0and1);
                clear(_0and2);
                clear(_1and0);
                clear(_1and1);
                clear(_1and2);
                clear(_2and0);
                clear(_2and1);
                clear(_2and2);
                clear(_2and2);
            }
            if (game.win() == "o")
            {
                menu.player_o_score.Text = (int.Parse(menu.player_o_score.Text) + 1).ToString();

                nr = 0;
                MessageBox.Show("O","Winner");
                game.clear();
                clear(_0and0);
                clear(_0and0);
                clear(_0and1);
                clear(_0and2);
                clear(_1and0);
                clear(_1and1);
                clear(_1and2);
                clear(_2and0);
                clear(_2and1);
                clear(_2and2);
                clear(_2and2);
            }
            if (nr == 9 && game.win() != "x" && game.win() != "o")
            {
                nr = 0;
                MessageBox.Show("DRAW", "We have a draw");
                game.clear();
                clear(_0and0);
                clear(_0and0);
                clear(_0and1);
                clear(_0and2);
                clear(_1and0);
                clear(_1and1);
                clear(_1and2);
                clear(_2and0);
                clear(_2and1);
                clear(_2and2);
                clear(_2and2);
            }
        }

        private new void MouseEnter(object sender, MouseEventArgs e)
        {
            //#FF766868
            var obj = (Grid)sender;
            int y = System.Windows.Controls.Grid.GetColumn(obj);
            int x = System.Windows.Controls.Grid.GetRow(obj);
            if (game.check_empty(x, y))
                obj.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF201E1E");

        }

        private new void MouseLeave(object sender, MouseEventArgs e)
        {
            var obj = (Grid)sender;
            int y = System.Windows.Controls.Grid.GetColumn(obj);
            int x = System.Windows.Controls.Grid.GetRow(obj);
            if (game.check_empty(x, y))
                obj.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF302F2F");

        }
    }
}
