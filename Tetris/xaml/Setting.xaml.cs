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
using System.Windows.Navigation;
namespace Tetris.xaml
{
    /// <summary>
    /// Setting.xaml 的交互逻辑
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void helpbtn_Click(object sender, RoutedEventArgs e)
        {
            help helpwindow = new help();
            helpwindow.Show();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ratingwindow rating = new Ratingwindow();
            rating.Show();

        }
    }

}
