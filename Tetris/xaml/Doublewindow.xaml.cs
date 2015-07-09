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
using System.Threading;
namespace Tetris
{
	/// <summary>
	/// @double.xaml 的交互逻辑
	/// </summary>
	public partial class @double : UserControl
	{
		public @double()
		{
			this.InitializeComponent();
		}
        public void Serverbtn_Click(object sender, EventArgs e)
        {

            LanServer server = new LanServer();
            Thread t2 = new Thread(() =>
            {
                server = new LanServer();
                server.RunServer(4530);
            });
            t2.Start();
            MessageBox.Show("You have successfully create a server! Enjoy yourself!");
        }
        public void Clientbtn_Click(object sender, EventArgs e)
        {
            tempwin tempwin = new tempwin();
            tempwin.Show();
        }
        public void Localbtn_Click(object sender, EventArgs e)
        {
            doublepeople doublepeople = new doublepeople();
            doublepeople.Show();          
        }
	}
    
}