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

namespace Tetris
{
	/// <summary>
	/// Single.xaml 的交互逻辑
	/// </summary>
	public partial class Single : UserControl
	{
		public Single()
		{
			this.InitializeComponent();
		}

      
        private void classicbtn_Click(object sender, RoutedEventArgs e)
        {
            Singleplaywindow singleplayer = new Singleplaywindow();
            singleplayer.Show();
        }

        private void demonbtn_Click(object sender, RoutedEventArgs e)
        {
            demon demon = new demon();
            demon.Show();
        }
	}
}