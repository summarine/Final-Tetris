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
using System.Threading;
namespace Tetris
{
    /// <summary>
    /// tempwin.xaml 的交互逻辑
    /// </summary>
    public partial class tempwin : Window
    {
        LanClient client = new LanClient();
        LanServer server = new LanServer();
        public tempwin()
        {
            InitializeComponent();
           
            //Thread t2 = new Thread(() =>
            //{
            //    server = new LanServer();
            //    server.RunServer(4530);
            //});
            //t2.Start();



            //this.Hide();
            //string IP;
            //string getIP = this.IPLable.ToString();
            //IP = getIP;
        }
        //static string[] iplist;
        static string IP;
        //private void IPLable_TextInput(object sender, TextCompositionEventArgs e)
        //{

        //    for (int i = 0; i < 15; i++)
        //    {
        //        iplist[i] = IPLable.ToString();
        //    }
           
        //}
        private void Connectbtn_Click_1(object sender,EventArgs e)
        {
            IP = IPaddress.Text;
            Thread t1 = new Thread(() =>
            {
                client = new LanClient();
                client.RunClient(IP);
            });
            t1.Start();
        }

       
    }
}
