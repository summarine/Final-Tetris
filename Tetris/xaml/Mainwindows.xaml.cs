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
using System.Media;
namespace Tetris.xaml
{
    /// <summary>
    /// Main.xaml 的交互逻辑
    /// </summary>
    public partial class Mainwindows : Window
    {
        static private SoundPlayer soundPlayer = new SoundPlayer(System.Environment.CurrentDirectory + @"\Resources\Audio\1.wav");
        public Mainwindows()
        {
            InitializeComponent();
            
            //或者
            //SoundPlayer soundPlayer = new SoundPlayer(@"Resources\Audio\didi.wav");
            soundPlayer.PlayLooping();
        }
        private void Stop()
        {
            soundPlayer.Stop();
        }

        // button click events
        public void start_Click(object sender, RoutedEventArgs e)
        {
            //
            // to change to the start.xaml
            Stop();
            Start start = new Start();
            start.Show();
        }

        public void settingbtn_Click(object sender, RoutedEventArgs e)
        {
            //// to achieve the button click 
            //if (this.settingbtn.Focusable == false)
            //{
            //    this.settingbtn.Focusable = true;
            //    this.settingbtn.Focus();
            //}
            //else
            //{
            //    this.settingbtn.Focusable = false;
            //}
            //show setting.xaml
            //this.Hide();
            Setting setting =new Setting();
            setting.Show();           

        }


        public void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            // to achieve the button click
            if (this.exitbtn.Focusable == false)
            {
                this.exitbtn.Focusable = true;
                this.exitbtn.Focus();
            }
            else
            {
                this.exitbtn.Focusable = false;
            }
            // to exit the window
            Application.Current.Shutdown();
            base.OnClosed(e);

        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    Ratingwindow ratingwindow = new Ratingwindow();
        //    ratingwindow.Show();
        //}
    }
}
