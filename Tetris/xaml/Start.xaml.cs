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
    /// Start.xaml 的交互逻辑
    /// </summary>
    public partial class Start : Window
    {
        public Start()
        {
            this.InitializeComponent();
        }

        //chang to the single.xaml
        public void singlebtn_Click(object sender, EventArgs e)
        {
            //page to page
            //NavigationService.GetNavigationService(this).Navigate(new Uri("./xaml/Single.xaml", UriKind.Relative));
            //windows to page
            //NavigationWindow single = new NavigationWindow();
            //single.Source = new Uri("./xaml/Single.xaml", UriKind.Relative);
            //single.Show();
            
            Single single = new Single();
            Thickness thick = new Thickness(6, 10, 4, 10);
            single.Margin = thick;
            this.replace.Children.Clear();
            this.replace.Children.Add(single);
            
        }

        public void doublebtn_Click(object sender, EventArgs e)
        {
            @double doublewindow = new @double();
            Thickness thick = new Thickness(10, 10, 10, 10);
            doublewindow.Margin = thick;
            this.replace.Children.Clear();
            this.replace.Children.Add(doublewindow);
        }
        public void aibtn_Click(object sender, EventArgs e)
        {
            //AIWindow aiwindow = new AIWindow();
            //aiwindow.Show();
            DoublePlayer doubleplay = new DoublePlayer();
            doubleplay.Show();
        }
    }
}
