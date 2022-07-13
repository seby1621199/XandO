using System;
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
        Menu menu;
        Game game = new Game();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void clear(object sender)
        {
            var obj = (Grid)sender;
            obj.Children.Clear();
            obj.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF938383");

        }

        public void get_menu(object sender)
        {
            var obj = (Menu)sender;
            menu = obj;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            var test = (Grid)sender;
            test.Background = System.Windows.Media.Brushes.Wheat;
            System.Windows.Controls.Image imgx = new System.Windows.Controls.Image();
            System.Windows.Controls.Image imgo = new System.Windows.Controls.Image();

            imgx.Source = new BitmapImage(new Uri(@"C:\Users\sysor\source\repos\Xand0\Xand0\x.jpg"));
            imgo.Source = new BitmapImage(new Uri(@"C:\Users\sysor\source\repos\Xand0\Xand0\o.jpg"));

            imgx.Width = 100;
            imgx.Height = 100;
            imgx.Visibility = Visibility.Visible;
            imgo.Height = 100;
            imgo.Width = 100;
            int y = System.Windows.Controls.Grid.GetColumn(test);
            int x = System.Windows.Controls.Grid.GetRow(test);
            if (nr % 2 == 0 && game.check_empty(x, y))
            {
                test.Children.Add(imgx);
                {
                    game.add(nr, x, y);
                    nr++;
                }
            }
            else
            {
                if (game.check_empty(x, y))
                {
                    test.Children.Add(imgo);

                    game.add(nr, x, y);
                    nr++;
                }

            }
            if (game.win() == "x")
            {

                menu.player_x_score.Text = (int.Parse(menu.player_x_score.Text) + 1).ToString();

                nr = 0;
                MessageBox.Show("X");
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
                MessageBox.Show("o");
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
                MessageBox.Show("DRAW");
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
                obj.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF766868");

        }

        private new void MouseLeave(object sender, MouseEventArgs e)
        {
            var obj = (Grid)sender;
            int y = System.Windows.Controls.Grid.GetColumn(obj);
            int x = System.Windows.Controls.Grid.GetRow(obj);
            if (game.check_empty(x, y))
                obj.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF938383");

        }
    }
}
