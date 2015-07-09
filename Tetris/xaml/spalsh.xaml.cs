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

namespace Tetris.xaml
{
    /// <summary>
    /// spalsh.xaml 的交互逻辑
    /// </summary>
    public partial class spalsh : Window
    {
        public spalsh()
        {
            InitializeComponent();
        }

        private void startMainwindows_Click(object sender, RoutedEventArgs e)
        {
            Mainwindows mainwindow = new Mainwindows();
            mainwindow.Show();
            //this.WindowState = System.Windows.WindowState.Minimized;
            this.Close();

        }
    }
}
